using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace BarcodeLibTest
{
    public partial class TestApp : Form
    {
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public TestApp()
        {
            InitializeComponent();
			btnSave.Enabled = false;
			btn_Save_Info.Enabled = false;
		}

        private void TestApp_Load(object sender, EventArgs e)
        {
            cbLabelLocation.SelectedIndex = 0;
            cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));
            cbRotateFlip.SelectedIndex = 1;
        }


        private void btnEncode_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
			int W = Convert.ToInt32(txtWidth.Text.Trim());
			int H = Convert.ToInt32(txtHeight.Text.Trim());
			BarcodeLib.AlignmentPositions alignment = BarcodeLib.AlignmentPositions.CENTER;
            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
			type = BarcodeLib.TYPE.CODE39;
			btnSave.Enabled = true;
			btn_Save_Info.Enabled = true;
			try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    RotateFlipType rotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), cbRotateFlip.SelectedItem.ToString(), true);
                    //label alignment and position
                    BarcodeLib.LabelPositions labelPosition = (BarcodeLib.LabelPositions)Enum.Parse(typeof(BarcodeLib.LabelPositions), cbLabelLocation.SelectedItem.ToString(), true);
                    barcode.Image = b.Encode(type, txtData.Text.Trim(), b.ForeColor, b.BackColor, W, H, alignment, rotateFlipType, chkGenerateLabel.Checked, labelPosition);
                    txtEncoded.Text = b.EncodedValue;
                }
                barcode.Width = barcode.Image.Width;
                barcode.Height = barcode.Image.Height;
                //reposition the barcode image to the middle
                barcode.Location = new Point((groupBox2.Location.X + groupBox2.Width / 2) - barcode.Width / 2, (groupBox2.Location.Y + groupBox2.Height / 2) - barcode.Height / 2);
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                ImageFormat savetype = ImageFormat.Jpeg;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = ImageFormat.Bmp; break;
                    case 2: /* GIF */  savetype = ImageFormat.Gif; break;
                    case 3: /* JPG */  savetype = ImageFormat.Jpeg; break;
                    case 4: /* PNG */  savetype = ImageFormat.Png; break;
                    case 5: /* TIFF */ savetype = ImageFormat.Tiff; break;
                    default: break;
                }
                barcode.Image.Save(sfd.FileName, savetype);
            }
        }

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Save_Info_Click(object sender, EventArgs e)
		{
			string temp = txtData.Text;
			if (temp == "") return;
			string File_Open = File.ReadAllText(Application.StartupPath + "\\Password.txt");
			string[] Password = File_Open.Split('%');
			for (int i = 0; i < Password.Length; i++)
			{
				if (temp == Password[i])
				{
					MessageBox.Show("Thông tin đã tồn tại !");
					return;
				}
			}
			File.AppendAllText(Application.StartupPath + "\\Password.txt", temp + "%");
			MessageBox.Show("Đã thêm thông tin thành công !");
		}
	}
}