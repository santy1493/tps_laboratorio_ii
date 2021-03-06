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
        static string nombrePais;
        DelegadoIniciarForm delegadoIniciarForm;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            mundo = new Mundo();
            ImportarBBDD();
            btnImpDB.Enabled = false;
            btnInformes.Enabled = false;
            dgvPaises.Enabled = false;
            dgvPaises.Hide();
            Task iniciarForm = Task.Run(() => IniciarForm());
            this.mundo.paisBorrado += DeshabilitarBotonInformes;
            this.mundo.paisBorrado += BorrarDatosGrilla;

        }


        /// <summary>
        /// Abre el form para Cargar un pais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaPais_Click(object sender, EventArgs e)
        {

            FormAltaPais formAltaPais = new FormAltaPais(mundo);
            formAltaPais.ShowDialog();
            ActualizarDatosForm();

        }

        /// <summary>
        /// Llena el dgvPaises con los paises de mundo.ListaPaises
        /// </summary>
        private void LlenarGrilla()
        {
            if (mundo.ListaPaises.Count > 0)
            {
                dgvPaises.Enabled = true;

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

        /// <summary>
        /// Llama al metodo serializar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {

            try
            {
                Xml.Serializar(mundo.ListaPaises, "ListaDePaises");
                MessageBox.Show($"Se exporto el archivo con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show($"No se encontro el directorio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Llama al metodo deserializar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                mundo.ListaPaises = Xml.Deserializar<List<Pais>>();
                ActualizarDatosForm();
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show($"No se encontro el directorio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show($"No se encontro el archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show($"No se pudo importar el archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Llama a los metodos LLenarGrilla, ActualizarLabelCantPaises y ActualizarBotones
        /// </summary>
        private void ActualizarDatosForm()
        {
            LlenarGrilla();
            ActualizarLabelCantPaises();
            ActualizarBotones();
        }

        /// <summary>
        /// Actualiza el lblCantPaises con la cantidad actual de paises en mundo.ListaPaises
        /// </summary>
        private void ActualizarLabelCantPaises()
        {
            if (!(mundo is null) && mundo.ListaPaises.Count>0)
            {
                this.lblCantPaises.Text = $"Cantidad de Paises: {mundo.ListaPaises.Count}";
            }
            else
            {
                this.lblCantPaises.Text = string.Empty;
            }

        }


        private void IniciarForm()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Thread.Sleep(6000);
                    delegadoIniciarForm = IniciarForm;
                    Invoke(delegadoIniciarForm);
                }
                else
                {
                    this.btnImpDB.Enabled = true;
                    this.lblCargandoGrilla.Text = "";
                    this.dgvPaises.Show();
                    ActualizarDatosForm();
                }
            }
            catch(InvalidOperationException)
            {
                IniciarForm();
            }

        }


        /// <summary>
        /// Si la cantidad de paises en mundo.ListaPaises en mayor a 0 habilita el boton de informes
        /// </summary>
        private void ActualizarBotones()
        {
            if (mundo.ListaPaises.Count > 0)
            {
                btnInformes.Enabled = true;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Guarda el nombre de pais de la fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nombrePais = dgvPaises.CurrentRow.Cells[0].Value.ToString();

        }

        /// <summary>
        /// Abre el form de informes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformes_Click(object sender, EventArgs e)
        {
            FormInformes formInformes = new FormInformes(mundo);
            formInformes.ShowDialog();
        }

        /// <summary>
        /// Exporta a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpDB_Click(object sender, EventArgs e)
        {
            if(mundo.ListaPaises.Count>0)
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
            else
            {
                MessageBox.Show("No se puede exportar, la lista esta vacia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// Importa desde la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImpDB_Click(object sender, EventArgs e)
        {
            ImportarBBDD();
            ActualizarDatosForm();
        }

        private void ImportarBBDD()
        {
            try
            {
                mundo.ListaPaises = ConexionDB.TraerDatos();
            }
            catch (SqlException)
            {
                MessageBox.Show("Se produjo un error al importar de la Base de Datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Deshabilita el boton de informes
        /// </summary>
        private void DeshabilitarBotonInformes()
        {
            btnInformes.Enabled = false;
        }


        /// <summary>
        /// Limpia la grilla de paises
        /// </summary>
        private void BorrarDatosGrilla()
        {
            dgvPaises.Rows.Clear();
            dgvPaises.Enabled = false;
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (mundo.BorrarLista())
                {
                    MessageBox.Show("Se borro la lista con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La lista no contiene ningun pais", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ActualizarDatosForm();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Se produjo un error al borrar la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
