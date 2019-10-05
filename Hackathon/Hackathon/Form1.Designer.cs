namespace Hackathon
{
	partial class Firewall
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
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Application = new System.Windows.Forms.Button();
			this.btn_Introduce = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(101, 205);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(375, 38);
			this.btn_Exit.TabIndex = 1;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Application
			// 
			this.btn_Application.Location = new System.Drawing.Point(101, 34);
			this.btn_Application.Name = "btn_Application";
			this.btn_Application.Size = new System.Drawing.Size(375, 41);
			this.btn_Application.TabIndex = 2;
			this.btn_Application.Text = "Application";
			this.btn_Application.UseVisualStyleBackColor = true;
			this.btn_Application.Click += new System.EventHandler(this.btn_Application_Click);
			// 
			// btn_Introduce
			// 
			this.btn_Introduce.Location = new System.Drawing.Point(104, 118);
			this.btn_Introduce.Name = "btn_Introduce";
			this.btn_Introduce.Size = new System.Drawing.Size(372, 40);
			this.btn_Introduce.TabIndex = 3;
			this.btn_Introduce.Text = "Introduce";
			this.btn_Introduce.UseVisualStyleBackColor = true;
			this.btn_Introduce.Click += new System.EventHandler(this.btn_Introduce_Click);
			// 
			// Firewall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 336);
			this.Controls.Add(this.btn_Introduce);
			this.Controls.Add(this.btn_Application);
			this.Controls.Add(this.btn_Exit);
			this.Name = "Firewall";
			this.Text = "Firewall";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Application;
		private System.Windows.Forms.Button btn_Introduce;
	}
}

