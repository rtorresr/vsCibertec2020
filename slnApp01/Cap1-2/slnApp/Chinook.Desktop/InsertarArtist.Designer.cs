namespace Chinook.Desktop
{
    partial class InsertarArtist
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
            this.TbNombreNuevo = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.LbIdResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbNombreNuevo
            // 
            this.TbNombreNuevo.Location = new System.Drawing.Point(23, 22);
            this.TbNombreNuevo.Name = "TbNombreNuevo";
            this.TbNombreNuevo.Size = new System.Drawing.Size(304, 20);
            this.TbNombreNuevo.TabIndex = 0;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(145, 63);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 1;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // LbIdResultado
            // 
            this.LbIdResultado.AutoSize = true;
            this.LbIdResultado.Location = new System.Drawing.Point(52, 104);
            this.LbIdResultado.Name = "LbIdResultado";
            this.LbIdResultado.Size = new System.Drawing.Size(0, 13);
            this.LbIdResultado.TabIndex = 2;
            this.LbIdResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsertarArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 148);
            this.Controls.Add(this.LbIdResultado);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.TbNombreNuevo);
            this.Name = "InsertarArtist";
            this.Text = "InsertarArtist";
            this.Load += new System.EventHandler(this.InsertarArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNombreNuevo;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Label LbIdResultado;
    }
}