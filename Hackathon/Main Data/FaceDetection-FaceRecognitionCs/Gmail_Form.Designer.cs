namespace MultiFaceRec
{
	partial class Gmail_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Send = new System.Windows.Forms.Button();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Attach = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Send
			// 
			this.btn_Send.Location = new System.Drawing.Point(120, 245);
			this.btn_Send.Name = "btn_Send";
			this.btn_Send.Size = new System.Drawing.Size(99, 28);
			this.btn_Send.TabIndex = 17;
			this.btn_Send.Text = "Send";
			this.btn_Send.UseVisualStyleBackColor = true;
			this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(120, 196);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMatKhau.Size = new System.Drawing.Size(446, 20);
			this.txtMatKhau.TabIndex = 12;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Location = new System.Drawing.Point(120, 146);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTenDangNhap.Size = new System.Drawing.Size(446, 20);
			this.txtTenDangNhap.TabIndex = 13;
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(120, 95);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSubject.Size = new System.Drawing.Size(446, 20);
			this.txtSubject.TabIndex = 14;
			// 
			// txtTo
			// 
			this.txtTo.Location = new System.Drawing.Point(120, 46);
			this.txtTo.Name = "txtTo";
			this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTo.Size = new System.Drawing.Size(446, 20);
			this.txtTo.TabIndex = 15;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(17, 279);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMessage.Size = new System.Drawing.Size(549, 200);
			this.txtMessage.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Message:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mật khẩu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Tên đăng nhập:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Subject:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "To:";
			// 
			// btn_Attach
			// 
			this.btn_Attach.Location = new System.Drawing.Point(454, 8);
			this.btn_Attach.Name = "btn_Attach";
			this.btn_Attach.Size = new System.Drawing.Size(112, 24);
			this.btn_Attach.TabIndex = 6;
			this.btn_Attach.Text = "Attach";
			this.btn_Attach.UseVisualStyleBackColor = true;
			this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(19, 11);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(402, 20);
			this.txtFile.TabIndex = 5;
			// 
			// Gmail_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 511);
			this.Controls.Add(this.btn_Send);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.txtTo);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Attach);
			this.Controls.Add(this.txtFile);
			this.Name = "Gmail_Form";
			this.Text = "Gmail_Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Send;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Attach;
		private System.Windows.Forms.TextBox txtFile;
	}
}