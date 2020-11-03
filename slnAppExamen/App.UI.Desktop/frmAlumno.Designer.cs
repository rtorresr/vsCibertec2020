namespace App.UI.Desktop
{
    partial class frmAlumno
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
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dvgListado = new System.Windows.Forms.DataGridView();
            this.btnConsultarEF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(22, 51);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(560, 20);
            this.tbFiltro.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(588, 51);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(91, 23);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consulta ADO";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dvgListado
            // 
            this.dvgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListado.Location = new System.Drawing.Point(22, 91);
            this.dvgListado.Name = "dvgListado";
            this.dvgListado.Size = new System.Drawing.Size(751, 285);
            this.dvgListado.TabIndex = 3;
            // 
            // btnConsultarEF
            // 
            this.btnConsultarEF.Location = new System.Drawing.Point(683, 51);
            this.btnConsultarEF.Name = "btnConsultarEF";
            this.btnConsultarEF.Size = new System.Drawing.Size(90, 23);
            this.btnConsultarEF.TabIndex = 4;
            this.btnConsultarEF.Text = "ConsultaEF";
            this.btnConsultarEF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConsultarEF.UseVisualStyleBackColor = true;
            this.btnConsultarEF.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnConsultarEF);
            this.Controls.Add(this.dvgListado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.tbFiltro);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dvgListado;
        private System.Windows.Forms.Button btnConsultarEF;
    }
}