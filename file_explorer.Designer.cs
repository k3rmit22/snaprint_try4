namespace snaprint_try4
{
    partial class file_explorer
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Iconlist = new System.Windows.Forms.ImageList(this.components);
            this.Backbutton = new System.Windows.Forms.Button();
            this.Gobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.finenamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filetypelabel = new System.Windows.Forms.Label();
            this.Filepathtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.Iconlist;
            this.listView1.Location = new System.Drawing.Point(27, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1022, 520);
            this.listView1.SmallImageList = this.Iconlist;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Iconlist
            // 
            this.Iconlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.Iconlist.ImageSize = new System.Drawing.Size(48, 48);
            this.Iconlist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Backbutton.Location = new System.Drawing.Point(27, 57);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click_1);
            // 
            // Gobutton
            // 
            this.Gobutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gobutton.Location = new System.Drawing.Point(974, 57);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(75, 23);
            this.Gobutton.TabIndex = 2;
            this.Gobutton.Text = "Go";
            this.Gobutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filename";
            // 
            // finenamelabel
            // 
            this.finenamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finenamelabel.AutoSize = true;
            this.finenamelabel.Location = new System.Drawing.Point(106, 622);
            this.finenamelabel.Name = "finenamelabel";
            this.finenamelabel.Size = new System.Drawing.Size(13, 13);
            this.finenamelabel.TabIndex = 4;
            this.finenamelabel.Text = "--";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(948, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Type";
            // 
            // filetypelabel
            // 
            this.filetypelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filetypelabel.AutoSize = true;
            this.filetypelabel.Location = new System.Drawing.Point(1004, 622);
            this.filetypelabel.Name = "filetypelabel";
            this.filetypelabel.Size = new System.Drawing.Size(13, 13);
            this.filetypelabel.TabIndex = 6;
            this.filetypelabel.Text = "--";
            // 
            // Filepathtextbox
            // 
            this.Filepathtextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Filepathtextbox.Location = new System.Drawing.Point(109, 59);
            this.Filepathtextbox.Name = "Filepathtextbox";
            this.Filepathtextbox.Size = new System.Drawing.Size(860, 20);
            this.Filepathtextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "SNAPPRINT";
            // 
            // file_explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filepathtextbox);
            this.Controls.Add(this.filetypelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finenamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "file_explorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "file_explorer";
            this.Load += new System.EventHandler(this.file_explorer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finenamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filetypelabel;
        private System.Windows.Forms.TextBox Filepathtextbox;
        private System.Windows.Forms.ImageList Iconlist;
        private System.Windows.Forms.Label label2;
    }
}