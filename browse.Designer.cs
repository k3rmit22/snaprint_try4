namespace snaprint_try4
{
    partial class browse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browse));
            this.label_browse = new System.Windows.Forms.Label();
            this.labeleject = new System.Windows.Forms.Label();
            this.ejectbutton = new System.Windows.Forms.Button();
            this.browse_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_browse
            // 
            this.label_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_browse.AutoSize = true;
            this.label_browse.BackColor = System.Drawing.Color.Transparent;
            this.label_browse.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_browse.Location = new System.Drawing.Point(633, 477);
            this.label_browse.Name = "label_browse";
            this.label_browse.Size = new System.Drawing.Size(317, 32);
            this.label_browse.TabIndex = 2;
            this.label_browse.Text = "Browse Your PDF File";
            this.label_browse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labeleject
            // 
            this.labeleject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeleject.AutoSize = true;
            this.labeleject.BackColor = System.Drawing.Color.Transparent;
            this.labeleject.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeleject.Location = new System.Drawing.Point(106, 477);
            this.labeleject.Name = "labeleject";
            this.labeleject.Size = new System.Drawing.Size(242, 32);
            this.labeleject.TabIndex = 5;
            this.labeleject.Text = "Eject flash drive";
            this.labeleject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ejectbutton
            // 
            this.ejectbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejectbutton.BackColor = System.Drawing.Color.Transparent;
            this.ejectbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ejectbutton.BackgroundImage")));
            this.ejectbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ejectbutton.FlatAppearance.BorderSize = 0;
            this.ejectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ejectbutton.Location = new System.Drawing.Point(50, 205);
            this.ejectbutton.Name = "ejectbutton";
            this.ejectbutton.Size = new System.Drawing.Size(380, 269);
            this.ejectbutton.TabIndex = 6;
            this.ejectbutton.UseVisualStyleBackColor = false;
            this.ejectbutton.Click += new System.EventHandler(this.ejectbutton_Click);
            // 
            // browse_button
            // 
            this.browse_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browse_button.BackColor = System.Drawing.Color.Transparent;
            this.browse_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browse_button.BackgroundImage")));
            this.browse_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.browse_button.FlatAppearance.BorderSize = 0;
            this.browse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_button.Location = new System.Drawing.Point(605, 205);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(380, 269);
            this.browse_button.TabIndex = 7;
            this.browse_button.UseVisualStyleBackColor = false;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(108)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.ejectbutton);
            this.Controls.Add(this.labeleject);
            this.Controls.Add(this.label_browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "browse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "browse";
            this.Load += new System.EventHandler(this.browse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_browse;
        private System.Windows.Forms.Label labeleject;
        private System.Windows.Forms.Button ejectbutton;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}