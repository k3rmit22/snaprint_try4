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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(file_explorer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Iconlist = new System.Windows.Forms.ImageList(this.components);
            this.Gobutton = new System.Windows.Forms.Button();
            this.filenamelabel = new System.Windows.Forms.Label();
            this.filetypelabel = new System.Windows.Forms.Label();
            this.buttonhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Filepathtextbox = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.Color.AliceBlue;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.Iconlist;
            this.listView1.Location = new System.Drawing.Point(44, 187);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1022, 520);
            this.listView1.SmallImageList = this.Iconlist;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Iconlist
            // 
            this.Iconlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iconlist.ImageStream")));
            this.Iconlist.TransparentColor = System.Drawing.Color.Transparent;
            this.Iconlist.Images.SetKeyName(0, "png_icon.png");
            this.Iconlist.Images.SetKeyName(1, "folder-icon-removebg-preview.png");
            this.Iconlist.Images.SetKeyName(2, "unkownfile.png");
            // 
            // Gobutton
            // 
            this.Gobutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gobutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gobutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobutton.Location = new System.Drawing.Point(975, 139);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(91, 42);
            this.Gobutton.TabIndex = 2;
            this.Gobutton.Text = "Go";
            this.Gobutton.UseVisualStyleBackColor = false;
            this.Gobutton.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // filenamelabel
            // 
            this.filenamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenamelabel.AutoSize = true;
            this.filenamelabel.BackColor = System.Drawing.Color.Lavender;
            this.filenamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenamelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filenamelabel.Location = new System.Drawing.Point(571, 154);
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.Size = new System.Drawing.Size(15, 13);
            this.filenamelabel.TabIndex = 4;
            this.filenamelabel.Text = "--";
            // 
            // filetypelabel
            // 
            this.filetypelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filetypelabel.AutoSize = true;
            this.filetypelabel.BackColor = System.Drawing.Color.Lavender;
            this.filetypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetypelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filetypelabel.Location = new System.Drawing.Point(299, 154);
            this.filetypelabel.Name = "filetypelabel";
            this.filetypelabel.Size = new System.Drawing.Size(15, 13);
            this.filetypelabel.TabIndex = 6;
            this.filetypelabel.Text = "--";
            // 
            // buttonhome
            // 
            this.buttonhome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonhome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonhome.FlatAppearance.BorderSize = 0;
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhome.Location = new System.Drawing.Point(44, 143);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(91, 42);
            this.buttonhome.TabIndex = 9;
            this.buttonhome.Text = "Home";
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Filepathtextbox
            // 
            this.Filepathtextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Filepathtextbox.AutoSize = true;
            this.Filepathtextbox.BackColor = System.Drawing.Color.Lavender;
            this.Filepathtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filepathtextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Filepathtextbox.Location = new System.Drawing.Point(151, 154);
            this.Filepathtextbox.Name = "Filepathtextbox";
            this.Filepathtextbox.Size = new System.Drawing.Size(15, 13);
            this.Filepathtextbox.TabIndex = 12;
            this.Filepathtextbox.Text = "--";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox2.Location = new System.Drawing.Point(141, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(828, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // file_explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1110, 733);
            this.Controls.Add(this.Filepathtextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonhome);
            this.Controls.Add(this.filetypelabel);
            this.Controls.Add(this.filenamelabel);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "file_explorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "file_explorer";
            this.Load += new System.EventHandler(this.file_explorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.Label filenamelabel;
        private System.Windows.Forms.Label filetypelabel;
        private System.Windows.Forms.ImageList Iconlist;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Filepathtextbox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}