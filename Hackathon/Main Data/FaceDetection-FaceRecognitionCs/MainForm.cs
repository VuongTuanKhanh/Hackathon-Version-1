using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Speech.Synthesis;

namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Emgu.CV.Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();        int ContTrain, NumLabels, t;
        string name, names = null;


        public FrmPrincipal()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int i = 1; i < NumLabels+1; i++)
                {
                    LoadFaces = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[i]);
                }
            
            }
            catch(Exception e)
            {
                MessageBox.Show("Mời nhập dữ liệu gương mặt", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

		public FrmPrincipal(string temp)
		{
			InitializeComponent();
			this.Name = temp;
			//Load haarcascades for face detection
			face = new HaarCascade("haarcascade_frontalface_default.xml");
			try
			{
				//Load of previus trainned faces and labels for each image
				string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
				string[] Labels = Labelsinfo.Split('%');
				NumLabels = Convert.ToInt16(Labels[0]);
				ContTrain = NumLabels;
				string LoadFaces;

				for (int i = 1; i < NumLabels + 1; i++)
				{
					LoadFaces = "face" + i + ".bmp";
					trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
					labels.Add(Labels[i]);
				}

			}
			catch (Exception e)
			{
				//MessageBox.Show(e.ToString());
				MessageBox.Show("Mời nhập dữ liệu gương mặt", "Data Load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}


		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void btn_Gmail_Click(object sender, EventArgs e)
		{
			Gmail_Form Form = new Gmail_Form();
			Form.ShowDialog();
		}

		private void btn_Swap_Click(object sender, EventArgs e)
		{
			string temp = label8.Text;
			label8.Text = label7.Text;
			label7.Text = temp;
			temp = txt_input.Text;
			txt_input.Text = txt_output.Text;
			txt_output.Text = temp;
		}

		private void btn_Translate_Click(object sender, EventArgs e)
		{
			string strTranslatedText = null;
			try
			{
				TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
				client = new TranslatorService.LanguageServiceClient();
				if (label7.Text == "English")
				{
					strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "", "en");
				}
				else strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "", "vi");
				txt_output.Text = strTranslatedText;
				if (txt_output.Text == txt_input.Text)
				{
					MessageBox.Show("Lỗi ngôn ngữ !");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_Listen_Click(object sender, EventArgs e)
		{
			SpeechSynthesizer reader = new SpeechSynthesizer();
			if (label8.Text == "English")
				reader.Speak(txt_input.Text);
			else
				reader.Speak(txt_output.Text);
		}

		private void btn_Load_Click(object sender, EventArgs e)
		{
			GuiMail("khanhvuongtuan37@gmail.com", "17110313@student.hcmute.edu.vn", "Administrator", this.Name + " Vừa truy cập: " + txtUrl.Text);
			wb_Video.Navigate(txtUrl.Text);
		}

		void GuiMail(string from, string to, string subject, string message, Attachment file = null)
		{
			MailMessage mess = new MailMessage(from, to, subject, message);
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential("khanhvuongtuan37@gmail.com", "kh16111999");
			client.Send(mess);
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Emgu.CV.Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(textBox1.Text + "Thêm dữ liệu thành công !", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lưu thông tin thất bại", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


		void FrameGrabber(object sender, EventArgs e)
		{
			label3.Text = "0";
			//label4.Text = "";
			NamePersons.Add("");


			//Get the current frame form capture device
			currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

			//Convert it to Grayscale
			gray = currentFrame.Convert<Gray, Byte>();

			//Face Detector
			MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
		  face,
		  1.2,
		  10,
		  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
		  new Size(20, 20));

			//Action for each element detected
			foreach (MCvAvgComp f in facesDetected[0])
			{
				t = t + 1;
				result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				//draw the face detected in the 0th (gray) channel with blue color
				currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


				if (trainingImages.ToArray().Length != 0)
				{
					//TermCriteria for face recognition with numbers of trained images like maxIteration
					MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

					//Eigen face recognizer
					EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
					   trainingImages.ToArray(),
					   labels.ToArray(),
					   3000,
					   ref termCrit);

					name = recognizer.Recognize(result);

					//Draw the label for each face detected and recognized
					currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

				}

				NamePersons[t - 1] = name;
				NamePersons.Add("");
				//Set the number of faces detected on the scene
				label3.Text = facesDetected[0].Length.ToString();

			}
			t = 0;

			//Names concatenation of persons recognized
			for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
			{
				names = names + NamePersons[nnn] + ", ";
			}
			//Show the faces procesed and recognized
			imageBoxFrameGrabber.Image = currentFrame;
			label4.Text = names;
			names = "";
			//Clear the list(vector) of names
			NamePersons.Clear();

		}
    }
}