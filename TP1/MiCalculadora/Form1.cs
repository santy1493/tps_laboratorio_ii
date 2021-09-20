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

        /// <summary>
        /// Crea dos numeros de la clase Operando y llama al metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Implementa el metodo operar e imprime el resultado y la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Implementa el metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia los textBox, Labels y Listas del Form
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lstOperaciones.Items.Clear();
        }

        /// <summary>
        /// Al hacer click sobre el boton Cerrar se abre un cuadro preguntado por si o por no para cerrar el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// LLama al metodo DecimalBinario e imprime el numero convertido a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// LLama al metodo BinarioDecimal e imprime el numero convertido a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
