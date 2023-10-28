namespace assignment05
{
    partial class courseAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseAssign));
            assign = new TextBox();
            courseName = new TextBox();
            logo = new PictureBox();
            courseCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // assign
            // 
            assign.BackColor = Color.FromArgb(64, 64, 64);
            assign.BorderStyle = BorderStyle.None;
            assign.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            assign.ForeColor = Color.White;
            assign.Location = new Point(21, 336);
            assign.Margin = new Padding(2, 2, 2, 2);
            assign.Name = "assign";
            assign.Size = new Size(385, 31);
            assign.TabIndex = 11;
            assign.Text = "Assignment 5 - Calculator";
            assign.TextAlign = HorizontalAlignment.Center;
            // 
            // courseName
            // 
            courseName.BackColor = Color.FromArgb(64, 64, 64);
            courseName.BorderStyle = BorderStyle.None;
            courseName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            courseName.ForeColor = Color.White;
            courseName.Location = new Point(127, 266);
            courseName.Margin = new Padding(2, 2, 2, 2);
            courseName.Name = "courseName";
            courseName.Size = new Size(173, 31);
            courseName.TabIndex = 10;
            courseName.Text = "Programming II";
            courseName.TextAlign = HorizontalAlignment.Center;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(65, 84);
            logo.Margin = new Padding(2, 2, 2, 2);
            logo.Name = "logo";
            logo.Size = new Size(298, 93);
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // courseCode
            // 
            courseCode.BackColor = Color.FromArgb(64, 64, 64);
            courseCode.BorderStyle = BorderStyle.None;
            courseCode.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            courseCode.ForeColor = Color.White;
            courseCode.Location = new Point(127, 197);
            courseCode.Margin = new Padding(2, 2, 2, 2);
            courseCode.Name = "courseCode";
            courseCode.Size = new Size(173, 31);
            courseCode.TabIndex = 9;
            courseCode.Text = "COMP 123";
            courseCode.TextAlign = HorizontalAlignment.Center;
            // 
            // courseAssign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(assign);
            Controls.Add(courseName);
            Controls.Add(logo);
            Controls.Add(courseCode);
            Margin = new Padding(2, 2, 2, 2);
            Name = "courseAssign";
            Size = new Size(422, 494);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox assign;
        private TextBox courseName;
        private PictureBox logo;
        private TextBox courseCode;
    }
}
