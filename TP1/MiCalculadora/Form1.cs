using Entidades;
using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            char caracterOperador = '+';

            for (int i = 0; i < operador.Length; i++)
            {
                caracterOperador = operador[i];
            }

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            return Calculadora.Operar(num1, num2, caracterOperador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double numero1 = 0;
            double numero2 = 0;
            string operador = "+";

            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            double.TryParse(txtNumero1.Text, out numero1);
            double.TryParse(txtNumero2.Text, out numero2);

            if (cmbOperador.Text == "-" || cmbOperador.Text == "/" || cmbOperador.Text == "*")
                operador = cmbOperador.Text;

            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add(numero1 + " " + operador + " " + numero2 + " = " + resultado);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lstOperaciones.Items.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numDecimal = lblResultado.Text;
            int numEntero;

            Operando binario = new Operando();

            string numBinario = "Valor invalido";

            if (int.TryParse(numDecimal, out numEntero))
                numBinario = binario.DecimalBinario(numDecimal);


            lblResultado.Text = numBinario;

            if (numBinario == "Valor invalido")
            {
                lstOperaciones.Items.Add("No es posible convertir a binario");
            }
            else
            {
                lstOperaciones.Items.Add(numDecimal + " convertido a binario: " + numBinario);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numBinario = lblResultado.Text;

            Operando numeroDecimal = new Operando();

            string numDecimal = numeroDecimal.BinarioDecimal(numBinario);


            lblResultado.Text = numDecimal;

            if (numDecimal == "Valor invalido")
            {
                lstOperaciones.Items.Add("No es un numero binario");
            }
            else
            {
                lstOperaciones.Items.Add(numBinario + " convertido a decimal: " + numDecimal);
            }
        }
    }
}
