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
            this.selectpapersize = new System.Windows.Forms.GroupBox();
            this.labelpapersize = new System.Windows.Forms.Label();
            this.combosize = new System.Windows.Forms.ComboBox();
            this.colorofpaper = new System.Windows.Forms.GroupBox();
            this.combocolor = new System.Windows.Forms.ComboBox();
            this.labelcolor = new System.Windows.Forms.Label();
            this.groupcopies = new System.Windows.Forms.GroupBox();
            this.combocopies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.filename = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectpapersize.SuspendLayout();
            this.colorofpaper.SuspendLayout();
            this.groupcopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectpapersize
            // 
            this.selectpapersize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectpapersize.BackColor = System.Drawing.Color.Transparent;
            this.selectpapersize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectpapersize.Controls.Add(this.labelpapersize);
            this.selectpapersize.Controls.Add(this.combosize);
            this.selectpapersize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectpapersize.Location = new System.Drawing.Point(887, 242);
            this.selectpapersize.Name = "selectpapersize";
            this.selectpapersize.Size = new System.Drawing.Size(334, 122);
            this.selectpapersize.TabIndex = 4;
            this.selectpapersize.TabStop = false;
            // 
            // labelpapersize
            // 
            this.labelpapersize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpapersize.AutoSize = true;
            this.labelpapersize.Location = new System.Drawing.Point(42, 58);
            this.labelpapersize.Name = "labelpapersize";
            this.labelpapersize.Size = new System.Drawing.Size(114, 25);
            this.labelpapersize.TabIndex = 1;
            this.labelpapersize.Text = "Paper Size:";
            // 
            // combosize
            // 
            this.combosize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combosize.FormattingEnabled = true;
            this.combosize.Items.AddRange(new object[] {
            "Short",
            "Long"});
            this.combosize.Location = new System.Drawing.Point(162, 50);
            this.combosize.Name = "combosize";
            this.combosize.Size = new System.Drawing.Size(121, 33);
            this.combosize.TabIndex = 0;
            // 
            // colorofpaper
            // 
            this.colorofpaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorofpaper.BackColor = System.Drawing.Color.Transparent;
            this.colorofpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorofpaper.Controls.Add(this.combocolor);
            this.colorofpaper.Controls.Add(this.labelcolor);
            this.colorofpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorofpaper.Location = new System.Drawing.Point(887, 507);
            this.colorofpaper.Name = "colorofpaper";
            this.colorofpaper.Size = new System.Drawing.Size(365, 92);
            this.colorofpaper.TabIndex = 5;
            this.colorofpaper.TabStop = false;
            // 
            // combocolor
            // 
            this.combocolor.FormattingEnabled = true;
            this.combocolor.Location = new System.Drawing.Point(158, 41);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(207, 33);
            this.combocolor.TabIndex = 1;
            // 
            // labelcolor
            // 
            this.labelcolor.AutoSize = true;
            this.labelcolor.Location = new System.Drawing.Point(87, 41);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(65, 25);
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
            this.groupcopies.Location = new System.Drawing.Point(887, 370);
            this.groupcopies.Name = "groupcopies";
            this.groupcopies.Size = new System.Drawing.Size(334, 122);
            this.groupcopies.TabIndex = 5;
            this.groupcopies.TabStop = false;
            // 
            // combocopies
            // 
            this.combocopies.FormattingEnabled = true;
            this.combocopies.Location = new System.Drawing.Point(162, 53);
            this.combocopies.Name = "combocopies";
            this.combocopies.Size = new System.Drawing.Size(121, 33);
            this.combocopies.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copies:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1161, 621);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(887, 611);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // filename
            // 
            this.filename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filename.AutoSize = true;
            this.filename.BackColor = System.Drawing.Color.Transparent;
            this.filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.ForeColor = System.Drawing.Color.DarkRed;
            this.filename.Location = new System.Drawing.Point(896, 198);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(21, 20);
            this.filename.TabIndex = 3;
            this.filename.Text = "--";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(850, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
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
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupcopies);
            this.Controls.Add(this.colorofpaper);
            this.Controls.Add(this.selectpapersize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preferences";
            this.Load += new System.EventHandler(this.preferences_Load);
            this.selectpapersize.ResumeLayout(false);
            this.selectpapersize.PerformLayout();
            this.colorofpaper.ResumeLayout(false);
            this.colorofpaper.PerformLayout();
            this.groupcopies.ResumeLayout(false);
            this.groupcopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox selectpapersize;
        private System.Windows.Forms.GroupBox colorofpaper;
        private System.Windows.Forms.GroupBox groupcopies;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelpapersize;
        private System.Windows.Forms.ComboBox combosize;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocolor;
        private System.Windows.Forms.ComboBox combocopies;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label filename;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}