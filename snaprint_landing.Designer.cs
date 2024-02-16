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
            this.SNAPPRINT = new System.Windows.Forms.Label();
            this.PUBLIC = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SNAPPRINT
            // 
            this.SNAPPRINT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SNAPPRINT.AutoSize = true;
            this.SNAPPRINT.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNAPPRINT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SNAPPRINT.Location = new System.Drawing.Point(413, 86);
            this.SNAPPRINT.Name = "SNAPPRINT";
            this.SNAPPRINT.Size = new System.Drawing.Size(276, 47);
            this.SNAPPRINT.TabIndex = 0;
            this.SNAPPRINT.Text = "SNAPPRINT:";
            // 
            // PUBLIC
            // 
            this.PUBLIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PUBLIC.AutoSize = true;
            this.PUBLIC.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUBLIC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PUBLIC.Location = new System.Drawing.Point(345, 149);
            this.PUBLIC.Name = "PUBLIC";
            this.PUBLIC.Size = new System.Drawing.Size(412, 32);
            this.PUBLIC.TabIndex = 1;
            this.PUBLIC.Text = "PUBLIC PRINTING MACHINE";
            this.PUBLIC.Click += new System.EventHandler(this.PUBLIC_Click);
            // 
            // INSERT
            // 
            this.INSERT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INSERT.AutoSize = true;
            this.INSERT.BackColor = System.Drawing.Color.Transparent;
            this.INSERT.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.INSERT.Location = new System.Drawing.Point(295, 255);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(535, 32);
            this.INSERT.TabIndex = 3;
            this.INSERT.Text = "PLEASE INSERT YOUR FLASH DRIVE";
            this.INSERT.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(445, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // snaprint_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.PUBLIC);
            this.Controls.Add(this.SNAPPRINT);
            this.Name = "snaprint_landing";
            this.Load += new System.EventHandler(this.snaprint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SNAPPRINT;
        private System.Windows.Forms.Label PUBLIC;
        private System.Windows.Forms.Label INSERT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

