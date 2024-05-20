namespace snaprint_try4
{
    partial class preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preferences));
            this.colorofpaper = new System.Windows.Forms.GroupBox();
            this.combocolor = new System.Windows.Forms.ComboBox();
            this.labelcolor = new System.Windows.Forms.Label();
            this.groupcopies = new System.Windows.Forms.GroupBox();
            this.combocopies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.Label();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPaperSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.modal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorofpaper.SuspendLayout();
            this.groupcopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modal)).BeginInit();
            this.SuspendLayout();
            // 
            // colorofpaper
            // 
            this.colorofpaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorofpaper.BackColor = System.Drawing.Color.Transparent;
            this.colorofpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorofpaper.Controls.Add(this.combocolor);
            this.colorofpaper.Controls.Add(this.labelcolor);
            this.colorofpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorofpaper.Location = new System.Drawing.Point(883, 475);
            this.colorofpaper.Name = "colorofpaper";
            this.colorofpaper.Size = new System.Drawing.Size(365, 92);
            this.colorofpaper.TabIndex = 5;
            this.colorofpaper.TabStop = false;
            // 
            // combocolor
            // 
            this.combocolor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocolor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.combocolor.FormattingEnabled = true;
            this.combocolor.Location = new System.Drawing.Point(101, 37);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(258, 31);
            this.combocolor.TabIndex = 1;
            // 
            // labelcolor
            // 
            this.labelcolor.AutoSize = true;
            this.labelcolor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelcolor.Location = new System.Drawing.Point(20, 41);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(69, 23);
            this.labelcolor.TabIndex = 0;
            this.labelcolor.Text = "Color:";
            // 
            // groupcopies
            // 
            this.groupcopies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupcopies.BackColor = System.Drawing.Color.Transparent;
            this.groupcopies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupcopies.Controls.Add(this.combocopies);
            this.groupcopies.Controls.Add(this.label3);
            this.groupcopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcopies.Location = new System.Drawing.Point(887, 338);
            this.groupcopies.Name = "groupcopies";
            this.groupcopies.Size = new System.Drawing.Size(334, 122);
            this.groupcopies.TabIndex = 5;
            this.groupcopies.TabStop = false;
            // 
            // combocopies
            // 
            this.combocopies.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocopies.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.combocopies.FormattingEnabled = true;
            this.combocopies.Location = new System.Drawing.Point(97, 52);
            this.combocopies.Name = "combocopies";
            this.combocopies.Size = new System.Drawing.Size(121, 31);
            this.combocopies.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copies:";
            // 
            // filename
            // 
            this.filename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filename.AutoSize = true;
            this.filename.BackColor = System.Drawing.Color.Transparent;
            this.filename.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filename.Location = new System.Drawing.Point(892, 160);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(26, 23);
            this.filename.TabIndex = 3;
            this.filename.Text = "--";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(827, 712);
            this.pdfViewer1.TabIndex = 10;
            this.pdfViewer1.Load += new System.EventHandler(this.pdfViewer1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 26);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.comboBoxPaperSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(887, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxPaperSize
            // 
            this.comboBoxPaperSize.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaperSize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxPaperSize.FormattingEnabled = true;
            this.comboBoxPaperSize.Location = new System.Drawing.Point(91, 56);
            this.comboBoxPaperSize.Name = "comboBoxPaperSize";
            this.comboBoxPaperSize.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPaperSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(883, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.next_btn.FlatAppearance.BorderSize = 3;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.next_btn.Location = new System.Drawing.Point(1159, 609);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(89, 43);
            this.next_btn.TabIndex = 23;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // modal
            // 
            this.modal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modal.BackColor = System.Drawing.Color.Transparent;
            this.modal.Image = ((System.Drawing.Image)(resources.GetObject("modal.Image")));
            this.modal.Location = new System.Drawing.Point(1185, 12);
            this.modal.Name = "modal";
            this.modal.Size = new System.Drawing.Size(51, 50);
            this.modal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modal.TabIndex = 24;
            this.modal.TabStop = false;
            this.modal.Click += new System.EventHandler(this.modal_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(883, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Click this Icon for information";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(852, 671);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "DON\'T INSERT YOUR COIN YET";
            // 
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modal);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.groupcopies);
            this.Controls.Add(this.colorofpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preferences";
            this.Load += new System.EventHandler(this.preferences_Load);
            this.colorofpaper.ResumeLayout(false);
            this.colorofpaper.PerformLayout();
            this.groupcopies.ResumeLayout(false);
            this.groupcopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox colorofpaper;
        private System.Windows.Forms.GroupBox groupcopies;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocolor;
        private System.Windows.Forms.ComboBox combocopies;
        private System.Windows.Forms.Label filename;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPaperSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.PictureBox modal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}