
namespace Formularios
{
    partial class lblDatosPorContinente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInforme = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallecidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacunados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeInfectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeVacunados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfectadosPorCont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDatosPorCont = new System.Windows.Forms.Label();
            this.cmbContinentes = new System.Windows.Forms.ComboBox();
            this.btnVerDatosContinente = new System.Windows.Forms.Button();
            this.btnDiezMasCantInfectados = new System.Windows.Forms.Button();
            this.btnDiezMasCantFallecidos = new System.Windows.Forms.Button();
            this.btnDiezMenosPorcFallecidos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbContinenteFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrarContinente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInforme
            // 
            this.dgvInforme.AllowUserToAddRows = false;
            this.dgvInforme.AllowUserToDeleteRows = false;
            this.dgvInforme.AllowUserToResizeColumns = false;
            this.dgvInforme.AllowUserToResizeRows = false;
            this.dgvInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.continente,
            this.poblacionTotal,
            this.infectados,
            this.fallecidos,
            this.vacunados,
            this.porcentajeInfectados,
            this.porcentajeVacunados});
            this.dgvInforme.Location = new System.Drawing.Point(261, 269);
            this.dgvInforme.MultiSelect = false;
            this.dgvInforme.Name = "dgvInforme";
            this.dgvInforme.ReadOnly = true;
            this.dgvInforme.RowHeadersVisible = false;
            this.dgvInforme.RowTemplate.Height = 25;
            this.dgvInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforme.Size = new System.Drawing.Size(858, 431);
            this.dgvInforme.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // continente
            // 
            this.continente.HeaderText = "Continente";
            this.continente.Name = "continente";
            this.continente.ReadOnly = true;
            // 
            // poblacionTotal
            // 
            this.poblacionTotal.HeaderText = "Poblacion Total";
            this.poblacionTotal.Name = "poblacionTotal";
            this.poblacionTotal.ReadOnly = true;
            // 
            // infectados
            // 
            this.infectados.HeaderText = "Cant. Infectados";
            this.infectados.Name = "infectados";
            this.infectados.ReadOnly = true;
            // 
            // fallecidos
            // 
            this.fallecidos.HeaderText = "Cant. Fallecidos";
            this.fallecidos.Name = "fallecidos";
            this.fallecidos.ReadOnly = true;
            // 
            // vacunados
            // 
            this.vacunados.HeaderText = "Cant. Vacunados";
            this.vacunados.Name = "vacunados";
            this.vacunados.ReadOnly = true;
            // 
            // porcentajeInfectados
            // 
            this.porcentajeInfectados.HeaderText = "% Infectados";
            this.porcentajeInfectados.Name = "porcentajeInfectados";
            this.porcentajeInfectados.ReadOnly = true;
            // 
            // porcentajeVacunados
            // 
            this.porcentajeVacunados.HeaderText = "% Vacunados";
            this.porcentajeVacunados.Name = "porcentajeVacunados";
            this.porcentajeVacunados.ReadOnly = true;
            this.porcentajeVacunados.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Mundiales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(466, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total de Infectados por continente:";
            // 
            // lblInfectadosPorCont
            // 
            this.lblInfectadosPorCont.AutoSize = true;
            this.lblInfectadosPorCont.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfectadosPorCont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfectadosPorCont.Location = new System.Drawing.Point(466, 79);
            this.lblInfectadosPorCont.Name = "lblInfectadosPorCont";
            this.lblInfectadosPorCont.Size = new System.Drawing.Size(51, 20);
            this.lblInfectadosPorCont.TabIndex = 6;
            this.lblInfectadosPorCont.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(808, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datos por continente:";
            // 
            // lblDatosPorCont
            // 
            this.lblDatosPorCont.AutoSize = true;
            this.lblDatosPorCont.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosPorCont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatosPorCont.Location = new System.Drawing.Point(808, 119);
            this.lblDatosPorCont.Name = "lblDatosPorCont";
            this.lblDatosPorCont.Size = new System.Drawing.Size(0, 20);
            this.lblDatosPorCont.TabIndex = 8;
            // 
            // cmbContinentes
            // 
            this.cmbContinentes.FormattingEnabled = true;
            this.cmbContinentes.Location = new System.Drawing.Point(808, 76);
            this.cmbContinentes.Name = "cmbContinentes";
            this.cmbContinentes.Size = new System.Drawing.Size(121, 23);
            this.cmbContinentes.TabIndex = 9;
            // 
            // btnVerDatosContinente
            // 
            this.btnVerDatosContinente.Location = new System.Drawing.Point(949, 76);
            this.btnVerDatosContinente.Name = "btnVerDatosContinente";
            this.btnVerDatosContinente.Size = new System.Drawing.Size(55, 23);
            this.btnVerDatosContinente.TabIndex = 10;
            this.btnVerDatosContinente.Text = "Ver";
            this.btnVerDatosContinente.UseVisualStyleBackColor = true;
            this.btnVerDatosContinente.Click += new System.EventHandler(this.btnVerDatosContinente_Click);
            // 
            // btnDiezMasCantInfectados
            // 
            this.btnDiezMasCantInfectados.BackColor = System.Drawing.Color.Black;
            this.btnDiezMasCantInfectados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiezMasCantInfectados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiezMasCantInfectados.Location = new System.Drawing.Point(12, 308);
            this.btnDiezMasCantInfectados.Name = "btnDiezMasCantInfectados";
            this.btnDiezMasCantInfectados.Size = new System.Drawing.Size(243, 39);
            this.btnDiezMasCantInfectados.TabIndex = 11;
            this.btnDiezMasCantInfectados.Text = "TOP 10 Mas Cantidad Infectados";
            this.btnDiezMasCantInfectados.UseVisualStyleBackColor = false;
            this.btnDiezMasCantInfectados.Click += new System.EventHandler(this.btnDiezMasCantInfectados_Click);
            // 
            // btnDiezMasCantFallecidos
            // 
            this.btnDiezMasCantFallecidos.BackColor = System.Drawing.Color.Black;
            this.btnDiezMasCantFallecidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiezMasCantFallecidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiezMasCantFallecidos.Location = new System.Drawing.Point(12, 365);
            this.btnDiezMasCantFallecidos.Name = "btnDiezMasCantFallecidos";
            this.btnDiezMasCantFallecidos.Size = new System.Drawing.Size(243, 39);
            this.btnDiezMasCantFallecidos.TabIndex = 12;
            this.btnDiezMasCantFallecidos.Text = "TOP 10 Mas Cantidad Fallecidos";
            this.btnDiezMasCantFallecidos.UseVisualStyleBackColor = false;
            this.btnDiezMasCantFallecidos.Click += new System.EventHandler(this.btnDiezMasCantFallecidos_Click);
            // 
            // btnDiezMenosPorcFallecidos
            // 
            this.btnDiezMenosPorcFallecidos.BackColor = System.Drawing.Color.Black;
            this.btnDiezMenosPorcFallecidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiezMenosPorcFallecidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiezMenosPorcFallecidos.Location = new System.Drawing.Point(12, 421);
            this.btnDiezMenosPorcFallecidos.Name = "btnDiezMenosPorcFallecidos";
            this.btnDiezMenosPorcFallecidos.Size = new System.Drawing.Size(243, 39);
            this.btnDiezMenosPorcFallecidos.TabIndex = 13;
            this.btnDiezMenosPorcFallecidos.Text = "TOP 10 Menos Porcentaje Fallecidos";
            this.btnDiezMenosPorcFallecidos.UseVisualStyleBackColor = false;
            this.btnDiezMenosPorcFallecidos.Click += new System.EventHandler(this.btnDiezMenosPorcFallecidos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Continente";
            // 
            // cmbContinenteFiltro
            // 
            this.cmbContinenteFiltro.FormattingEnabled = true;
            this.cmbContinenteFiltro.Location = new System.Drawing.Point(12, 502);
            this.cmbContinenteFiltro.Name = "cmbContinenteFiltro";
            this.cmbContinenteFiltro.Size = new System.Drawing.Size(121, 23);
            this.cmbContinenteFiltro.TabIndex = 15;
            // 
            // btnFiltrarContinente
            // 
            this.btnFiltrarContinente.BackColor = System.Drawing.Color.Black;
            this.btnFiltrarContinente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarContinente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrarContinente.Location = new System.Drawing.Point(139, 496);
            this.btnFiltrarContinente.Name = "btnFiltrarContinente";
            this.btnFiltrarContinente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFiltrarContinente.Size = new System.Drawing.Size(116, 29);
            this.btnFiltrarContinente.TabIndex = 16;
            this.btnFiltrarContinente.Text = "Filtrar";
            this.btnFiltrarContinente.UseVisualStyleBackColor = false;
            this.btnFiltrarContinente.Click += new System.EventHandler(this.btnFiltrarContinente_Click);
            // 
            // lblDatosPorContinente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1131, 712);
            this.Controls.Add(this.btnFiltrarContinente);
            this.Controls.Add(this.cmbContinenteFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiezMenosPorcFallecidos);
            this.Controls.Add(this.btnDiezMasCantFallecidos);
            this.Controls.Add(this.btnDiezMasCantInfectados);
            this.Controls.Add(this.btnVerDatosContinente);
            this.Controls.Add(this.cmbContinentes);
            this.Controls.Add(this.lblDatosPorCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfectadosPorCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "lblDatosPorContinente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORMES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn infectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallecidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacunados;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeInfectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeVacunados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfectadosPorCont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatosPorCont;
        private System.Windows.Forms.ComboBox cmbContinentes;
        private System.Windows.Forms.Button btnVerDatosContinente;
        private System.Windows.Forms.Button btnDiezMasCantInfectados;
        private System.Windows.Forms.Button btnDiezMasCantFallecidos;
        private System.Windows.Forms.Button btnDiezMenosPorcFallecidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbContinenteFiltro;
        private System.Windows.Forms.Button btnFiltrarContinente;
    }
}