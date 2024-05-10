namespace snaprint_try4
{
    partial class modal6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modal6));
            this.manualpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).BeginInit();
            this.SuspendLayout();
            // 
            // manualpic
            // 
            this.manualpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualpic.Image = ((System.Drawing.Image)(resources.GetObject("manualpic.Image")));
            this.manualpic.Location = new System.Drawing.Point(111, 91);
            this.manualpic.Name = "manualpic";
            this.manualpic.Size = new System.Drawing.Size(944, 540);
            this.manualpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manualpic.TabIndex = 21;
            this.manualpic.TabStop = false;
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
            this.label1.TabIndex = 25;
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
            this.close_button.TabIndex = 26;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_next.BackgroundImage")));
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Location = new System.Drawing.Point(1060, 342);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(92, 79);
            this.button_next.TabIndex = 27;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 79);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // modal6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modal6";
            this.Text = "modal6";
            this.Load += new System.EventHandler(this.modal6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manualpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox manualpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}