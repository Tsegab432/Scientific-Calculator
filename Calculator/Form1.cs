using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            double num = Math.Sin(90 * Math.PI/180);
            label1.Text = num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text += "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string input = label2.Text;
            string[] parts = input.Split(' ');

            if (parts.Length == 2)
            {
                string function = parts[0].ToLower();
                double number;

                if (double.TryParse(parts[1], out number))
                {
                    switch (function)
                    {
                        case "sin":
                            double sinResult = Math.Sin(number * Math.PI / 180); // Convert degrees to radians
                            label2.Text = sinResult.ToString();
                            return;
                        case "cos":
                            double cosResult = Math.Cos(number * Math.PI / 180); // Convert degrees to radians
                            label2.Text = cosResult.ToString();
                            return;
                        case "tan":
                            double tanResult = Math.Tan(number * Math.PI / 180); // Convert degrees to radians
                            label2.Text = tanResult.ToString();
                            return;
                        case "abs":
                            double absResult = Math.Abs(number);
                            label2.Text = absResult.ToString();
                            return;
                        case "fac":
                            long factorial = CalculateFactorial((int)number);
                            label2.Text= factorial.ToString();
                            break;
                        case "sqrt":
                            double sqrtResult = Math.Sqrt(number);
                            label2.Text = sqrtResult.ToString();
                            break;
                        case "sqrd":
                            double sqrdResult = Math.Pow(number, 2);
                            label2.Text = sqrdResult.ToString();
                            break;
                        default:
                            label2.Text = "Invalid expression";
                            break;
                    }
                }
            }
            else
            {
                try
                {
                    object result = new DataTable().Compute(input, null);
                    label2.Text = result.ToString();
                    

                }
                catch (SyntaxErrorException)
                {
                    label2.Text = "Invalid expression.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        static long CalculateFactorial(int n)
        {
            long result = 1;
            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                return 0;
            }
            return result;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text += "sin ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text += "cos ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text += "tan ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text += Math.PI;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text += Math.E;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label2.Text += ".";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text += "abs ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text += "fac ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text += "sqrt ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text += "sqrd ";
        }
    }
}
