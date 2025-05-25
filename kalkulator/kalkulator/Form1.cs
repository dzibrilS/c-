namespace kalkulator
{
    public partial class Form1 : Form
    {
        double fstNum, secNum;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "9";
            }
            else
            {
                txt.Text = txt.Text + "9";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "8";
            }
            else
            {
                txt.Text = txt.Text + "8";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "7";
            }
            else
            {
                txt.Text = txt.Text + "7";
            }
        }
        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "6";
            }
            else
            {
                txt.Text = txt.Text + "6";
            }
        }
        private void btn5_Click_1(object sender, EventArgs e)

        {
            if (txt.Text == "0")
            {
                txt.Text = "5";
            }
            else
            {
                txt.Text = txt.Text + "5";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "4";
            }
            else
            {
                txt.Text = txt.Text + "4";
            }
        }
        private void btn3_Click(object sender, EventArgs e)

        {
            if (txt.Text == "0")
            {
                txt.Text = "5";
            }
            else
            {
                txt.Text = txt.Text + "5";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "2";
            }
            else
            {
                txt.Text = txt.Text + "2";
            }
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "1";
            }
            else
            {
                txt.Text = txt.Text + "1";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "0";
            }
            else
            {
                txt.Text = txt.Text + "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txt.Text);
            oper = "+";
            txt.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txt.Text);
            oper = "-";
            txt.Text = "";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txt.Text);
            oper = "*";
            txt.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txt.Text);
            oper = "/";
            txt.Text = "";
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txt.Text);
            txt.Text = Convert.ToString(-1 * q);
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txt.Text.Contains("."))
            {
                txt.Text += ".";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(txt.Text);

            switch(oper)
            {
                case "+":
                    txt.Text = (fstNum + secNum).ToString();
                    break;
                case "-":
                    txt.Text = (fstNum - secNum).ToString();
                    break;
                case "/":
                    txt.Text = (fstNum / secNum).ToString();
                    break;
                case "*":
                    txt.Text = (fstNum * secNum).ToString();
                    break;
                default:
                    break;
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            txt.Text = "0";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);
            f = "";
            s = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(txt.Text.Length >0)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
            }
            if(txt.Text == "")
            {
                txt.Text = "0";
            }
        }
    }
}
