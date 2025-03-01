namespace advanced_Calc
{
    public partial class advanced_calculator : Form
    {
        // Stores the first operand in a two-operand operation
        double firstNumber = 0;

        // Stores the operation symbol, e.g. "+", "-", "*", "/", "x^y", etc.
        string operation = "";

        // Tracks whether the last button pressed was an operation (to control clearing vs appending digits)
        bool operationPressed = false;
        public advanced_calculator()
        {
            InitializeComponent();
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "1") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "2") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "3") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "4") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "5") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "6") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "7") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "8") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "9") || operationPressed)
                textBox1.Clear();

            operationPressed = false;
            textBox1.Text += "9";
        }

        private void bt_point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void bt_pls_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "+";
            operationPressed = true;
        }

        private void bt_mins_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "-";
            operationPressed = true;
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "*";
            operationPressed = true;
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "/";
            operationPressed = true;
        }

        private void bt_equl_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0.0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    // Handle division by zero carefully
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero!");
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                    // You can add more operations here if needed
            }

            textBox1.Text = result.ToString();
            // Optionally store the result back to firstNumber
            firstNumber = result;
            operation = "";
        }

        private void bt_plus_minus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && double.TryParse(textBox1.Text, out double val))
            {
                val = -val;
                textBox1.Text = val.ToString();
            }
        }

        private void bt_clen_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            operation = "";
            operationPressed = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "";
                }
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void bt_root_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                if (val < 0)
                {
                    MessageBox.Show("Cannot take the square root of a negative number (in real domain).");
                    return;
                }
                textBox1.Text = Math.Sqrt(val).ToString();
            }
        }

        private void bt_x_squer_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Pow(val, 2).ToString();
            }
        }

        private void bt_1_x_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                if (val == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                textBox1.Text = (1.0 / val).ToString();
            }
        }

        private void bt_y_x_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "x^y";
            operationPressed = true;
        }

        private void bt_sin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Sin(val).ToString();
            }
        }

        private void bt_cos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Cos(val).ToString();
            }
        }

        private void bt_tan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Tan(val).ToString();
            }
        }

        private void bt_ln_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                if (val <= 0)
                {
                    MessageBox.Show("ln is not defined for zero or negative numbers (in real domain).");
                    return;
                }
                textBox1.Text = Math.Log(val).ToString();
            }
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                if (val <= 0)
                {
                    MessageBox.Show("log10 is not defined for zero or negative numbers (in real domain).");
                    return;
                }
                textBox1.Text = Math.Log10(val).ToString();
            }
        }

        private void bt_e_x_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Exp(val).ToString();
            }
        }

        private void bt_persent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = (val / 100.0).ToString();
            }
        }

        private void bt_abs_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double val))
            {
                textBox1.Text = Math.Abs(val).ToString();
            }

        }

        private void bt_pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();

        }

        private void advanced_calculator_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
