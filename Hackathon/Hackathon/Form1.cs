using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hackathon
{
	public partial class Firewall : Form
	{
		public Firewall()
		{
			InitializeComponent();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thoát ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
			if (result == System.Windows.Forms.DialogResult.Yes) this.Close();
		}

		private void btn_Application_Click(object sender, EventArgs e)
		{
			Form_of_Login Form = new Form_of_Login();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}

		private void btn_Introduce_Click(object sender, EventArgs e)
		{

		}
	}
}
