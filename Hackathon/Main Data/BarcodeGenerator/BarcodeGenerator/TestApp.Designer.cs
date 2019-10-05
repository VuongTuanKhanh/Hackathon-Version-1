namespace BarcodeLibTest
{
    partial class TestApp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestApp));
			this.barcode = new System.Windows.Forms.PictureBox();
			this.txtEncoded = new System.Windows.Forms.TextBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Save_Info = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.cbRotateFlip = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblLabelLocation = new System.Windows.Forms.Label();
			this.btnEncode = new System.Windows.Forms.Button();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.cbLabelLocation = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblEncodingTime = new System.Windows.Forms.Label();
			this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// barcode
			// 
			this.barcode.BackColor = System.Drawing.Color.Transparent;
			this.barcode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barcode.Location = new System.Drawing.Point(3, 16);
			this.barcode.Name = "barcode";
			this.barcode.Size = new System.Drawing.Size(395, 342);
			this.barcode.TabIndex = 13;
			this.barcode.TabStop = false;
			// 
			// txtEncoded
			// 
			this.txtEncoded.Location = new System.Drawing.Point(6, 180);
			this.txtEncoded.Multiline = true;
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.ReadOnly = true;
			this.txtEncoded.Size = new System.Drawing.Size(108, 89);
			this.txtEncoded.TabIndex = 14;
			this.txtEncoded.TabStop = false;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(4, 36);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(194, 20);
			this.txtData.TabIndex = 1;
			this.txtData.Text = "123456789";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Value to Encode";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Encoded Value";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Exit);
			this.groupBox1.Controls.Add(this.btn_Save_Info);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cbRotateFlip);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.lblLabelLocation);
			this.groupBox1.Controls.Add(this.btnEncode);
			this.groupBox1.Controls.Add(this.txtHeight);
			this.groupBox1.Controls.Add(this.cbLabelLocation);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtEncoded);
			this.groupBox1.Controls.Add(this.txtWidth);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblEncodingTime);
			this.groupBox1.Controls.Add(this.chkGenerateLabel);
			this.groupBox1.Controls.Add(this.txtData);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 361);
			this.groupBox1.TabIndex = 35;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Information";
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(117, 283);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(98, 56);
			this.btn_Exit.TabIndex = 57;
			this.btn_Exit.Text = "Close";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Save_Info
			// 
			this.btn_Save_Info.Location = new System.Drawing.Point(13, 283);
			this.btn_Save_Info.Name = "btn_Save_Info";
			this.btn_Save_Info.Size = new System.Drawing.Size(98, 56);
			this.btn_Save_Info.TabIndex = 56;
			this.btn_Save_Info.Text = "Save Info";
			this.btn_Save_Info.UseVisualStyleBackColor = true;
			this.btn_Save_Info.Click += new System.EventHandler(this.btn_Save_Info_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(0, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 13);
			this.label10.TabIndex = 55;
			this.label10.Text = "Rotate";
			// 
			// cbRotateFlip
			// 
			this.cbRotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRotateFlip.FormattingEnabled = true;
			this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
			this.cbRotateFlip.Location = new System.Drawing.Point(2, 130);
			this.cbRotateFlip.Name = "cbRotateFlip";
			this.cbRotateFlip.Size = new System.Drawing.Size(109, 21);
			this.cbRotateFlip.TabIndex = 54;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(124, 226);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(92, 43);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "&Save Image";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblLabelLocation
			// 
			this.lblLabelLocation.AutoSize = true;
			this.lblLabelLocation.Location = new System.Drawing.Point(0, 59);
			this.lblLabelLocation.Name = "lblLabelLocation";
			this.lblLabelLocation.Size = new System.Drawing.Size(77, 13);
			this.lblLabelLocation.TabIndex = 48;
			this.lblLabelLocation.Text = "Label Location";
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(124, 180);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(92, 43);
			this.btnEncode.TabIndex = 3;
			this.btnEncode.Text = "&Encode";
			this.btnEncode.UseVisualStyleBackColor = true;
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(168, 130);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(35, 20);
			this.txtHeight.TabIndex = 44;
			this.txtHeight.Text = "150";
			// 
			// cbLabelLocation
			// 
			this.cbLabelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLabelLocation.FormattingEnabled = true;
			this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
			this.cbLabelLocation.Location = new System.Drawing.Point(3, 75);
			this.cbLabelLocation.Name = "cbLabelLocation";
			this.cbLabelLocation.Size = new System.Drawing.Size(195, 21);
			this.cbLabelLocation.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(166, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Height";
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(125, 130);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(35, 20);
			this.txtWidth.TabIndex = 43;
			this.txtWidth.Text = "300";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(122, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 41;
			this.label7.Text = "Width";
			// 
			// lblEncodingTime
			// 
			this.lblEncodingTime.AutoSize = true;
			this.lblEncodingTime.Location = new System.Drawing.Point(86, 164);
			this.lblEncodingTime.Name = "lblEncodingTime";
			this.lblEncodingTime.Size = new System.Drawing.Size(0, 13);
			this.lblEncodingTime.TabIndex = 45;
			// 
			// chkGenerateLabel
			// 
			this.chkGenerateLabel.AutoSize = true;
			this.chkGenerateLabel.Location = new System.Drawing.Point(108, 19);
			this.chkGenerateLabel.Name = "chkGenerateLabel";
			this.chkGenerateLabel.Size = new System.Drawing.Size(95, 17);
			this.chkGenerateLabel.TabIndex = 40;
			this.chkGenerateLabel.Text = "Generate label";
			this.chkGenerateLabel.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(157, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 13);
			this.label9.TabIndex = 51;
			this.label9.Text = "x";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.barcode);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(401, 361);
			this.groupBox2.TabIndex = 36;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Barcode Image";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(623, 361);
			this.splitContainer1.SplitterDistance = 218;
			this.splitContainer1.TabIndex = 37;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// TestApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 361);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(639, 399);
			this.Name = "TestApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Barcode Encoder";
			this.Load += new System.EventHandler(this.TestApp_Load);
			((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEncodingTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblLabelLocation;
        private System.Windows.Forms.ComboBox cbLabelLocation;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbRotateFlip;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Save_Info;
	}
}

