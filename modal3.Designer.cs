namespace snaprint_try4
{
    partial class modal3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modal3));
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.manualpic = new System.Windows.Forms.PictureBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.next_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER MANUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(1076, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(76, 73);
            this.close_button.TabIndex = 17;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // manualpic
            // 
            this.manualpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualpic.Image = ((System.Drawing.Image)(resources.GetObject("manualpic.Image")));
            this.manualpic.Location = new System.Drawing.Point(111, 91);
            this.manualpic.Name = "manualpic";
            this.manualpic.Size = new System.Drawing.Size(944, 540);
            this.manualpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manualpic.TabIndex = 18;
            this.manualpic.TabStop = false;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.next_btn.FlatAppearance.BorderSize = 3;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(1076, 345);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(89, 43);
            this.next_btn.TabIndex = 19;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // modal3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 678);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.manualpic);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modal3";
            this.Text = "modal3";
            this.Load += new System.EventHandler(this.modal3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox manualpic;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Button next_btn;
    }
}