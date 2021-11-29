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
    public partial class FormCompararPaises : Form
    {
        Mundo mundo;
        List<string> nombreCmbPaisUno;
        List<string> nombreCmbPaisDos;

        public FormCompararPaises(Mundo mundo)
        {
            InitializeComponent();
            this.mundo = mundo;
            nombreCmbPaisUno = ArrayDePaises();
            nombreCmbPaisDos = ArrayDePaises();
            cmbPaisUno.DataSource = nombreCmbPaisUno;
            cmbPaisDos.DataSource = nombreCmbPaisDos;
            ConfigurarLabelDatos();
        }

        private void ConfigurarLabelDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INFECTADOS (por mill.):\n\n\n");
            sb.AppendLine("FALLECIDOS (por mill.):\n\n\n");
            sb.AppendLine("VACUNADOS (por mill.):");

            this.lblDatos.Text = sb.ToString();
        }

        private List<string> ArrayDePaises()
        {
            List<string> nombreDePaises = new List<string>();

            foreach(Pais p in mundo.ListaPaises)
            {
                nombreDePaises.Add(p.Nombre);
            }

            return nombreDePaises;
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if(cmbPaisUno.Text != cmbPaisDos.Text)
            {
                this.lblPaisUno.Text = mundo.MostrarPorMillonPaises(cmbPaisUno.Text);
                this.lblPaisDos.Text = mundo.MostrarPorMillonPaises(cmbPaisDos.Text);
                this.lblPorcentajePaisUno.Text = mundo.CompararPaisesPorMillon(cmbPaisDos.Text, cmbPaisUno.Text);
                this.lblPorcentajePaisDos.Text = mundo.CompararPaisesPorMillon(cmbPaisUno.Text, cmbPaisDos.Text);
            }
            else
            {
                MessageBox.Show("Debe elegir paises distintos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCompararPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
