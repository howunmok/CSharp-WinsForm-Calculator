namespace assignment05
{
    partial class aboutMe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutMe));
            aM3 = new CheckBox();
            aM2 = new CheckBox();
            aM1 = new CheckBox();
            aMPhoto = new PictureBox();
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)aMPhoto).BeginInit();
            SuspendLayout();
            // 
            // aM3
            // 
            aM3.AutoSize = true;
            aM3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aM3.Location = new Point(137, 400);
            aM3.Margin = new Padding(2, 2, 2, 2);
            aM3.Name = "aM3";
            aM3.Size = new Size(87, 28);
            aM3.TabIndex = 7;
            aM3.Text = "Hiking";
            aM3.UseVisualStyleBackColor = true;
            // 
            // aM2
            // 
            aM2.AutoSize = true;
            aM2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aM2.Location = new Point(137, 354);
            aM2.Margin = new Padding(2, 2, 2, 2);
            aM2.Name = "aM2";
            aM2.Size = new Size(111, 28);
            aM2.TabIndex = 6;
            aM2.Text = "Camping";
            aM2.UseVisualStyleBackColor = true;
            // 
            // aM1
            // 
            aM1.AutoSize = true;
            aM1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aM1.Location = new Point(137, 308);
            aM1.Margin = new Padding(2, 2, 2, 2);
            aM1.Name = "aM1";
            aM1.Size = new Size(157, 28);
            aM1.TabIndex = 5;
            aM1.Text = "Taking Photos";
            aM1.UseVisualStyleBackColor = true;
            // 
            // aMPhoto
            // 
            aMPhoto.Image = (Image)resources.GetObject("aMPhoto.Image");
            aMPhoto.Location = new Point(133, 58);
            aMPhoto.Margin = new Padding(2, 2, 2, 2);
            aMPhoto.Name = "aMPhoto";
            aMPhoto.Size = new Size(156, 156);
            aMPhoto.TabIndex = 4;
            aMPhoto.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(136, 242);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(150, 28);
            name.TabIndex = 8;
            name.Text = "Ho Wun Mok";
            // 
            // aboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(name);
            Controls.Add(aM3);
            Controls.Add(aM2);
            Controls.Add(aM1);
            Controls.Add(aMPhoto);
            Margin = new Padding(2, 2, 2, 2);
            Name = "aboutMe";
            Size = new Size(422, 494);
            ((System.ComponentModel.ISupportInitialize)aMPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox aM3;
        private CheckBox aM2;
        private CheckBox aM1;
        private PictureBox aMPhoto;
        private Label name;
    }
}
