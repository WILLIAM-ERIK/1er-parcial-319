using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double aux1, aux2;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }
        classes.ClaseOperaciones operacion = new classes.ClaseOperaciones();
        private void restart()
        {
            PANTALLA.Text = "0";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PANTALLA.Text = "0";
            operation.Text = "";
        }
        
        private void btnMas_Click(object sender, EventArgs e)
        {
            operador = "+";
            operation.Text = "SUMA";
            aux1 = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            operation.Text = "RESTA";
            aux1 = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            operador = "*";
            operation.Text = "MULTIPLICACIÓN";
            aux1 = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            operation.Text = "DIVISIÓN";
            aux1 = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            aux2 = double.Parse(PANTALLA.Text);
            operation.Text = "RESULTADO";
            double OPSuma;
            switch (operador)
            {
                case "+":
                    OPSuma = operacion.Sumas(aux1, aux2);
                    PANTALLA.Text = OPSuma.ToString();
                    break;
                case "-":
                    OPSuma = operacion.Restas(aux1, aux2);
                    PANTALLA.Text = OPSuma.ToString();
                    break;
                case "/":
                    OPSuma = operacion.Division(aux1, aux2);
                    PANTALLA.Text = OPSuma.ToString();
                    break;
                case "*":
                    OPSuma = operacion.Multiplicacion(aux1, aux2);
                    PANTALLA.Text = OPSuma.ToString();
                    break;

                default:
                    return;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Equals("0")) PANTALLA.Text = "";
            PANTALLA.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!PANTALLA.Text.Contains(".")) {
                PANTALLA.Text += ".";
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            operation.Text = "";
            PANTALLA.Text = "0";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
