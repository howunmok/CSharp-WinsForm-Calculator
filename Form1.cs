namespace assignment05
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        //Remove minimize button and maximize button
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        //Standard Mode
        private void stdBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 587;
            showResultBox.Width = 533;
            calSteps.Width = 533;
        }

        //Scientific Mode
        private void sciBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 681;
            showResultBox.Width = 630;
            calSteps.Width = 630;
        }

        //Dark Mode
        private void darkModeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeBtn.Checked)
            {
                calPage.BackColor = Color.DarkGray;
            }
            else
            {
                calPage.BackColor = Color.Transparent;
            }

        }

        //Buttons 0-9 and .
        private void buttonClick(object sender, EventArgs e)
        {
            if (showResultBox.Text == "0")
            {
                showResultBox.Clear();
                value = 0;
            }

            Button numBtn = (Button)sender;
            if (numBtn.Text == ".")
            {
                if (!showResultBox.Text.Contains("."))
                {
                    showResultBox.Text = showResultBox.Text + numBtn.Text;
                }
            }
            else
            {
                showResultBox.Text = showResultBox.Text + numBtn.Text;
            }
        }

        //Call Plus and Minus operators
        private void operatorClick(object sender, EventArgs e)
        {
            Button oprBtn = (Button)sender;
            operation = oprBtn.Text;
            value = double.Parse(showResultBox.Text);
            showResultBox.Text = "";
            calSteps.Text = $"{value} {operation} ";
        }

        //Call Multiply operators
        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            Button multBtn = (Button)sender;
            operation = "*";
            value = double.Parse(showResultBox.Text);
            showResultBox.Text = "";
            calSteps.Text = $"{value} \u00d7 ";
        }

        //Call divide operators
        private void divideBtn_Click(object sender, EventArgs e)
        {
            Button divBtn = (Button)sender;
            operation = "/";
            value = double.Parse(showResultBox.Text);
            showResultBox.Text = "";
            calSteps.Text = $"{value} \u00f7 ";
        }

        //Clear Button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            showResultBox.Text = "0";
            value = 0;
            calSteps.Clear();
        }

        private void showResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Equal Button with calculation
        private void equalBtn_Click(object sender, EventArgs e)
        {
            string result;


            switch (operation)
            {
                case "+":
                    if (showResultBox.Text.Contains("-"))
                    {
                        result = (value + double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} + ({showResultBox.Text})";
                        showResultBox.Text = result;
                    }
                    else
                    {
                        result = (value + double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} + {showResultBox.Text}";
                        showResultBox.Text = result;
                    }
                    break;
                case "-":
                    if (showResultBox.Text.Contains("-"))
                    {
                        result = (value - double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} - ({showResultBox.Text})";
                        showResultBox.Text = result;
                    }
                    else
                    {
                        result = (value - double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} - {showResultBox.Text}";
                        showResultBox.Text = result;
                    }
                    break;
                case "*":
                    if (showResultBox.Text.Contains("-"))
                    {
                        result = (value * double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} \u00d7 ({showResultBox.Text})";
                        showResultBox.Text = result;
                    }
                    else
                    {
                        result = (value * double.Parse(showResultBox.Text)).ToString();
                        calSteps.Text = $"{value} \u00d7 {showResultBox.Text}";
                        showResultBox.Text = result;
                    }
                    break;
                case "/":
                    if (showResultBox.Text != "0")
                    {
                        if (showResultBox.Text.Contains("-"))
                        {
                            result = (value / double.Parse(showResultBox.Text)).ToString();
                            calSteps.Text = $"{value} \u00f7 ({showResultBox.Text})";
                            showResultBox.Text = result;
                        }
                        else
                        {
                            result = (value / double.Parse(showResultBox.Text)).ToString();
                            calSteps.Text = $"{value} \u00f7 {showResultBox.Text}";
                            showResultBox.Text = result;
                        }
                    }
                    else
                    {
                        showResultBox.Text = "Math Error";
                        MessageBox.Show("Please press \"Clear\"!");
                    }
                    break;
            }
        }

        //Calculating with Pi
        private void piBtn_Click(object sender, EventArgs e)
        {
            showResultBox.Text = Math.PI.ToString();
        }

        //Calculating with Log
        private void logBtn_Click(object sender, EventArgs e)
        {
            if (showResultBox.Text != "0")
            {
                double toBeLog = double.Parse(showResultBox.Text);
                double logNum = Math.Log10(toBeLog);
                showResultBox.Text = logNum.ToString();
                calSteps.Text = $"Log {toBeLog}";
            }
            else
            {
                showResultBox.Text = "Math Error";
                MessageBox.Show("Please press \"Clear\"!");
            }
        }

        //Calculating with sin
        private void sinBtn_Click(object sender, EventArgs e)
        {
            double toBeSin = double.Parse(showResultBox.Text);
            double sinNum = Math.Sin(toBeSin);
            showResultBox.Text = sinNum.ToString();
            calSteps.Text = $"sin {toBeSin}";
        }

        //Calculating with cos
        private void cosBtn_Click(object sender, EventArgs e)
        {
            double toBeCos = double.Parse(showResultBox.Text);
            double cosNum = Math.Cos(toBeCos);
            showResultBox.Text = cosNum.ToString();
            calSteps.Text = $"cos {toBeCos}";
        }

        //Calculating with squreroot
        private void squRootBtn_Click(object sender, EventArgs e)
        {
            double toBeSqrt = double.Parse(showResultBox.Text);
            double sqrtNum = Math.Sqrt(toBeSqrt);
            showResultBox.Text = sqrtNum.ToString();
            calSteps.Text = $"กิ {toBeSqrt}";
        }

        //Calculating 1 over
        private void overBtn_Click(object sender, EventArgs e)
        {
            double overNum = 1 / double.Parse(showResultBox.Text);
            calSteps.Text = $"1 / {showResultBox.Text}";
            showResultBox.Text = overNum.ToString();
        }

        //positive and negative value
        private void pNBtn_Click(object sender, EventArgs e)
        {
            if (showResultBox.Text.Contains("-"))
            {
                showResultBox.Text = showResultBox.Text.Trim('-');
            }
            else
            {
                showResultBox.Text = "-" + showResultBox.Text;
            }
        }

        //About me page, shows course
        private void courseBtn_Click(object sender, EventArgs e)
        {
            aboutMe1.Hide();
            courseAssign1.Show();
            courseAssign1.BringToFront();
        }

        //About me page, shows intro
        private void aMBtn_Click(object sender, EventArgs e)
        {
            courseAssign1.Hide();
            aboutMe1.Show();
            aboutMe1.BringToFront();
        }
    }
}