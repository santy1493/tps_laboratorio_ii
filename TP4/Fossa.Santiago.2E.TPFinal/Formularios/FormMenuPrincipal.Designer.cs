
namespace Formularios
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaPais = new System.Windows.Forms.Button();
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallecidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacunados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnBorraPais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantPaises = new System.Windows.Forms.Label();
            this.btnExpDB = new System.Windows.Forms.Button();
            this.btnImpDB = new System.Windows.Forms.Button();
            this.lblCargandoGrilla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaPais
            // 
            this.btnAltaPais.BackColor = System.Drawing.Color.Black;
            this.btnAltaPais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltaPais.Location = new System.Drawing.Point(31, 213);
            this.btnAltaPais.Name = "btnAltaPais";
            this.btnAltaPais.Size = new System.Drawing.Size(168, 40);
            this.btnAltaPais.TabIndex = 0;
            this.btnAltaPais.Text = "Cargar Pais";
            this.btnAltaPais.UseVisualStyleBackColor = false;
            this.btnAltaPais.Click += new System.EventHandler(this.btnAltaPais_Click);
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToResizeColumns = false;
            this.dgvPaises.AllowUserToResizeRows = false;
            this.dgvPaises.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.continente,
            this.poblacionTotal,
            this.infectados,
            this.fallecidos,
            this.vacunados});
            this.dgvPaises.Location = new System.Drawing.Point(244, 80);
            this.dgvPaises.MultiSelect = false;
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.ReadOnly = true;
            this.dgvPaises.RowHeadersVisible = false;
            this.dgvPaises.RowTemplate.Height = 25;
            this.dgvPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaises.Size = new System.Drawing.Size(648, 408);
            this.dgvPaises.TabIndex = 1;
            this.dgvPaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre de Pais";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 145;
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
            this.infectados.HeaderText = "Cantidad Infectados";
            this.infectados.Name = "infectados";
            this.infectados.ReadOnly = true;
            // 
            // fallecidos
            // 
            this.fallecidos.HeaderText = "Cantiadad Fallecidos";
            this.fallecidos.Name = "fallecidos";
            this.fallecidos.ReadOnly = true;
            // 
            // vacunados
            // 
            this.vacunados.HeaderText = "Cantidad Vacunados";
            this.vacunados.Name = "vacunados";
            this.vacunados.ReadOnly = true;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Black;
            this.btnInformes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformes.Location = new System.Drawing.Point(31, 349);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(168, 42);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(61, 184);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(110, 23);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "ExportarXML";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Black;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportar.Location = new System.Drawing.Point(31, 423);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(168, 39);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar XML";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnBorraPais
            // 
            this.btnBorraPais.BackColor = System.Drawing.Color.Black;
            this.btnBorraPais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorraPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorraPais.Location = new System.Drawing.Point(31, 279);
            this.btnBorraPais.Name = "btnBorraPais";
            this.btnBorraPais.Size = new System.Drawing.Size(168, 40);
            this.btnBorraPais.TabIndex = 5;
            this.btnBorraPais.Text = "Borrar Pais";
            this.btnBorraPais.UseVisualStyleBackColor = false;
            this.btnBorraPais.Click += new System.EventHandler(this.btnBorraPais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "COVID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "STATS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(463, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de Paises";
            // 
            // lblCantPaises
            // 
            this.lblCantPaises.AutoSize = true;
            this.lblCantPaises.BackColor = System.Drawing.Color.Gold;
            this.lblCantPaises.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantPaises.Location = new System.Drawing.Point(742, 60);
            this.lblCantPaises.Name = "lblCantPaises";
            this.lblCantPaises.Size = new System.Drawing.Size(45, 17);
            this.lblCantPaises.TabIndex = 9;
            this.lblCantPaises.Text = "label4";
            // 
            // btnExpDB
            // 
            this.btnExpDB.Location = new System.Drawing.Point(742, 13);
            this.btnExpDB.Name = "btnExpDB";
            this.btnExpDB.Size = new System.Drawing.Size(150, 23);
            this.btnExpDB.TabIndex = 10;
            this.btnExpDB.Text = "Exp DB";
            this.btnExpDB.UseVisualStyleBackColor = true;
            this.btnExpDB.Click += new System.EventHandler(this.btnExpDB_Click);
            // 
            // btnImpDB
            // 
            this.btnImpDB.Location = new System.Drawing.Point(244, 12);
            this.btnImpDB.Name = "btnImpDB";
            this.btnImpDB.Size = new System.Drawing.Size(155, 23);
            this.btnImpDB.TabIndex = 11;
            this.btnImpDB.Text = "imp DB";
            this.btnImpDB.UseVisualStyleBackColor = true;
            this.btnImpDB.Click += new System.EventHandler(this.btnImpDB_Click);
            // 
            // lblCargandoGrilla
            // 
            this.lblCargandoGrilla.AutoSize = true;
            this.lblCargandoGrilla.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargandoGrilla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargandoGrilla.Location = new System.Drawing.Point(417, 174);
            this.lblCargandoGrilla.Name = "lblCargandoGrilla";
            this.lblCargandoGrilla.Size = new System.Drawing.Size(312, 32);
            this.lblCargandoGrilla.TabIndex = 12;
            this.lblCargandoGrilla.Text = "Cargando lista de paises...";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(916, 500);
            this.Controls.Add(this.lblCargandoGrilla);
            this.Controls.Add(this.btnImpDB);
            this.Controls.Add(this.btnExpDB);
            this.Controls.Add(this.lblCantPaises);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorraPais);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.dgvPaises);
            this.Controls.Add(this.btnAltaPais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaPais;
        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnBorraPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn infectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallecidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacunados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantPaises;
        private System.Windows.Forms.Button btnExpDB;
        private System.Windows.Forms.Button btnImpDB;
        private System.Windows.Forms.Label lblCargandoGrilla;
    }
}

