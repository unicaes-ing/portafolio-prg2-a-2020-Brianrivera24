namespace Practica1
{
    partial class Promedio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExamen1 = new System.Windows.Forms.TextBox();
            this.txtExamen2 = new System.Windows.Forms.TextBox();
            this.txtExamen3 = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(21, 302);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(168, 302);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 1;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(311, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Examen 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Examen 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Examen 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio";
            // 
            // txtExamen1
            // 
            this.txtExamen1.Location = new System.Drawing.Point(168, 35);
            this.txtExamen1.Name = "txtExamen1";
            this.txtExamen1.Size = new System.Drawing.Size(100, 22);
            this.txtExamen1.TabIndex = 7;
            // 
            // txtExamen2
            // 
            this.txtExamen2.Location = new System.Drawing.Point(168, 92);
            this.txtExamen2.Name = "txtExamen2";
            this.txtExamen2.Size = new System.Drawing.Size(100, 22);
            this.txtExamen2.TabIndex = 8;
            // 
            // txtExamen3
            // 
            this.txtExamen3.Location = new System.Drawing.Point(168, 146);
            this.txtExamen3.Name = "txtExamen3";
            this.txtExamen3.Size = new System.Drawing.Size(100, 22);
            this.txtExamen3.TabIndex = 9;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(168, 217);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 22);
            this.txtPromedio.TabIndex = 10;
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 380);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtExamen3);
            this.Controls.Add(this.txtExamen2);
            this.Controls.Add(this.txtExamen1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Name = "Promedio";
            this.Text = "Promedio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExamen1;
        private System.Windows.Forms.TextBox txtExamen2;
        private System.Windows.Forms.TextBox txtExamen3;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}

