namespace App.UI.Desktop
{
    partial class formularioNotas
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
            this.tbAlumnoId = new System.Windows.Forms.TextBox();
            this.tbCursoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlumnoId";
            // 
            // tbAlumnoId
            // 
            this.tbAlumnoId.Location = new System.Drawing.Point(105, 20);
            this.tbAlumnoId.Name = "tbAlumnoId";
            this.tbAlumnoId.Size = new System.Drawing.Size(100, 20);
            this.tbAlumnoId.TabIndex = 1;
            // 
            // tbCursoId
            // 
            this.tbCursoId.Location = new System.Drawing.Point(105, 52);
            this.tbCursoId.Name = "tbCursoId";
            this.tbCursoId.Size = new System.Drawing.Size(100, 20);
            this.tbCursoId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CursoId";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(105, 84);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(64, 125);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(154, 130);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 7;
            // 
            // formularioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 159);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCursoId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAlumnoId);
            this.Controls.Add(this.label1);
            this.Name = "formularioNotas";
            this.Text = "formularioNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlumnoId;
        private System.Windows.Forms.TextBox tbCursoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lbId;
    }
}