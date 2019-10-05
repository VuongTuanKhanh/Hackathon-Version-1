using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeReaderApp;
namespace Hackathon
{
	public partial class Form_of_Login : Form
	{
		public Form_of_Login()
		{
			InitializeComponent();
		}

		private void btn_Sign_Up_Click(object sender, EventArgs e)
		{
			Choose_Type Form = new Choose_Type();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Sign_In_Click(object sender, EventArgs e)
		{
			Form1 Form = new Form1();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}
	}
}
