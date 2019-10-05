using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using TouchlessLib;
using System.Diagnostics;
using ZXing;
using MultiFaceRec;
using System.Net;
using System.IO;
using System.Net.Mail;
namespace BarcodeReaderApp
{
    public partial class Form1 : Form
    {
        private BarcodeReader _barcodeReader;
        private TouchlessMgr _touch;
        private const int _previewWidth = 640;
        private const int _previewHeight = 480;
		public string decoded;	//Biến phiên dịch

		public Form1()
        {
            InitializeComponent();

            // Initialize Dynamsoft Barcode Reader
            _barcodeReader = new BarcodeReader();
            // Initialize Touchless
            _touch = new TouchlessMgr();
			button2.Enabled = false;
			button4.Enabled = false;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;
                    
                    try
                    {
                        bitmap =  new Bitmap(dlg.FileName);
						button2.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }

                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image!");
                return;
            }

            ReadBarcode((Bitmap)pictureBox1.Image);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string button_text = button3.Text;
            if (button_text.Equals("Start Webcam"))
            {
                button3.Text = "Stop Webcam";
                StartCamera();
				button1.Enabled = false;
				button2.Enabled = false;
			}
            else
            {
                button3.Text = "Start Webcam";
				button1.Enabled = true;
				button2.Enabled = true;
				StopCamera();
            }  
        }

        private void StartCamera()
        {
            if (_touch.Cameras.Count == 0)
            {
                MessageBox.Show("No USB webcam connected");
                button3.Text = "Start Webcam";
                return;
            }            

            // Start to acquire images
            _touch.CurrentCamera = _touch.Cameras[0];
            _touch.CurrentCamera.CaptureWidth = _previewWidth; // Set width
            _touch.CurrentCamera.CaptureWidth = _previewHeight; // Set height
            _touch.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured); // Set preview callback function
        }

        private void StopCamera()
        {
            button3.Text = "Start Webcam";
            if (_touch.CurrentCamera != null)
            {
                _touch.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
            }
        }

        private void OnImageCaptured(object sender, CameraEventArgs args)
        {
            // Get the bitmap
            Bitmap bitmap = args.Image;

            // Read barcode and show results in UI thread
            this.Invoke((MethodInvoker)delegate
            {
                pictureBox1.Image = bitmap;
                ReadBarcode(bitmap);
            });
        }
		
		private void ReadBarcode(Bitmap bitmap)
		{
			BarcodeReader reader = new BarcodeReader();
			Result result = reader.Decode((Bitmap)pictureBox1.Image);
			decoded = "";
			if (result != null)
			{
				textBox1.ResetText();
				decoded = decoded + result.ToString();
				if (decoded != "")
				{
					textBox1.Text = decoded;
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string File_Open = File.ReadAllText(Application.StartupPath + "\\Password.txt");
			string[] Password = File_Open.Split('%');
			try
			{
				for (int i = 0; i < Password.Length; i++)
				{
					if (decoded == Password[i])
					{
						FrmPrincipal Form = new FrmPrincipal(decoded);
						this.Hide();
						GuiMail("khanhvuongtuan37@gmail.com", "17110313@student.hcmute.edu.vn", "Administrator", decoded.ToString() + " Vừa đăng nhập");
						Form.ShowDialog();
						this.Close();
						return;
					}
				}
				this.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Thông tin không đúng, mời nhập lại !");
			}
		}


		void GuiMail(string from, string to, string subject, string message, Attachment file = null)
		{
			MailMessage mess = new MailMessage(from, to, subject, message);
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential("khanhvuongtuan37@gmail.com", "kh16111999");
			client.Send(mess);
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text != "")
			{
				button4.Enabled = true;
			}
		}
	}
}
