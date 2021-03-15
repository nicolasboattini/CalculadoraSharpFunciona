using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSharp
{
    public partial class Form1 : Form
    {
        bool textonumero=true;
        string ejecutar;
        double num;
        double num2, total;

        private void button3_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "3";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "1";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "2";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "4";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "5";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "6";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "7";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "8";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "9";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (TxtNumeros.Text== "0")
            {
                return;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "0";
            }
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            ejecutar = "+";
            textonumero = true;
            num = double.Parse(TxtNumeros.Text);
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            ejecutar = "-";
            textonumero = true;
            num = double.Parse(TxtNumeros.Text);
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            ejecutar = "/";
            textonumero = true;
            num = double.Parse(TxtNumeros.Text);
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            ejecutar = "*";
            textonumero = true;
            num = double.Parse(TxtNumeros.Text);
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(TxtNumeros.Text);
            textonumero = true;
            switch (ejecutar)
            {
                case "+":
                    total = num + num2;
                    TxtNumeros.Text = total.ToString();
                    break;
                case "-":
                    total = num - num2;
                    TxtNumeros.Text = total.ToString();
                    break;
                case "/":
                    total = num / num2;
                    TxtNumeros.Text = total.ToString();
                    break;
                case "*":
                    total = num * num2;
                    TxtNumeros.Text = total.ToString();
                    break;
            }

        }

        private void Cero_Click(object sender, EventArgs e)
        {
            TxtNumeros.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
