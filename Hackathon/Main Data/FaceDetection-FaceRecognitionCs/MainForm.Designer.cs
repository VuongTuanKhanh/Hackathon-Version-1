namespace MultiFaceRec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.imageBox1 = new Emgu.CV.UI.ImageBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
			this.wb_Video = new System.Windows.Forms.WebBrowser();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_Load = new System.Windows.Forms.Button();
			this.btn_Gmail = new System.Windows.Forms.Button();
			this.btn_Listen = new System.Windows.Forms.Button();
			this.btn_Translate = new System.Windows.Forms.Button();
			this.btn_Swap = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_output = new System.Windows.Forms.TextBox();
			this.txt_input = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(103, 205);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 31);
			this.button2.TabIndex = 3;
			this.button2.Text = "Add face";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 170);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(107, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "MSSV";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.imageBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Location = new System.Drawing.Point(12, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 242);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Training: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name: ";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(14, 205);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 31);
			this.button1.TabIndex = 2;
			this.button1.Text = "Start Camera";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// imageBox1
			// 
			this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageBox1.Location = new System.Drawing.Point(11, 18);
			this.imageBox1.Name = "imageBox1";
			this.imageBox1.Size = new System.Drawing.Size(163, 134);
			this.imageBox1.TabIndex = 5;
			this.imageBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(240, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 15);
			this.label5.TabIndex = 17;
			this.label5.Text = "Persons:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(322, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 19);
			this.label4.TabIndex = 16;
			this.label4.Text = "Nobody";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(444, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(240, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "Number of faces detected: ";
			// 
			// imageBoxFrameGrabber
			// 
			this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 12);
			this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
			this.imageBoxFrameGrabber.Size = new System.Drawing.Size(197, 152);
			this.imageBoxFrameGrabber.TabIndex = 4;
			this.imageBoxFrameGrabber.TabStop = false;
			// 
			// wb_Video
			// 
			this.wb_Video.Location = new System.Drawing.Point(243, 79);
			this.wb_Video.MinimumSize = new System.Drawing.Size(20, 20);
			this.wb_Video.Name = "wb_Video";
			this.wb_Video.Size = new System.Drawing.Size(1065, 618);
			this.wb_Video.TabIndex = 18;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(505, 12);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(688, 20);
			this.txtUrl.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(476, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Url:";
			// 
			// btn_Load
			// 
			this.btn_Load.Location = new System.Drawing.Point(1212, 6);
			this.btn_Load.Name = "btn_Load";
			this.btn_Load.Size = new System.Drawing.Size(74, 30);
			this.btn_Load.TabIndex = 21;
			this.btn_Load.Text = "Load";
			this.btn_Load.UseVisualStyleBackColor = true;
			this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
			// 
			// btn_Gmail
			// 
			this.btn_Gmail.Location = new System.Drawing.Point(1212, 42);
			this.btn_Gmail.Name = "btn_Gmail";
			this.btn_Gmail.Size = new System.Drawing.Size(74, 30);
			this.btn_Gmail.TabIndex = 22;
			this.btn_Gmail.Text = "Gmail";
			this.btn_Gmail.UseVisualStyleBackColor = true;
			this.btn_Gmail.Click += new System.EventHandler(this.btn_Gmail_Click);
			// 
			// btn_Listen
			// 
			this.btn_Listen.Location = new System.Drawing.Point(141, 500);
			this.btn_Listen.Name = "btn_Listen";
			this.btn_Listen.Size = new System.Drawing.Size(60, 32);
			this.btn_Listen.TabIndex = 27;
			this.btn_Listen.Text = "Listen";
			this.btn_Listen.UseVisualStyleBackColor = true;
			this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
			// 
			// btn_Translate
			// 
			this.btn_Translate.Location = new System.Drawing.Point(70, 500);
			this.btn_Translate.Name = "btn_Translate";
			this.btn_Translate.Size = new System.Drawing.Size(65, 32);
			this.btn_Translate.TabIndex = 28;
			this.btn_Translate.Text = "Translate";
			this.btn_Translate.UseVisualStyleBackColor = true;
			this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
			// 
			// btn_Swap
			// 
			this.btn_Swap.Location = new System.Drawing.Point(7, 500);
			this.btn_Swap.Name = "btn_Swap";
			this.btn_Swap.Size = new System.Drawing.Size(57, 32);
			this.btn_Swap.TabIndex = 29;
			this.btn_Swap.Text = "Swap";
			this.btn_Swap.UseVisualStyleBackColor = true;
			this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 458);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "English";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 420);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "Việt Nam";
			// 
			// txt_output
			// 
			this.txt_output.Enabled = false;
			this.txt_output.Location = new System.Drawing.Point(12, 474);
			this.txt_output.Name = "txt_output";
			this.txt_output.ReadOnly = true;
			this.txt_output.Size = new System.Drawing.Size(189, 20);
			this.txt_output.TabIndex = 23;
			// 
			// txt_input
			// 
			this.txt_input.Location = new System.Drawing.Point(12, 436);
			this.txt_input.Name = "txt_input";
			this.txt_input.Size = new System.Drawing.Size(189, 20);
			this.txt_input.TabIndex = 24;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1334, 750);
			this.Controls.Add(this.btn_Listen);
			this.Controls.Add(this.btn_Translate);
			this.Controls.Add(this.btn_Swap);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_output);
			this.Controls.Add(this.txt_input);
			this.Controls.Add(this.btn_Gmail);
			this.Controls.Add(this.btn_Load);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.wb_Video);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.imageBoxFrameGrabber);
			this.Name = "FrmPrincipal";
			this.Text = "Phần mềm điểm danh";
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.WebBrowser wb_Video;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_Load;
		private System.Windows.Forms.Button btn_Gmail;
		private System.Windows.Forms.Button btn_Listen;
		private System.Windows.Forms.Button btn_Translate;
		private System.Windows.Forms.Button btn_Swap;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_output;
		private System.Windows.Forms.TextBox txt_input;
	}
}

