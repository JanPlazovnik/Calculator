using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double prvoStevilo, drugoStevilo;
        char operacija;
        bool koncano;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "1";
                koncano = false;
            }
            else
                result.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            { 
                result.Text = "2";
                koncano = false;
            }
            else
                result.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            { 
                result.Text = "3";
                koncano = false;
            }
            else
                result.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "4";
                koncano = false;
            }
            else
                result.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "5";
                koncano = false;
            }
            else
                result.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "6";
                koncano = false;
            }
            else
                result.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "7";
                koncano = false;
            }
            else
                result.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "8";
                koncano = false;
            }
            else
                result.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "9";
                koncano = false;
            }
            else
                result.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "0";
                koncano = false;
            }
            else
                result.Text += "0";
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            if (koncano || result.Text == "0" && result.Text != null)
            {
                result.Text = "0";
                koncano = false;
            }
            else
                result.Text += ",";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            try
            {
                prvoStevilo = Convert.ToDouble(result.Text);
                operacija = '+';
                result.Text = "0";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Napaka.");
                result.Text = "0";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                prvoStevilo = Convert.ToDouble(result.Text);
                operacija = '-';
                result.Text = "0";
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Napaka.");
                result.Text = "0";
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            try
            {
                prvoStevilo = Convert.ToDouble(result.Text);
                operacija = '*';
                result.Text = "0";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Napaka.");
                result.Text = "0";
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                prvoStevilo = Convert.ToDouble(result.Text);
                operacija = '/';
                result.Text = "0";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Napaka.");
                result.Text = "0";
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            switch(operacija)
            {
                case '+':
                    drugoStevilo = Convert.ToDouble(result.Text);
                    result.Text = (prvoStevilo + drugoStevilo).ToString();
                    koncano = true;
                    break;
                case '-':
                    drugoStevilo = Convert.ToDouble(result.Text);
                    result.Text = (prvoStevilo - drugoStevilo).ToString();
                    koncano = true;
                    break;
                case '*':
                    drugoStevilo = Convert.ToDouble(result.Text);
                        result.Text = (prvoStevilo * drugoStevilo).ToString();
                    break;
                case '/':
                    drugoStevilo = Convert.ToDouble(result.Text);
                    if (prvoStevilo == 0 || drugoStevilo == 0)
                        result.Text = "NAPAKA";
                    else
                        result.Text = (prvoStevilo / drugoStevilo).ToString();
                    break;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (result.Text != string.Empty)
            {
                int txtlength = result.Text.Length;
                if (txtlength != 1)
                {
                    result.Text = result.Text.Remove(txtlength - 1);
                }
                else
                {
                    result.Text = 0.ToString();
                }
            }
        }

        private void btn_predznak_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(result.Text);
            number = -number;
            result.Text = number.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            prvoStevilo = 0;
            drugoStevilo = 0;
        }
    }
}
