
namespace Formularios
{
    partial class FormAltaPais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.txtPoblacionTotal = new System.Windows.Forms.TextBox();
            this.txtInfectados = new System.Windows.Forms.TextBox();
            this.txtFallecidos = new System.Windows.Forms.TextBox();
            this.txtVacunados = new System.Windows.Forms.TextBox();
            this.cmbContinente = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVacunadosError = new System.Windows.Forms.Label();
            this.lblFallecidosError = new System.Windows.Forms.Label();
            this.lblInfectadosError = new System.Windows.Forms.Label();
            this.lblPoblacionError = new System.Windows.Forms.Label();
            this.lblNombreError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Continente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poblacion Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Infectadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad Fallecidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad Vacunados";
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(53, 51);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(185, 23);
            this.txtNombrePais.TabIndex = 6;
            this.txtNombrePais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePais_KeyPress);
            // 
            // txtPoblacionTotal
            // 
            this.txtPoblacionTotal.Location = new System.Drawing.Point(51, 196);
            this.txtPoblacionTotal.Name = "txtPoblacionTotal";
            this.txtPoblacionTotal.Size = new System.Drawing.Size(185, 23);
            this.txtPoblacionTotal.TabIndex = 7;
            this.txtPoblacionTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoblacionTotal_KeyPress);
            // 
            // txtInfectados
            // 
            this.txtInfectados.Location = new System.Drawing.Point(53, 269);
            this.txtInfectados.Name = "txtInfectados";
            this.txtInfectados.Size = new System.Drawing.Size(185, 23);
            this.txtInfectados.TabIndex = 8;
            this.txtInfectados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfectados_KeyPress);
            // 
            // txtFallecidos
            // 
            this.txtFallecidos.Location = new System.Drawing.Point(51, 339);
            this.txtFallecidos.Name = "txtFallecidos";
            this.txtFallecidos.Size = new System.Drawing.Size(185, 23);
            this.txtFallecidos.TabIndex = 9;
            this.txtFallecidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFallecidos_KeyPress);
            // 
            // txtVacunados
            // 
            this.txtVacunados.Location = new System.Drawing.Point(51, 411);
            this.txtVacunados.Name = "txtVacunados";
            this.txtVacunados.Size = new System.Drawing.Size(185, 23);
            this.txtVacunados.TabIndex = 10;
            this.txtVacunados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVacunados_KeyPress);
            // 
            // cmbContinente
            // 
            this.cmbContinente.FormattingEnabled = true;
            this.cmbContinente.Location = new System.Drawing.Point(53, 126);
            this.cmbContinente.Name = "cmbContinente";
            this.cmbContinente.Size = new System.Drawing.Size(185, 23);
            this.cmbContinente.TabIndex = 11;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Black;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlta.Location = new System.Drawing.Point(21, 473);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(97, 36);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(162, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVacunadosError
            // 
            this.lblVacunadosError.AutoSize = true;
            this.lblVacunadosError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVacunadosError.ForeColor = System.Drawing.Color.Red;
            this.lblVacunadosError.Location = new System.Drawing.Point(51, 437);
            this.lblVacunadosError.Name = "lblVacunadosError";
            this.lblVacunadosError.Size = new System.Drawing.Size(0, 15);
            this.lblVacunadosError.TabIndex = 14;
            // 
            // lblFallecidosError
            // 
            this.lblFallecidosError.AutoSize = true;
            this.lblFallecidosError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFallecidosError.ForeColor = System.Drawing.Color.Red;
            this.lblFallecidosError.Location = new System.Drawing.Point(51, 365);
            this.lblFallecidosError.Name = "lblFallecidosError";
            this.lblFallecidosError.Size = new System.Drawing.Size(0, 15);
            this.lblFallecidosError.TabIndex = 15;
            // 
            // lblInfectadosError
            // 
            this.lblInfectadosError.AutoSize = true;
            this.lblInfectadosError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfectadosError.ForeColor = System.Drawing.Color.Red;
            this.lblInfectadosError.Location = new System.Drawing.Point(53, 295);
            this.lblInfectadosError.Name = "lblInfectadosError";
            this.lblInfectadosError.Size = new System.Drawing.Size(0, 15);
            this.lblInfectadosError.TabIndex = 16;
            // 
            // lblPoblacionError
            // 
            this.lblPoblacionError.AutoSize = true;
            this.lblPoblacionError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoblacionError.ForeColor = System.Drawing.Color.Red;
            this.lblPoblacionError.Location = new System.Drawing.Point(53, 222);
            this.lblPoblacionError.Name = "lblPoblacionError";
            this.lblPoblacionError.Size = new System.Drawing.Size(0, 15);
            this.lblPoblacionError.TabIndex = 17;
            // 
            // lblNombreError
            // 
            this.lblNombreError.AutoSize = true;
            this.lblNombreError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreError.ForeColor = System.Drawing.Color.Red;
            this.lblNombreError.Location = new System.Drawing.Point(53, 77);
            this.lblNombreError.Name = "lblNombreError";
            this.lblNombreError.Size = new System.Drawing.Size(0, 15);
            this.lblNombreError.TabIndex = 19;
            // 
            // FormAltaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(300, 530);
            this.Controls.Add(this.lblNombreError);
            this.Controls.Add(this.lblPoblacionError);
            this.Controls.Add(this.lblInfectadosError);
            this.Controls.Add(this.lblFallecidosError);
            this.Controls.Add(this.lblVacunadosError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.cmbContinente);
            this.Controls.Add(this.txtVacunados);
            this.Controls.Add(this.txtFallecidos);
            this.Controls.Add(this.txtInfectados);
            this.Controls.Add(this.txtPoblacionTotal);
            this.Controls.Add(this.txtNombrePais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaPais";
            this.Text = "ALTA DE PAIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.TextBox txtPoblacionTotal;
        private System.Windows.Forms.TextBox txtInfectados;
        private System.Windows.Forms.TextBox txtFallecidos;
        private System.Windows.Forms.TextBox txtVacunados;
        private System.Windows.Forms.ComboBox cmbContinente;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVacunadosError;
        private System.Windows.Forms.Label lblFallecidosError;
        private System.Windows.Forms.Label lblInfectadosError;
        private System.Windows.Forms.Label lblPoblacionError;
        private System.Windows.Forms.Label lblNombreError;
    }
}