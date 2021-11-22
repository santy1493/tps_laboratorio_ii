
namespace Formularios
{
    partial class FormFiltros
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
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallecidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacunados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcInfectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcFallecidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcVacunados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloFiltro = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnExpJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToResizeColumns = false;
            this.dgvPaises.AllowUserToResizeRows = false;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.continente,
            this.poblacion,
            this.infectados,
            this.fallecidos,
            this.vacunados,
            this.porcInfectados,
            this.porcFallecidos,
            this.porcVacunados});
            this.dgvPaises.Location = new System.Drawing.Point(12, 65);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.RowTemplate.Height = 25;
            this.dgvPaises.Size = new System.Drawing.Size(943, 388);
            this.dgvPaises.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // continente
            // 
            this.continente.HeaderText = "Continente";
            this.continente.Name = "continente";
            // 
            // poblacion
            // 
            this.poblacion.HeaderText = "Poblacion Total";
            this.poblacion.Name = "poblacion";
            // 
            // infectados
            // 
            this.infectados.HeaderText = "Cant. Infectados";
            this.infectados.Name = "infectados";
            // 
            // fallecidos
            // 
            this.fallecidos.HeaderText = "Cant. Fallecidos";
            this.fallecidos.Name = "fallecidos";
            // 
            // vacunados
            // 
            this.vacunados.HeaderText = "Cant. Vacunados";
            this.vacunados.Name = "vacunados";
            // 
            // porcInfectados
            // 
            this.porcInfectados.HeaderText = "% Infectados";
            this.porcInfectados.Name = "porcInfectados";
            // 
            // porcFallecidos
            // 
            this.porcFallecidos.HeaderText = "% Fallecidos";
            this.porcFallecidos.Name = "porcFallecidos";
            // 
            // porcVacunados
            // 
            this.porcVacunados.HeaderText = "% Vacunados";
            this.porcVacunados.Name = "porcVacunados";
            // 
            // lblTituloFiltro
            // 
            this.lblTituloFiltro.AutoSize = true;
            this.lblTituloFiltro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloFiltro.Location = new System.Drawing.Point(13, 13);
            this.lblTituloFiltro.Name = "lblTituloFiltro";
            this.lblTituloFiltro.Size = new System.Drawing.Size(83, 32);
            this.lblTituloFiltro.TabIndex = 1;
            this.lblTituloFiltro.Text = "label1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(810, 490);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnExpJson
            // 
            this.btnExpJson.BackColor = System.Drawing.Color.Black;
            this.btnExpJson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpJson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpJson.Location = new System.Drawing.Point(658, 490);
            this.btnExpJson.Name = "btnExpJson";
            this.btnExpJson.Size = new System.Drawing.Size(145, 31);
            this.btnExpJson.TabIndex = 3;
            this.btnExpJson.Text = "Exportar a Json";
            this.btnExpJson.UseVisualStyleBackColor = false;
            this.btnExpJson.Click += new System.EventHandler(this.btnExpJson_Click);
            // 
            // FormFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(966, 559);
            this.Controls.Add(this.btnExpJson);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTituloFiltro);
            this.Controls.Add(this.dgvPaises);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormFiltros";
            this.Text = "FILTROS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn infectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallecidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacunados;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcInfectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcFallecidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcVacunados;
        private System.Windows.Forms.Label lblTituloFiltro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnExpJson;
    }
}