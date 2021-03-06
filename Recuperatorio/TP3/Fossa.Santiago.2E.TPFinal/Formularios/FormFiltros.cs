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
    public partial class FormFiltros : Form
    {
        Mundo mundo;
        string nombreArchivo;

        public FormFiltros(string nombreTitulo, string nombreArchivo, Mundo mundo)
        {
            InitializeComponent();
            this.mundo = mundo;
            this.nombreArchivo = nombreArchivo;
            lblTituloFiltro.Text = nombreTitulo;
            LlenarGrilla();
        }

        /// <summary>
        /// Llena DataGridView dgvPaises con mundo.ListaPaises
        /// </summary>
        private void LlenarGrilla()
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
                dgvPaises.Rows[n].Cells[6].Value = pais.PorcentajeInfectados();
                dgvPaises.Rows[n].Cells[7].Value = pais.PorcentajeFallecidos();
                dgvPaises.Rows[n].Cells[8].Value = pais.PorcentajeVacunados();

            }

        }

        private void btnExpJson_Click(object sender, EventArgs e)
        {
            try
            {
                Json.Serializar(mundo.ListaPaises, nombreArchivo);
                MessageBox.Show("Se exporto a Json con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("No se encontro el directorio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("Error al exportar el archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
