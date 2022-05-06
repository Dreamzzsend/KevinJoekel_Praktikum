using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        string operation;   
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            Ergebnis.Text += "0";
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "1";
            }
            else
            {
                Ergebnis.Text += "1";
            }   
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "2";
            }
            else
            {
                Ergebnis.Text += "2";
            }
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "3";
            }
            else
            {
                Ergebnis.Text += "3";
            }
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "4";
            }
            else
            {
                Ergebnis.Text += "4";
            }
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "5";
            }
            else
            {
                Ergebnis.Text += "5";
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "6";
            }
            else
            {
                Ergebnis.Text += "6";
            }
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "7";
            }
            else
            {
                Ergebnis.Text += "7";
            }
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "8";
            }
            else
            {
                Ergebnis.Text += "8";
            }
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = "9";
            }
            else
            {
                Ergebnis.Text += "9";
            }
        }
        private void Komma_Click(object sender, EventArgs e)
        {
            if (Ergebnis.Text == "0")
            {
                Ergebnis.Text = ",";
            }
            else
            {
                Ergebnis.Text += ",";
            }
        }
        private void Gleich_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(Ergebnis.Text);
                if (operation == "+")
                {
                    result = num1 + num2;
                    Ergebnis.Text = Convert.ToString(result);
                }
                if (operation == "-")
                {
                    result = num1 - num2;
                    Ergebnis.Text = Convert.ToString(result);
                }
                if (operation == "*")
                {
                    result = num1 * num2;
                    Ergebnis.Text = Convert.ToString(result);
                }
                if (operation == "/")
                {
                    result = num1 / num2;
                    Ergebnis.Text = Convert.ToString(result);
                }
                if (operation == "%")
                {
                    result = num1 / num2 * 100;
                    Ergebnis.Text = Convert.ToString(result);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte eine zahl eingeben");
            }
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Ergebnis.Text);
            Ergebnis.Text = null;
            operation = "+";
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Ergebnis.Text);
            Ergebnis.Text = null;
            operation = "-";
        }
        private void Multiplizieren_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Ergebnis.Text);
            Ergebnis.Text = null;
            operation = "*";
        }
        private void Division_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Ergebnis.Text);
            Ergebnis.Text = null;
            operation = "/";
        }
        private void percent_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Ergebnis.Text);
            Ergebnis.Text = null;
            operation = "%";
        }
        private void Ergebnis_TextChanged(object sender, EventArgs e)
        {
        }
        private void C_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = null;
            num1 = Convert.ToDouble(null);
            num2 = Convert.ToDouble(null);
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = null;
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = "-" + Ergebnis.Text;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            int stringLength = Ergebnis.Text.Length;
            if (stringLength > 1)
            {
                Ergebnis.Text = Ergebnis.Text.Substring(0, stringLength - 1);
            }
        }

        private void wurzel_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(Ergebnis.Text);
                if (num1 > 0)
                {
                    double sqrt = Math.Sqrt(num1);
                    Ergebnis.Text = sqrt.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte eine zahl eingeben");
            }
        }

        private void Ergebnis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.Shift && e.KeyCode == Keys.D5)
                    {
                        num1 = Convert.ToDouble(Ergebnis.Text);
                        Ergebnis.Text = null;
                        operation = "%";
                    }
                    if (e.KeyCode == Keys.Divide)
                    {
                        num1 = Convert.ToDouble(Ergebnis.Text);
                        Ergebnis.Text = null;
                        operation = "/";
                    }
                    if (e.KeyCode == Keys.Enter)
                    {
                        num2 = Convert.ToDouble(Ergebnis.Text);
                        if (operation == "+")
                        {
                            result = num1 + num2;
                            Ergebnis.Text = Convert.ToString(result);

                        }
                        if (operation == "-")
                        {
                            result = num1 - num2;
                            Ergebnis.Text = Convert.ToString(result);
                        }
                        if (operation == "*")
                        {
                            result = num1 * num2;
                            Ergebnis.Text = Convert.ToString(result);
                        }
                        if (operation == "/")
                        {
                            result = num1 / num2;
                            Ergebnis.Text = Convert.ToString(result);
                        }
                        if (operation == "%")
                        {
                            result = num1 / num2 * 100;
                            Ergebnis.Text = Convert.ToString(result);

                        }
                }   }
                catch (FormatException)
                {
                    MessageBox.Show("bitte geben sie eine zahl ein");
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                num1 = Convert.ToDouble(Ergebnis.Text);
                Ergebnis.Text = null;
                operation = "*";
            }
            if (e.KeyCode == Keys.Delete)
            {
                int stringLength = Ergebnis.Text.Length;
                if (stringLength > 1)
                {
                    Ergebnis.Text = Ergebnis.Text.Substring(0, stringLength - 1);
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                num1 = Convert.ToDouble(Ergebnis.Text);
                Ergebnis.Text = null;
                operation = "-";
            }
            if (e.KeyCode == Keys.Add)
            {
                num1 = Convert.ToDouble(Ergebnis.Text);
                Ergebnis.Text = null;
                operation = "+";
            }
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3)
            {
                num1 = float.Parse(Ergebnis.Text);
                if (num1 > 0)
                {
                    double sqrt = Math.Sqrt(num1);
                    Ergebnis.Text = sqrt.ToString();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                Ergebnis.Text = null;
                num1 = Convert.ToDouble(null);
                num2 = Convert.ToDouble(null);
            }
        }
    }
}
