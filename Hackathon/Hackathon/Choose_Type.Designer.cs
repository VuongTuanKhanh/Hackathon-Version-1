namespace Hackathon
{
	partial class Choose_Type
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
			this.btn_QR = new System.Windows.Forms.Button();
			this.btn_Barcode = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_QR
			// 
			this.btn_QR.Location = new System.Drawing.Point(111, 25);
			this.btn_QR.Name = "btn_QR";
			this.btn_QR.Size = new System.Drawing.Size(369, 44);
			this.btn_QR.TabIndex = 0;
			this.btn_QR.Text = "Register with QR Code";
			this.btn_QR.UseVisualStyleBackColor = true;
			this.btn_QR.Click += new System.EventHandler(this.btn_QR_Click);
			// 
			// btn_Barcode
			// 
			this.btn_Barcode.Location = new System.Drawing.Point(111, 85);
			this.btn_Barcode.Name = "btn_Barcode";
			this.btn_Barcode.Size = new System.Drawing.Size(369, 44);
			this.btn_Barcode.TabIndex = 1;
			this.btn_Barcode.Text = "Register with Barode";
			this.btn_Barcode.UseVisualStyleBackColor = true;
			this.btn_Barcode.Click += new System.EventHandler(this.btn_Barcode_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(111, 145);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(369, 44);
			this.btn_Exit.TabIndex = 2;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// Choose_Type
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 211);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Barcode);
			this.Controls.Add(this.btn_QR);
			this.Name = "Choose_Type";
			this.Text = "Choose_Type";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_QR;
		private System.Windows.Forms.Button btn_Barcode;
		private System.Windows.Forms.Button btn_Exit;
	}
}