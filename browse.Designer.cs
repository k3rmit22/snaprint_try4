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
            this.label_snapprint = new System.Windows.Forms.Label();
            this.pdf_logo = new System.Windows.Forms.PictureBox();
            this.label_browse = new System.Windows.Forms.Label();
            this.broswe_button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_snapprint
            // 
            this.label_snapprint.AutoSize = true;
            this.label_snapprint.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_snapprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_snapprint.Location = new System.Drawing.Point(44, 54);
            this.label_snapprint.Name = "label_snapprint";
            this.label_snapprint.Size = new System.Drawing.Size(549, 35);
            this.label_snapprint.TabIndex = 0;
            this.label_snapprint.Text = "Snapprint: Public printing machine";
            // 
            // pdf_logo
            // 
            this.pdf_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pdf_logo.Image = ((System.Drawing.Image)(resources.GetObject("pdf_logo.Image")));
            this.pdf_logo.Location = new System.Drawing.Point(391, 198);
            this.pdf_logo.Name = "pdf_logo";
            this.pdf_logo.Size = new System.Drawing.Size(352, 257);
            this.pdf_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdf_logo.TabIndex = 1;
            this.pdf_logo.TabStop = false;
            // 
            // label_browse
            // 
            this.label_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_browse.AutoSize = true;
            this.label_browse.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_browse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_browse.Location = new System.Drawing.Point(413, 477);
            this.label_browse.Name = "label_browse";
            this.label_browse.Size = new System.Drawing.Size(317, 32);
            this.label_browse.TabIndex = 2;
            this.label_browse.Text = "Browse Your PDF File";
            this.label_browse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // broswe_button
            // 
            this.broswe_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.broswe_button.Location = new System.Drawing.Point(507, 542);
            this.broswe_button.Name = "broswe_button";
            this.broswe_button.Size = new System.Drawing.Size(128, 51);
            this.broswe_button.TabIndex = 3;
            this.broswe_button.Text = "BROWSE";
            this.broswe_button.UseSelectable = true;
            this.broswe_button.Click += new System.EventHandler(this.broswe_button_Click);
            // 
            // browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.broswe_button);
            this.Controls.Add(this.label_browse);
            this.Controls.Add(this.pdf_logo);
            this.Controls.Add(this.label_snapprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "browse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "browse";
            this.Load += new System.EventHandler(this.browse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_snapprint;
        private System.Windows.Forms.PictureBox pdf_logo;
        private System.Windows.Forms.Label label_browse;
        private MetroFramework.Controls.MetroButton broswe_button;
    }
}