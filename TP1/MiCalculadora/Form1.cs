using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

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
            
            for(int i=0;i<operador.Length;i++)
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
            
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add(txtNumero1.Text + " " + cmbOperador.Text + " " + txtNumero2.Text + " = " + resultado);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            cmbOperador.Text = "";
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

            Operando binario = new Operando();

            string numBinario = binario.DecimalBinario(numDecimal);


            lblResultado.Text = numBinario;

            if(numBinario=="ERROR")
            {
                lstOperaciones.Items.Add("No es posible convertir numeros negativos");
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

            if (numDecimal == "ERROR")
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
