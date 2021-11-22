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

namespace Formularios
{
    public partial class FormAltaPais : Form
    {
        Mundo mundo = new Mundo();

        public FormAltaPais(Mundo mundo)
        {
            InitializeComponent();
            this.mundo = mundo;
            cmbContinente.DataSource = Enum.GetValues(typeof(EContinente));
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarSinVacios())
                {
                    mundo.AltaPais(txtNombrePais.Text, cmbContinente.Text, txtPoblacionTotal.Text,
                    txtInfectados.Text, txtFallecidos.Text, txtVacunados.Text);

                    MessageBox.Show("Se agrego el pais con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarTextBox();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(PaisRepetidoException ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(ValorNumericoExeption ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DatoIncorrectoException ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor ingresado incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtNombrePais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(ValidarSoloLetras(e))
            {
                lblNombreError.Text = "*Ingresar solo letras";
            }
            else
            {
                lblNombreError.Text = "";
            }
        }

        private void txtPoblacionTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloNumeros(e))
            {
                lblPoblacionError.Text = "*Ingresar solo numeros";
            }
            else
            {
                lblPoblacionError.Text = "";
            }
        }

        private void txtInfectados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloNumeros(e))
            {
                lblInfectadosError.Text = "*Ingresar solo numeros";
            }
            else
            {
                lblInfectadosError.Text = "";
            }
        }

        private void txtFallecidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarSoloNumeros(e))
            {
                lblFallecidosError.Text = "*Ingresar solo numeros";
            }
            else
            {
                lblFallecidosError.Text = "";
            }
        }

        private void txtVacunados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(ValidarSoloNumeros(e))
            {
                lblVacunadosError.Text = "*Ingresar solo numeros";
            }
            else
            {
                lblVacunadosError.Text = "";
            }
        }


        private bool ValidarSinVacios()
        {
            if(string.IsNullOrEmpty(txtNombrePais.Text) || string.IsNullOrEmpty(cmbContinente.Text) ||
                string.IsNullOrEmpty(txtPoblacionTotal.Text) || string.IsNullOrEmpty(txtInfectados.Text) ||
                string.IsNullOrEmpty(txtFallecidos.Text) || string.IsNullOrEmpty(txtVacunados.Text))
            {
                return false;
            }

            return true;
        }

        private bool ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e.Handled;
        }

        private bool ValidarSoloLetras(KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e.Handled;
        }

        private void BorrarTextBox()
        {
            this.txtNombrePais.Text = string.Empty;
            this.txtPoblacionTotal.Text = string.Empty;
            this.txtInfectados.Text = string.Empty;
            this.txtFallecidos.Text = string.Empty;
            this.txtVacunados.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
