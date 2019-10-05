using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using BarcodeLibTest;
using System.IO;
using Test_QR;
namespace Hackathon
{
	public partial class Choose_Type : Form
	{
		string File_Open;
		private string[] Password = new string[0];
		public Choose_Type()
		{
			InitializeComponent();
			File_Open = File.ReadAllText(Application.StartupPath + "\\Password.txt");
			string[] Password = File_Open.Split('%');
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_QR_Click(object sender, EventArgs e)
		{
			Form1 Form = new Form1();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}

		private void btn_Barcode_Click(object sender, EventArgs e)
		{
			TestApp Form = new TestApp();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}
	}
}
