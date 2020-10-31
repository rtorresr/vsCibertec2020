namespace Chinook.Desktop
{
    partial class Genre
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LbCant = new System.Windows.Forms.Label();
            this.DgvListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(62, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LbCant
            // 
            this.LbCant.AutoSize = true;
            this.LbCant.Location = new System.Drawing.Point(230, 26);
            this.LbCant.Name = "LbCant";
            this.LbCant.Size = new System.Drawing.Size(0, 13);
            this.LbCant.TabIndex = 1;
            this.LbCant.Click += new System.EventHandler(this.label1_Click);
            // 
            // DgvListar
            // 
            this.DgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListar.Location = new System.Drawing.Point(62, 64);
            this.DgvListar.Name = "DgvListar";
            this.DgvListar.Size = new System.Drawing.Size(370, 207);
            this.DgvListar.TabIndex = 2;
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvListar);
            this.Controls.Add(this.LbCant);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Genre";
            this.Text = "Genre";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LbCant;
        private System.Windows.Forms.DataGridView DgvListar;
    }
}