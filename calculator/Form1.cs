namespace calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userinput = "";
        public Form1(string userinput)
        {
            this.userinput = userinput;
        }

        private object myLabel;
        private char funtion;
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "1";
            calulatordisplay.Text += userinput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "2";
            calulatordisplay.Text += userinput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "3";
            calulatordisplay.Text += userinput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "4";
            calulatordisplay.Text += userinput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "5";
            calulatordisplay.Text += userinput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "6";
            calulatordisplay.Text += userinput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "7";
            calulatordisplay.Text += userinput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "8";
            calulatordisplay.Text += userinput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "9";
            calulatordisplay.Text += userinput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calulatordisplay.Text = "";
            userinput += "0";
            calulatordisplay.Text += userinput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userinput = "";
            calulatordisplay.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firstnum, secondnum;
            firstnum = Convert.ToDouble(first);
            secondnum = Convert.ToDouble(second);
            //plus
            if (function == '+')
            {
                result = firstnum + secondnum;
                calulatordisplay.Text = result.ToString();
            }
            //mius
            else if (function == '-')
            {
                result = secondnum - firstnum;
                calulatordisplay.Text = result.ToString();
            }
            //Divide 
            else if (function == '/')
            {
                if (secondnum == 0)
                {
                    calulatordisplay.Text = "impossible";
                }
                else
                {
                    result = firstnum / secondnum;
                    calulatordisplay.Text = result.ToString();
                }

            }
            //multiply
            else if (function == '*')
            {
                result = firstnum * secondnum;
                calulatordisplay.Text = result.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";
        }
    }
}
