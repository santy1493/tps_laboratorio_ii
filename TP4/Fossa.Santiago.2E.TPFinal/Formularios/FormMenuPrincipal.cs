using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{

    public delegate void DelegadoIniciarForm();

    public partial class FormMenuPrincipal : Form
    {
        Mundo mundo;
        static int cantPaises = 0;
        static string nombrePais;
        DelegadoIniciarForm delegadoIniciarForm;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            mundo = new Mundo();
            btnInformes.Enabled = false;
            dgvPaises.Hide();
            Task iniciarForm = Task.Run(() => IniciarForm());
            this.mundo.paisBorrado += DeshabilitarBotonInformes;
            this.mundo.paisBorrado += BorrarDatosGrilla;

        }

        private void btnAltaPais_Click(object sender, EventArgs e)
        {

            FormAltaPais formAltaPais = new FormAltaPais(mundo);
            formAltaPais.ShowDialog();
            ActualizarDatosForm();

        }

        private void LlenarGrilla()
        {
            if (mundo.ListaPaises.Count > 0)
            {
                dgvPaises.Rows.Clear();

                int n;

                foreach (Pais pais in mundo.ListaPaises)
                {
                    n = dgvPaises.Rows.Add();

                    dgvPaises.Rows[n].Cells[0].Value = pais.Nombre;
                    dgvPaises.Rows[n].Cells[1].Value = pais.Continente;
                    dgvPaises.Rows[n].Cells[2].Value = pais.PoblacionTotal;
                    dgvPaises.Rows[n].Cells[3].Value = pais.Infectados;
                    dgvPaises.Rows[n].Cells[4].Value = pais.Fallecidos;
                    dgvPaises.Rows[n].Cells[5].Value = pais.Vacunados;

                }
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {



            Xml.Serializar(mundo.ListaPaises, "ListaDePaises");
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            mundo = new Mundo();
            mundo.ListaPaises = Xml.Deserializar<List<Pais>>();
            ActualizarDatosForm();
        }

        private void ActualizarDatosForm()
        {
            LlenarGrilla();
            ActualizarLabelCantPaises();
            ActualizarBotones();
        }

        private void ActualizarLabelCantPaises()
        {
            if (!(mundo is null))
            {
                cantPaises = mundo.ListaPaises.Count();
                this.lblCantPaises.Text = $"Cantidad de Paises: {cantPaises}";
            }
        }

        private void IniciarForm()
        {
            if (InvokeRequired)
            {
                Thread.Sleep(6000);
                delegadoIniciarForm = IniciarForm;
                Invoke(delegadoIniciarForm);
            }
            else
            {
                this.lblCargandoGrilla.Text = "";
                this.dgvPaises.Show();
                ActualizarDatosForm();
            }

        }

        private void ActualizarBotones()
        {
            if (cantPaises > 0)
            {
                btnInformes.Enabled = true;
            }
        }

        private void btnBorraPais_Click(object sender, EventArgs e)
        {

            if (mundo.EliminarPais(nombrePais))
            {
                MessageBox.Show($"Se elimino a {nombrePais} de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Debe seleccionar un pais", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDatosForm();
        }

        private void dgvPaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nombrePais = dgvPaises.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            lblDatosPorContinente formInformes = new lblDatosPorContinente(mundo);
            formInformes.ShowDialog();
        }

        private void btnExpDB_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionDB.Insertar(mundo.ListaPaises);
            }
            catch (SqlException)
            {
                MessageBox.Show("Se produjo un error al exportar a la Base de Datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImpDB_Click(object sender, EventArgs e)
        {
            try
            {
                mundo.ListaPaises = ConexionDB.TraerDatos();
                ActualizarDatosForm();
            }
            catch (SqlException)
            {
                MessageBox.Show("Se produjo un error al importar de la Base de Datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeshabilitarBotonInformes()
        {
            btnInformes.Enabled = false;
        }

        private void BorrarDatosGrilla()
        {
            dgvPaises.Rows.Clear();
        }
    }
}
