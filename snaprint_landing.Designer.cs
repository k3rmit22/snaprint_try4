namespace snaprint_try4
{
    partial class snaprint_landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snaprint_landing));
            this.INSERT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.modal = new System.Windows.Forms.PictureBox();
            this.usb = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INSERT.AutoSize = true;
            this.INSERT.BackColor = System.Drawing.Color.Transparent;
            this.INSERT.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.INSERT.Location = new System.Drawing.Point(154, 445);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(799, 47);
            this.INSERT.TabIndex = 3;
            this.INSERT.Text = "PLEASE INSERT YOUR FLASH DRIVE";
            this.INSERT.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // modal
            // 
            this.modal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modal.BackColor = System.Drawing.Color.Transparent;
            this.modal.Image = ((System.Drawing.Image)(resources.GetObject("modal.Image")));
            this.modal.Location = new System.Drawing.Point(1037, 21);
            this.modal.Name = "modal";
            this.modal.Size = new System.Drawing.Size(51, 50);
            this.modal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modal.TabIndex = 7;
            this.modal.TabStop = false;
            this.modal.Click += new System.EventHandler(this.modal_Click);
            // 
            // usb
            // 
            this.usb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usb.BackColor = System.Drawing.Color.Transparent;
            this.usb.Image = ((System.Drawing.Image)(resources.GetObject("usb.Image")));
            this.usb.Location = new System.Drawing.Point(413, 495);
            this.usb.Name = "usb";
            this.usb.Size = new System.Drawing.Size(261, 170);
            this.usb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usb.TabIndex = 8;
            this.usb.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 401);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // snaprint_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usb);
            this.Controls.Add(this.modal);
            this.Controls.Add(this.INSERT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "snaprint_landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.snaprint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label INSERT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox modal;
        private System.Windows.Forms.PictureBox usb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

