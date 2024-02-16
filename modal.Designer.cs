namespace snaprint_try4
{
    partial class modal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modal));
            this.manualpic = new System.Windows.Forms.PictureBox();
            this.close_icon = new System.Windows.Forms.PictureBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // manualpic
            // 
            this.manualpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualpic.Image = ((System.Drawing.Image)(resources.GetObject("manualpic.Image")));
            this.manualpic.Location = new System.Drawing.Point(-15, 45);
            this.manualpic.Name = "manualpic";
            this.manualpic.Size = new System.Drawing.Size(966, 502);
            this.manualpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manualpic.TabIndex = 0;
            this.manualpic.TabStop = false;
            // 
            // close_icon
            // 
            this.close_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_icon.Image = ((System.Drawing.Image)(resources.GetObject("close_icon.Image")));
            this.close_icon.Location = new System.Drawing.Point(867, 12);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(68, 59);
            this.close_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_icon.TabIndex = 1;
            this.close_icon.TabStop = false;
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 560);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.manualpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modal";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "modal";
            this.Load += new System.EventHandler(this.modal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox manualpic;
        private System.Windows.Forms.PictureBox close_icon;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}