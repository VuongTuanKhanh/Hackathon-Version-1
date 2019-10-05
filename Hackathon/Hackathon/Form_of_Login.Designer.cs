namespace Hackathon
{
	partial class Form_of_Login
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
			this.btn_Sign_In = new System.Windows.Forms.Button();
			this.btn_Sign_Up = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Sign_In
			// 
			this.btn_Sign_In.Location = new System.Drawing.Point(114, 101);
			this.btn_Sign_In.Name = "btn_Sign_In";
			this.btn_Sign_In.Size = new System.Drawing.Size(298, 38);
			this.btn_Sign_In.TabIndex = 0;
			this.btn_Sign_In.Text = "Sign In";
			this.btn_Sign_In.UseVisualStyleBackColor = true;
			this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
			// 
			// btn_Sign_Up
			// 
			this.btn_Sign_Up.Location = new System.Drawing.Point(114, 37);
			this.btn_Sign_Up.Name = "btn_Sign_Up";
			this.btn_Sign_Up.Size = new System.Drawing.Size(298, 38);
			this.btn_Sign_Up.TabIndex = 1;
			this.btn_Sign_Up.Text = "Sign Up";
			this.btn_Sign_Up.UseVisualStyleBackColor = true;
			this.btn_Sign_Up.Click += new System.EventHandler(this.btn_Sign_Up_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(114, 164);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(298, 38);
			this.btn_Exit.TabIndex = 2;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// Form_of_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 241);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Sign_Up);
			this.Controls.Add(this.btn_Sign_In);
			this.Name = "Form_of_Login";
			this.Text = "Form_of_Login";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Sign_In;
		private System.Windows.Forms.Button btn_Sign_Up;
		private System.Windows.Forms.Button btn_Exit;
	}
}