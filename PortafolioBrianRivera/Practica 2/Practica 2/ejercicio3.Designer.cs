namespace Practica_2
{
    partial class ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstLongitudes1 = new System.Windows.Forms.ListBox();
            this.lstLongitudes2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca longitud a convertir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLongitudes1);
            this.groupBox1.Location = new System.Drawing.Point(41, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLongitudes2);
            this.groupBox2.Location = new System.Drawing.Point(277, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(292, 17);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 22);
            this.txtLongitud.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(187, 332);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Longitud a convertir";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(116, 396);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstLongitudes1
            // 
            this.lstLongitudes1.FormattingEnabled = true;
            this.lstLongitudes1.ItemHeight = 16;
            this.lstLongitudes1.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstLongitudes1.Location = new System.Drawing.Point(7, 31);
            this.lstLongitudes1.Name = "lstLongitudes1";
            this.lstLongitudes1.Size = new System.Drawing.Size(120, 84);
            this.lstLongitudes1.TabIndex = 0;
            // 
            // lstLongitudes2
            // 
            this.lstLongitudes2.FormattingEnabled = true;
            this.lstLongitudes2.ItemHeight = 16;
            this.lstLongitudes2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstLongitudes2.Location = new System.Drawing.Point(6, 31);
            this.lstLongitudes2.Name = "lstLongitudes2";
            this.lstLongitudes2.Size = new System.Drawing.Size(120, 84);
            this.lstLongitudes2.TabIndex = 0;
            // 
            // ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ejercicio3";
            this.Text = "ejercicio3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLongitudes1;
        private System.Windows.Forms.ListBox lstLongitudes2;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
    }
}