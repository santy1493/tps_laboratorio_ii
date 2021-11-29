
namespace Formularios
{
    partial class FormCompararPaises
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
            this.cmbPaisUno = new System.Windows.Forms.ComboBox();
            this.cmbPaisDos = new System.Windows.Forms.ComboBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblPaisUno = new System.Windows.Forms.Label();
            this.lblPaisDos = new System.Windows.Forms.Label();
            this.lblPorcentajePaisDos = new System.Windows.Forms.Label();
            this.lblPorcentajePaisUno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPaisUno
            // 
            this.cmbPaisUno.FormattingEnabled = true;
            this.cmbPaisUno.Location = new System.Drawing.Point(215, 60);
            this.cmbPaisUno.Name = "cmbPaisUno";
            this.cmbPaisUno.Size = new System.Drawing.Size(144, 23);
            this.cmbPaisUno.TabIndex = 0;
            // 
            // cmbPaisDos
            // 
            this.cmbPaisDos.FormattingEnabled = true;
            this.cmbPaisDos.Location = new System.Drawing.Point(544, 60);
            this.cmbPaisDos.Name = "cmbPaisDos";
            this.cmbPaisDos.Size = new System.Drawing.Size(140, 23);
            this.cmbPaisDos.TabIndex = 1;
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComparar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComparar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComparar.Location = new System.Drawing.Point(399, 53);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(116, 32);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatos.Location = new System.Drawing.Point(12, 154);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(60, 17);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "lblDatos";
            // 
            // lblPaisUno
            // 
            this.lblPaisUno.AutoSize = true;
            this.lblPaisUno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaisUno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaisUno.Location = new System.Drawing.Point(215, 106);
            this.lblPaisUno.Name = "lblPaisUno";
            this.lblPaisUno.Size = new System.Drawing.Size(0, 17);
            this.lblPaisUno.TabIndex = 4;
            // 
            // lblPaisDos
            // 
            this.lblPaisDos.AutoSize = true;
            this.lblPaisDos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaisDos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaisDos.Location = new System.Drawing.Point(544, 106);
            this.lblPaisDos.Name = "lblPaisDos";
            this.lblPaisDos.Size = new System.Drawing.Size(0, 17);
            this.lblPaisDos.TabIndex = 5;
            // 
            // lblPorcentajePaisDos
            // 
            this.lblPorcentajePaisDos.AutoSize = true;
            this.lblPorcentajePaisDos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajePaisDos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPorcentajePaisDos.Location = new System.Drawing.Point(644, 154);
            this.lblPorcentajePaisDos.Name = "lblPorcentajePaisDos";
            this.lblPorcentajePaisDos.Size = new System.Drawing.Size(0, 17);
            this.lblPorcentajePaisDos.TabIndex = 6;
            // 
            // lblPorcentajePaisUno
            // 
            this.lblPorcentajePaisUno.AutoSize = true;
            this.lblPorcentajePaisUno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajePaisUno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPorcentajePaisUno.Location = new System.Drawing.Point(319, 154);
            this.lblPorcentajePaisUno.Name = "lblPorcentajePaisUno";
            this.lblPorcentajePaisUno.Size = new System.Drawing.Size(0, 17);
            this.lblPorcentajePaisUno.TabIndex = 7;
            // 
            // FormCompararPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(734, 385);
            this.Controls.Add(this.lblPorcentajePaisUno);
            this.Controls.Add(this.lblPorcentajePaisDos);
            this.Controls.Add(this.lblPaisDos);
            this.Controls.Add(this.lblPaisUno);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.cmbPaisDos);
            this.Controls.Add(this.cmbPaisUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCompararPaises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARAR PAISES";
            this.Load += new System.EventHandler(this.FormCompararPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaisUno;
        private System.Windows.Forms.ComboBox cmbPaisDos;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblPaisUno;
        private System.Windows.Forms.Label lblPaisDos;
        private System.Windows.Forms.Label lblPorcentajePaisDos;
        private System.Windows.Forms.Label lblPorcentajePaisUno;
    }
}