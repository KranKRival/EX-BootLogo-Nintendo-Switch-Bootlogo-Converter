namespace EX_BootLogo
{
    partial class Load_Image_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Image_Form));
            this.LoadImageDilaog = new System.Windows.Forms.OpenFileDialog();
            this.SaveBootLogoDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadImageButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveBootLogoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfirmSizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HeightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WidthLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoadedImageBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.AutoSize = true;
            this.LoadImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadImageButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoadImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadImageButton.Depth = 0;
            this.LoadImageButton.Location = new System.Drawing.Point(47, 94);
            this.LoadImageButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.LoadImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Primary = false;
            this.LoadImageButton.Size = new System.Drawing.Size(114, 36);
            this.LoadImageButton.TabIndex = 3;
            this.LoadImageButton.Text = "LOAD IMAGE";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // SaveBootLogoButton
            // 
            this.SaveBootLogoButton.AutoSize = true;
            this.SaveBootLogoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBootLogoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveBootLogoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBootLogoButton.Depth = 0;
            this.SaveBootLogoButton.Location = new System.Drawing.Point(50, 295);
            this.SaveBootLogoButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.SaveBootLogoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBootLogoButton.Name = "SaveBootLogoButton";
            this.SaveBootLogoButton.Primary = false;
            this.SaveBootLogoButton.Size = new System.Drawing.Size(171, 36);
            this.SaveBootLogoButton.TabIndex = 3;
            this.SaveBootLogoButton.Text = "EXPORT BOOTLOGO";
            this.SaveBootLogoButton.UseVisualStyleBackColor = false;
            this.SaveBootLogoButton.Click += new System.EventHandler(this.SaveBootLogoButton_Click);
            // 
            // ConfirmSizeLabel
            // 
            this.ConfirmSizeLabel.AutoSize = true;
            this.ConfirmSizeLabel.Depth = 0;
            this.ConfirmSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ConfirmSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmSizeLabel.Location = new System.Drawing.Point(46, 162);
            this.ConfirmSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmSizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmSizeLabel.Name = "ConfirmSizeLabel";
            this.ConfirmSizeLabel.Size = new System.Drawing.Size(163, 24);
            this.ConfirmSizeLabel.TabIndex = 5;
            this.ConfirmSizeLabel.Text = "CONFIRM SIZE !?";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.HeightLabel.Depth = 0;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.HeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeightLabel.Location = new System.Drawing.Point(54, 205);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(75, 24);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height: ";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.WidthLabel.Depth = 0;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WidthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WidthLabel.Location = new System.Drawing.Point(61, 243);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(68, 24);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width: ";
            // 
            // LoadedImageBox
            // 
            this.LoadedImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoadedImageBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.LoadedImageBox.Image = global::EX_BootLogo.Properties.Resources._450px_No_image_available;
            this.LoadedImageBox.Location = new System.Drawing.Point(256, 86);
            this.LoadedImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoadedImageBox.Name = "LoadedImageBox";
            this.LoadedImageBox.Size = new System.Drawing.Size(420, 240);
            this.LoadedImageBox.TabIndex = 1;
            this.LoadedImageBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(256, 91);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(428, 246);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(46, 91);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 46);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(47, 293);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 46);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.SaveBootLogoButton_Click);
            // 
            // IconBox
            // 
            this.IconBox.Image = global::EX_BootLogo.Properties.Resources.EXBootIcon_;
            this.IconBox.Location = new System.Drawing.Point(3, 4);
            this.IconBox.Margin = new System.Windows.Forms.Padding(4);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(21, 20);
            this.IconBox.TabIndex = 4;
            this.IconBox.TabStop = false;
            // 
            // Load_Image_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(697, 353);
            this.Controls.Add(this.LoadedImageBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SaveBootLogoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.ConfirmSizeLabel);
            this.Controls.Add(this.IconBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Load_Image_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX BootLogo - Nintendo Switch Bootlogo Converter";
            this.Load += new System.EventHandler(this.Load_Image_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog LoadImageDilaog;
        private System.Windows.Forms.PictureBox LoadedImageBox;
        private System.Windows.Forms.SaveFileDialog SaveBootLogoDialog;
        private MaterialSkin.Controls.MaterialFlatButton LoadImageButton;
        private System.Windows.Forms.PictureBox IconBox;
        private MaterialSkin.Controls.MaterialLabel ConfirmSizeLabel;
        private MaterialSkin.Controls.MaterialLabel HeightLabel;
        private MaterialSkin.Controls.MaterialLabel WidthLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialFlatButton SaveBootLogoButton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

