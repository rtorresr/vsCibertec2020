namespace App.UI.Desktop
{
    partial class frmTrack
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
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dvgListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(12, 34);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(573, 20);
            this.tbFiltro.TabIndex = 0;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(726, 37);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(13, 13);
            this.lbCantidad.TabIndex = 1;
            this.lbCantidad.Text = "0";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(601, 32);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(103, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dvgListado
            // 
            this.dvgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListado.Location = new System.Drawing.Point(12, 60);
            this.dvgListado.Name = "dvgListado";
            this.dvgListado.Size = new System.Drawing.Size(776, 335);
            this.dvgListado.TabIndex = 3;
            // 
            // frmTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.dvgListado);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tbFiltro);
            this.Name = "frmTrack";
            this.Text = "frmTrack";
            this.Load += new System.EventHandler(this.frmTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dvgListado;
    }
}