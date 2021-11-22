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
    public partial class lblDatosPorContinente : Form
    {
        Mundo mundo;

        public lblDatosPorContinente()
        {
            InitializeComponent();
        }

        public lblDatosPorContinente(Mundo mundo1)
            :this()
        {
            
            this.mundo = mundo1;
            LlenarGrilla();
            EstadisticasMundo();
            PorcentajeTotalInfectadosPorContinente();
            cmbContinentes.DataSource = Enum.GetValues(typeof(EContinente));
            cmbContinenteFiltro.DataSource = Enum.GetValues(typeof(EContinente));
        }

        private void LlenarGrilla()
        {
            dgvInforme.Rows.Clear();

            int n;

            foreach (Pais pais in mundo.ListaPaises)
            {
                n = dgvInforme.Rows.Add();

                dgvInforme.Rows[n].Cells[0].Value = pais.Nombre;
                dgvInforme.Rows[n].Cells[1].Value = pais.Continente;
                dgvInforme.Rows[n].Cells[2].Value = pais.PoblacionTotal;
                dgvInforme.Rows[n].Cells[3].Value = pais.Infectados;
                dgvInforme.Rows[n].Cells[4].Value = pais.Fallecidos;
                dgvInforme.Rows[n].Cells[5].Value = pais.Vacunados;
                dgvInforme.Rows[n].Cells[6].Value = pais.PorcentajeInfectados();
                dgvInforme.Rows[n].Cells[7].Value = pais.PorcentajeVacunados();

            }

        }

        private void EstadisticasMundo()
        {
            this.label1.Text = mundo.MostrarEstadisticasMundo();
        }

        private void PorcentajeTotalInfectadosPorContinente()
        {
            lblInfectadosPorCont.Text = mundo.PorcentajeInfectadosContinente();
        }

        private void btnVerDatosContinente_Click(object sender, EventArgs e)
        {
            lblDatosPorCont.Text = mundo.ImprimirDatosPorContinente(cmbContinentes.Text);
        }

        private void btnDiezMasCantInfectados_Click(object sender, EventArgs e)
        {
            Mundo mundoFiltrado = new Mundo();
            mundoFiltrado.ListaPaises = mundo.FiltrarDiezMasCantidadInfectados();
            FormFiltros formFiltros = new FormFiltros("TOP 10 Mas Cantidad Infectados", "10MasCantInfectados", mundoFiltrado);
            formFiltros.ShowDialog();
        }

        private void btnDiezMasCantFallecidos_Click(object sender, EventArgs e)
        {
            Mundo mundoFiltrado = new Mundo();
            mundoFiltrado.ListaPaises = mundo.FiltrarDiezMasCantidadFallecidos();
            FormFiltros formFiltros = new FormFiltros("TOP 10 Mas Cantidad Fallecidos", "10MasCantFallecidos", mundoFiltrado);
            formFiltros.ShowDialog();
        }

        private void btnDiezMenosPorcFallecidos_Click(object sender, EventArgs e)
        {
            Mundo mundoFiltrado = new Mundo();
            mundoFiltrado.ListaPaises = mundo.FiltrarDiezMenosPorcentajeFallecidos();
            FormFiltros formFiltros = new FormFiltros("TOP 10 Menos Porcentaje Fallecidos", "10MenosPorcFallecidos", mundoFiltrado);
            formFiltros.ShowDialog();
        }

        private void btnFiltrarContinente_Click(object sender, EventArgs e)
        {
            Mundo mundoFiltrado = new Mundo();
            mundoFiltrado.ListaPaises = mundo.FiltrarPorContinente(cmbContinenteFiltro.Text);
            FormFiltros formFiltros = new FormFiltros($"Paises de {cmbContinenteFiltro.Text}", $"PaisesDe{cmbContinenteFiltro.Text}", mundoFiltrado);
            formFiltros.ShowDialog();
        }
    }
}
