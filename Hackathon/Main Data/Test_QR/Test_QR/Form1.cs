using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.IO;
using System.Drawing.Imaging;

namespace Test_QR
{
	public partial class Form1 : Form
	{
		private readonly IBarcodeReader barcodeReader;
		public Form1()
		{
			InitializeComponent();
			barcodeReader = new BarcodeReader();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbxData.Text))
			{
				MessageBox.Show("Vui lòng nhập nội dung cần mã hóa",
					"QR Code Generator");
				return;
			}

			var barcodeWriter = new BarcodeWriter
			{
				Format = BarcodeFormat.QR_CODE,
				Options = new EncodingOptions
				{
					Height = 150,
					Width = 150,
					Margin = 0
				}
			};

			string content = tbxData.Text;

			using (var bitmap = barcodeWriter.Write(content))
			{
				using (var stream = new MemoryStream())
				{
					bitmap.Save(stream, ImageFormat.Png);
					var image = Image.FromStream(stream);
					pictureBox1.Image = image;
				}
			}
			btn_Save.Enabled = true;
			btn_Clear.Enabled = true;
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string temp = tbxData.Text;
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
			using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\Password.txt"))
			{
				sw.Write(temp + "%");
			}
			MessageBox.Show("Đã thêm thông tin thành công !");
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			tbxData.Text = "";
			pictureBox1.Image = null;
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
