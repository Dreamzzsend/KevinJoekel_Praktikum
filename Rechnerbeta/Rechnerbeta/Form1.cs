using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnerbeta
{
    public partial class Form1 : Form
    {
        string message = "Bitte eine zahl eingeben";
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                double txt1 = Convert.ToDouble(num1.Text);
                double txt2 = Convert.ToDouble(num2.Text);
                double summePlus = txt1 + txt2;
                ergebnis.Text = summePlus.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(message);
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                double txt1 = Convert.ToDouble(num1.Text);
                double txt2 = Convert.ToDouble(num2.Text);
                double summeMinus = txt1 - txt2;
                ergebnis.Text = summeMinus.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(message);
            }


        }
        
        private void Multiplizieren_Click(object sender, EventArgs e)
        {
            try
            {
                double txt1 = Convert.ToDouble(num1.Text);
                double txt2 = Convert.ToDouble(num2.Text);
                double summeMultiplizieren = txt1 * txt2;
                ergebnis.Text = summeMultiplizieren.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(message);
            }

        }

        private void Dividieren_Click(object sender, EventArgs e)
        {
            try
            {
                double txt1 = Convert.ToDouble(num1.Text);
                double txt2 = Convert.ToDouble(num2.Text);
                double summeDivision = txt1 / txt2;
                ergebnis.Text = summeDivision.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(message);

            }

        }

        private void ergebnis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Prozent_Click(object sender, EventArgs e)
        {
            try
            {
                double txt1 = Convert.ToDouble(num1.Text);
                double txt2 = Convert.ToDouble(num2.Text);
                double summeProzent = txt1 / txt2 * 100;
                ergebnis.Text = summeProzent.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(message);
            }
             
        }
    }
}
