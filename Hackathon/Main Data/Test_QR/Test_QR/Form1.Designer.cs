namespace Test_QR
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbxData = new System.Windows.Forms.TextBox();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(179, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Decode";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox1.Location = new System.Drawing.Point(12, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(161, 145);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// tbxData
			// 
			this.tbxData.Location = new System.Drawing.Point(12, 9);
			this.tbxData.Name = "tbxData";
			this.tbxData.Size = new System.Drawing.Size(246, 20);
			this.tbxData.TabIndex = 2;
			// 
			// btn_Clear
			// 
			this.btn_Clear.Location = new System.Drawing.Point(179, 112);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(79, 35);
			this.btn_Clear.TabIndex = 11;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(179, 153);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(79, 34);
			this.btn_Exit.TabIndex = 10;
			this.btn_Exit.Text = "Close";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(179, 72);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(79, 34);
			this.btn_Save.TabIndex = 9;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(268, 207);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.tbxData);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbxData;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Save;
	}
}

