namespace assignment05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tagPage = new TabControl();
            calPage = new TabPage();
            calSteps = new TextBox();
            logBtn = new Button();
            cosBtn = new Button();
            sinBtn = new Button();
            piBtn = new Button();
            equalBtn = new Button();
            squRootBtn = new Button();
            overBtn = new Button();
            divideBtn = new Button();
            multiplyBtn = new Button();
            minusBtn = new Button();
            plusBtn = new Button();
            clearBtn = new Button();
            pNBtn = new Button();
            threeBtn = new Button();
            sixBtn = new Button();
            nineBtn = new Button();
            dotBtn = new Button();
            twoBtn = new Button();
            fiveBtn = new Button();
            eightBtn = new Button();
            zeroBtn = new Button();
            oneBtn = new Button();
            fourBtn = new Button();
            sevenBtn = new Button();
            darkModeBtn = new CheckBox();
            sciBtn = new RadioButton();
            stdBtn = new RadioButton();
            showResultBox = new TextBox();
            introPage = new TabPage();
            courseAssign1 = new courseAssign();
            aboutMe1 = new aboutMe();
            panel1 = new Panel();
            aMBtn = new Button();
            courseBtn = new Button();
            tagPage.SuspendLayout();
            calPage.SuspendLayout();
            introPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tagPage
            // 
            tagPage.Controls.Add(calPage);
            tagPage.Controls.Add(introPage);
            tagPage.Location = new Point(-2, 1);
            tagPage.Margin = new Padding(2);
            tagPage.Name = "tagPage";
            tagPage.SelectedIndex = 0;
            tagPage.Size = new Size(671, 524);
            tagPage.TabIndex = 0;
            // 
            // calPage
            // 
            calPage.BackColor = Color.WhiteSmoke;
            calPage.Controls.Add(calSteps);
            calPage.Controls.Add(logBtn);
            calPage.Controls.Add(cosBtn);
            calPage.Controls.Add(sinBtn);
            calPage.Controls.Add(piBtn);
            calPage.Controls.Add(equalBtn);
            calPage.Controls.Add(squRootBtn);
            calPage.Controls.Add(overBtn);
            calPage.Controls.Add(divideBtn);
            calPage.Controls.Add(multiplyBtn);
            calPage.Controls.Add(minusBtn);
            calPage.Controls.Add(plusBtn);
            calPage.Controls.Add(clearBtn);
            calPage.Controls.Add(pNBtn);
            calPage.Controls.Add(threeBtn);
            calPage.Controls.Add(sixBtn);
            calPage.Controls.Add(nineBtn);
            calPage.Controls.Add(dotBtn);
            calPage.Controls.Add(twoBtn);
            calPage.Controls.Add(fiveBtn);
            calPage.Controls.Add(eightBtn);
            calPage.Controls.Add(zeroBtn);
            calPage.Controls.Add(oneBtn);
            calPage.Controls.Add(fourBtn);
            calPage.Controls.Add(sevenBtn);
            calPage.Controls.Add(darkModeBtn);
            calPage.Controls.Add(sciBtn);
            calPage.Controls.Add(stdBtn);
            calPage.Controls.Add(showResultBox);
            calPage.Location = new Point(4, 24);
            calPage.Margin = new Padding(2);
            calPage.Name = "calPage";
            calPage.Padding = new Padding(2);
            calPage.Size = new Size(663, 496);
            calPage.TabIndex = 0;
            calPage.Text = "Calculator";
            // 
            // calSteps
            // 
            calSteps.BorderStyle = BorderStyle.None;
            calSteps.Font = new Font("Agency FB", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            calSteps.Location = new Point(19, 11);
            calSteps.Margin = new Padding(2);
            calSteps.Name = "calSteps";
            calSteps.Size = new Size(533, 32);
            calSteps.TabIndex = 52;
            // 
            // logBtn
            // 
            logBtn.BackColor = SystemColors.WindowFrame;
            logBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            logBtn.ForeColor = SystemColors.Control;
            logBtn.Location = new Point(570, 405);
            logBtn.Margin = new Padding(2);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(79, 82);
            logBtn.TabIndex = 51;
            logBtn.Text = "Log";
            logBtn.UseVisualStyleBackColor = false;
            logBtn.Click += logBtn_Click;
            // 
            // cosBtn
            // 
            cosBtn.BackColor = SystemColors.WindowFrame;
            cosBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            cosBtn.ForeColor = SystemColors.Control;
            cosBtn.Location = new Point(570, 318);
            cosBtn.Margin = new Padding(2);
            cosBtn.Name = "cosBtn";
            cosBtn.Size = new Size(79, 82);
            cosBtn.TabIndex = 50;
            cosBtn.Text = "Cos";
            cosBtn.UseVisualStyleBackColor = false;
            cosBtn.Click += cosBtn_Click;
            // 
            // sinBtn
            // 
            sinBtn.BackColor = SystemColors.WindowFrame;
            sinBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            sinBtn.ForeColor = SystemColors.Control;
            sinBtn.Location = new Point(570, 231);
            sinBtn.Margin = new Padding(2);
            sinBtn.Name = "sinBtn";
            sinBtn.Size = new Size(79, 82);
            sinBtn.TabIndex = 49;
            sinBtn.Text = "Sin";
            sinBtn.UseVisualStyleBackColor = false;
            sinBtn.Click += sinBtn_Click;
            // 
            // piBtn
            // 
            piBtn.BackColor = SystemColors.WindowFrame;
            piBtn.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point);
            piBtn.ForeColor = SystemColors.Control;
            piBtn.Location = new Point(570, 144);
            piBtn.Margin = new Padding(2);
            piBtn.Name = "piBtn";
            piBtn.Size = new Size(79, 82);
            piBtn.TabIndex = 48;
            piBtn.Text = "π";
            piBtn.UseVisualStyleBackColor = false;
            piBtn.Click += piBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.DodgerBlue;
            equalBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            equalBtn.ForeColor = SystemColors.Control;
            equalBtn.Location = new Point(473, 231);
            equalBtn.Margin = new Padding(2);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(79, 256);
            equalBtn.TabIndex = 47;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            // 
            // squRootBtn
            // 
            squRootBtn.BackColor = Color.DodgerBlue;
            squRootBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            squRootBtn.ForeColor = SystemColors.Control;
            squRootBtn.Location = new Point(390, 405);
            squRootBtn.Margin = new Padding(2);
            squRootBtn.Name = "squRootBtn";
            squRootBtn.Size = new Size(79, 82);
            squRootBtn.TabIndex = 46;
            squRootBtn.Text = "√";
            squRootBtn.UseVisualStyleBackColor = false;
            squRootBtn.Click += squRootBtn_Click;
            // 
            // overBtn
            // 
            overBtn.BackColor = Color.DodgerBlue;
            overBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            overBtn.ForeColor = SystemColors.Control;
            overBtn.Location = new Point(306, 405);
            overBtn.Margin = new Padding(2);
            overBtn.Name = "overBtn";
            overBtn.Size = new Size(79, 82);
            overBtn.TabIndex = 45;
            overBtn.Text = "1/X";
            overBtn.UseVisualStyleBackColor = false;
            overBtn.Click += overBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = Color.Orange;
            divideBtn.Font = new Font("Agency FB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            divideBtn.ForeColor = SystemColors.Control;
            divideBtn.Location = new Point(390, 318);
            divideBtn.Margin = new Padding(2);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(79, 82);
            divideBtn.TabIndex = 44;
            divideBtn.Text = "÷";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = Color.Orange;
            multiplyBtn.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyBtn.ForeColor = SystemColors.Control;
            multiplyBtn.Location = new Point(306, 318);
            multiplyBtn.Margin = new Padding(2);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(79, 82);
            multiplyBtn.TabIndex = 43;
            multiplyBtn.Text = "✖";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.BackColor = Color.Orange;
            minusBtn.Font = new Font("Agency FB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            minusBtn.ForeColor = SystemColors.Control;
            minusBtn.Location = new Point(390, 231);
            minusBtn.Margin = new Padding(2);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(79, 82);
            minusBtn.TabIndex = 42;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = false;
            minusBtn.Click += operatorClick;
            // 
            // plusBtn
            // 
            plusBtn.BackColor = Color.Orange;
            plusBtn.Font = new Font("Agency FB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            plusBtn.ForeColor = SystemColors.Control;
            plusBtn.Location = new Point(306, 231);
            plusBtn.Margin = new Padding(2);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(79, 82);
            plusBtn.TabIndex = 41;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.Click += operatorClick;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(306, 144);
            clearBtn.Margin = new Padding(2);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(245, 82);
            clearBtn.TabIndex = 40;
            clearBtn.Text = "&Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // pNBtn
            // 
            pNBtn.BackColor = SystemColors.ActiveCaptionText;
            pNBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            pNBtn.ForeColor = SystemColors.Control;
            pNBtn.Location = new Point(202, 405);
            pNBtn.Margin = new Padding(2);
            pNBtn.Name = "pNBtn";
            pNBtn.Size = new Size(87, 82);
            pNBtn.TabIndex = 39;
            pNBtn.Text = "±";
            pNBtn.UseVisualStyleBackColor = false;
            pNBtn.Click += pNBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = SystemColors.ActiveCaptionText;
            threeBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            threeBtn.ForeColor = SystemColors.Control;
            threeBtn.Location = new Point(202, 318);
            threeBtn.Margin = new Padding(2);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(87, 82);
            threeBtn.TabIndex = 38;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.Click += buttonClick;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = SystemColors.ActiveCaptionText;
            sixBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            sixBtn.ForeColor = SystemColors.Control;
            sixBtn.Location = new Point(202, 231);
            sixBtn.Margin = new Padding(2);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(87, 82);
            sixBtn.TabIndex = 37;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += buttonClick;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = SystemColors.ActiveCaptionText;
            nineBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            nineBtn.ForeColor = SystemColors.Control;
            nineBtn.Location = new Point(202, 144);
            nineBtn.Margin = new Padding(2);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(87, 82);
            nineBtn.TabIndex = 36;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += buttonClick;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = SystemColors.ActiveCaptionText;
            dotBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            dotBtn.ForeColor = SystemColors.Control;
            dotBtn.Location = new Point(110, 405);
            dotBtn.Margin = new Padding(2);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(87, 82);
            dotBtn.TabIndex = 35;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.Click += buttonClick;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = SystemColors.ActiveCaptionText;
            twoBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            twoBtn.ForeColor = SystemColors.Control;
            twoBtn.Location = new Point(110, 318);
            twoBtn.Margin = new Padding(2);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(87, 82);
            twoBtn.TabIndex = 34;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += buttonClick;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = SystemColors.ActiveCaptionText;
            fiveBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            fiveBtn.ForeColor = SystemColors.Control;
            fiveBtn.Location = new Point(110, 231);
            fiveBtn.Margin = new Padding(2);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(87, 82);
            fiveBtn.TabIndex = 33;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += buttonClick;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = SystemColors.ActiveCaptionText;
            eightBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            eightBtn.ForeColor = SystemColors.Control;
            eightBtn.Location = new Point(110, 144);
            eightBtn.Margin = new Padding(2);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(87, 82);
            eightBtn.TabIndex = 32;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += buttonClick;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = SystemColors.ActiveCaptionText;
            zeroBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            zeroBtn.ForeColor = SystemColors.Control;
            zeroBtn.Location = new Point(19, 405);
            zeroBtn.Margin = new Padding(2);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(87, 82);
            zeroBtn.TabIndex = 31;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += buttonClick;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = SystemColors.ActiveCaptionText;
            oneBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            oneBtn.ForeColor = SystemColors.Control;
            oneBtn.Location = new Point(19, 318);
            oneBtn.Margin = new Padding(2);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(87, 82);
            oneBtn.TabIndex = 30;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += buttonClick;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = SystemColors.ActiveCaptionText;
            fourBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            fourBtn.ForeColor = SystemColors.Control;
            fourBtn.Location = new Point(19, 231);
            fourBtn.Margin = new Padding(2);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(87, 82);
            fourBtn.TabIndex = 29;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.Click += buttonClick;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = SystemColors.ActiveCaptionText;
            sevenBtn.Font = new Font("Agency FB", 35F, FontStyle.Regular, GraphicsUnit.Point);
            sevenBtn.ForeColor = SystemColors.Control;
            sevenBtn.Location = new Point(19, 144);
            sevenBtn.Margin = new Padding(2);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(87, 82);
            sevenBtn.TabIndex = 28;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.Click += buttonClick;
            // 
            // darkModeBtn
            // 
            darkModeBtn.AutoSize = true;
            darkModeBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            darkModeBtn.Location = new Point(307, 121);
            darkModeBtn.Margin = new Padding(2);
            darkModeBtn.Name = "darkModeBtn";
            darkModeBtn.Size = new Size(112, 24);
            darkModeBtn.TabIndex = 27;
            darkModeBtn.Text = "&Dark Mode";
            darkModeBtn.UseVisualStyleBackColor = true;
            darkModeBtn.CheckedChanged += darkModeBtn_CheckedChanged;
            // 
            // sciBtn
            // 
            sciBtn.AutoSize = true;
            sciBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sciBtn.Location = new Point(199, 121);
            sciBtn.Margin = new Padding(2);
            sciBtn.Name = "sciBtn";
            sciBtn.Size = new Size(94, 24);
            sciBtn.TabIndex = 26;
            sciBtn.TabStop = true;
            sciBtn.Text = "Scie&ntific";
            sciBtn.UseVisualStyleBackColor = true;
            sciBtn.CheckedChanged += sciBtn_CheckedChanged;
            // 
            // stdBtn
            // 
            stdBtn.AutoSize = true;
            stdBtn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stdBtn.Location = new Point(23, 121);
            stdBtn.Margin = new Padding(2);
            stdBtn.Name = "stdBtn";
            stdBtn.Size = new Size(96, 24);
            stdBtn.TabIndex = 25;
            stdBtn.TabStop = true;
            stdBtn.Text = "&Standard";
            stdBtn.UseVisualStyleBackColor = true;
            stdBtn.CheckedChanged += stdBtn_CheckedChanged;
            // 
            // showResultBox
            // 
            showResultBox.BorderStyle = BorderStyle.None;
            showResultBox.Font = new Font("Agency FB", 50F, FontStyle.Regular, GraphicsUnit.Point);
            showResultBox.Location = new Point(19, 33);
            showResultBox.Margin = new Padding(2);
            showResultBox.Name = "showResultBox";
            showResultBox.Size = new Size(533, 79);
            showResultBox.TabIndex = 24;
            showResultBox.Text = "0";
            showResultBox.TextAlign = HorizontalAlignment.Right;
            showResultBox.TextChanged += showResultBox_TextChanged;
            // 
            // introPage
            // 
            introPage.BackColor = Color.LightGray;
            introPage.Controls.Add(courseAssign1);
            introPage.Controls.Add(aboutMe1);
            introPage.Controls.Add(panel1);
            introPage.Location = new Point(4, 24);
            introPage.Margin = new Padding(2);
            introPage.Name = "introPage";
            introPage.Padding = new Padding(2);
            introPage.Size = new Size(613, 496);
            introPage.TabIndex = 1;
            introPage.Text = "About me";
            // 
            // courseAssign1
            // 
            courseAssign1.BackColor = Color.FromArgb(64, 64, 64);
            courseAssign1.Location = new Point(148, 2);
            courseAssign1.Margin = new Padding(2);
            courseAssign1.Name = "courseAssign1";
            courseAssign1.Size = new Size(424, 494);
            courseAssign1.TabIndex = 2;
            // 
            // aboutMe1
            // 
            aboutMe1.BackColor = Color.Silver;
            aboutMe1.Location = new Point(148, 2);
            aboutMe1.Margin = new Padding(2, 2, 2, 2);
            aboutMe1.Name = "aboutMe1";
            aboutMe1.Size = new Size(424, 494);
            aboutMe1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(aMBtn);
            panel1.Controls.Add(courseBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 492);
            panel1.TabIndex = 0;
            // 
            // aMBtn
            // 
            aMBtn.BackColor = Color.FloralWhite;
            aMBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aMBtn.Location = new Point(12, 253);
            aMBtn.Margin = new Padding(2);
            aMBtn.Name = "aMBtn";
            aMBtn.Size = new Size(116, 34);
            aMBtn.TabIndex = 1;
            aMBtn.Text = "About Me";
            aMBtn.UseVisualStyleBackColor = false;
            aMBtn.Click += aMBtn_Click;
            // 
            // courseBtn
            // 
            courseBtn.BackColor = Color.FloralWhite;
            courseBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            courseBtn.Location = new Point(12, 137);
            courseBtn.Margin = new Padding(2);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(116, 34);
            courseBtn.TabIndex = 0;
            courseBtn.Text = "Course";
            courseBtn.UseVisualStyleBackColor = false;
            courseBtn.Click += courseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(571, 524);
            Controls.Add(tagPage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Ho Wun Mok Calculator";
            Load += Form1_Load;
            tagPage.ResumeLayout(false);
            calPage.ResumeLayout(false);
            calPage.PerformLayout();
            introPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tagPage;
        private TabPage calPage;
        private Button equalBtn;
        private Button squRootBtn;
        private Button overBtn;
        private Button divideBtn;
        private Button multiplyBtn;
        private Button minusBtn;
        private Button plusBtn;
        private Button clearBtn;
        private Button pNBtn;
        private Button threeBtn;
        private Button sixBtn;
        private Button nineBtn;
        private Button dotBtn;
        private Button twoBtn;
        private Button fiveBtn;
        private Button eightBtn;
        private Button zeroBtn;
        private Button oneBtn;
        private Button fourBtn;
        private Button sevenBtn;
        private CheckBox darkModeBtn;
        private RadioButton sciBtn;
        private RadioButton stdBtn;
        private TextBox showResultBox;
        private TabPage introPage;
        private Button logBtn;
        private Button cosBtn;
        private Button sinBtn;
        private Button piBtn;
        private TextBox calSteps;
        private Panel panel1;
        private Button courseBtn;
        private Button aMBtn;
        private courseAssign courseAssign1;
        private aboutMe aboutMe1;
    }
}