using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private float guardado = 0;
        private int operador = 0;
        float porcentaje = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void btCero_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
                screen.Text += "0";
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "1";
            else
                screen.Text += "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "2";
            else
                screen.Text += "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "3";
            else
                screen.Text += "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "4";
            else
                screen.Text += "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "5";
            else
                screen.Text += "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "6";
            else
                screen.Text += "6";
        }

        private void btSiete_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "7";
            else
                screen.Text += "7";
        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "8";
            else
                screen.Text += "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
                screen.Text = "9";
            else
                screen.Text += "9";
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            if(!screen.Text.Contains('.'))
                screen.Text += ".";
        }

        private void btInvertir_Click(object sender, EventArgs e)
        {
            if (screen.Text.Substring(0, 1) == "-")
                screen.Text = screen.Text.Substring(1);
            else
                screen.Text = "-" + screen.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            guardado = 0;
            screen.Text = "0";
        }

        private void btBackspace_Click(object sender, EventArgs e)
        {
            if (screen.TextLength > 1)
                screen.Text = screen.Text.Remove((screen.TextLength) - 1, 1);
            else
                screen.Text = "0";
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            guardado = float.Parse(screen.Text);
            operador = 1;
            screen.Text = "0";
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            guardado = float.Parse(screen.Text);
            operador = 2;
            screen.Text = "0";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            guardado = float.Parse(screen.Text);
            operador = 3;
            screen.Text = "0";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            guardado = float.Parse(screen.Text);
            operador = 4;
            screen.Text = "0";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case 1:
                    guardado += float.Parse(screen.Text);
                    screen.Text = guardado.ToString();
                    break;

                case 2:
                    guardado -= float.Parse(screen.Text);
                    screen.Text = guardado.ToString();
                    break;
                case 3:
                    guardado *= float.Parse(screen.Text);
                    screen.Text = guardado.ToString();
                    break;
                case 4:
                    if (float.Parse(screen.Text) == 0)
                        screen.Text = "Error. División entre 0.";
                    else
                    {
                        guardado /= float.Parse(screen.Text);
                        screen.Text = guardado.ToString();
                    }
                    break;
            }
        }

        private void btPorcentaje_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case 1:
                    porcentaje = guardado * (float.Parse(screen.Text) / 100);
                    guardado += porcentaje;
                    screen.Text = guardado.ToString();
                    break;
                case 2:
                    porcentaje = guardado * (float.Parse(screen.Text) / 100);
                    guardado -= porcentaje;
                    screen.Text = guardado.ToString();
                    break;
                case 3:
                    porcentaje = guardado * (float.Parse(screen.Text) / 100);
                    guardado = porcentaje;
                    screen.Text = guardado.ToString();
                    break;
                case 4:
                    if (float.Parse(screen.Text) == 0)
                        screen.Text = "Error. División entre 0.";
                    else
                    {
                        porcentaje = guardado / (float.Parse(screen.Text) / 100);
                        guardado = porcentaje;
                        screen.Text = guardado.ToString();
                    }
                    break;
            }
        }
    }
}
