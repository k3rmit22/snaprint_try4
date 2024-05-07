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
            this.close_icon = new System.Windows.Forms.PictureBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.manualpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).BeginInit();
            this.SuspendLayout();
            // 
            // close_icon
            // 
            this.close_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_icon.Image = ((System.Drawing.Image)(resources.GetObject("close_icon.Image")));
            this.close_icon.Location = new System.Drawing.Point(1285, 15);
            this.close_icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(91, 73);
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
            // manualpic
            // 
            this.manualpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualpic.Image = ((System.Drawing.Image)(resources.GetObject("manualpic.Image")));
            this.manualpic.Location = new System.Drawing.Point(49, 112);
            this.manualpic.Margin = new System.Windows.Forms.Padding(4);
            this.manualpic.Name = "manualpic";
            this.manualpic.Size = new System.Drawing.Size(1288, 618);
            this.manualpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manualpic.TabIndex = 0;
            this.manualpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER MANUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 882);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.manualpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "modal";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "modal";
            this.Load += new System.EventHandler(this.modal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox close_icon;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.PictureBox manualpic;
        private System.Windows.Forms.Label label1;
    }
}