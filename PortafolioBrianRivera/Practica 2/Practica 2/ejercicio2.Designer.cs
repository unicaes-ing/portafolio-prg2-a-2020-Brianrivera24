namespace Practica_2
{
    partial class ejercicio2
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDescuentos = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdoDes0 = new System.Windows.Forms.RadioButton();
            this.rdoDes5 = new System.Windows.Forms.RadioButton();
            this.rdoDes10 = new System.Windows.Forms.RadioButton();
            this.rdoDes15 = new System.Windows.Forms.RadioButton();
            this.rdoDes20 = new System.Windows.Forms.RadioButton();
            this.grpDescuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(100, 21);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(100, 78);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(100, 161);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "descuento:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(62, 302);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpDescuentos
            // 
            this.grpDescuentos.Controls.Add(this.rdoDes20);
            this.grpDescuentos.Controls.Add(this.rdoDes15);
            this.grpDescuentos.Controls.Add(this.rdoDes10);
            this.grpDescuentos.Controls.Add(this.rdoDes5);
            this.grpDescuentos.Controls.Add(this.rdoDes0);
            this.grpDescuentos.Location = new System.Drawing.Point(253, 26);
            this.grpDescuentos.Name = "grpDescuentos";
            this.grpDescuentos.Size = new System.Drawing.Size(137, 257);
            this.grpDescuentos.TabIndex = 7;
            this.grpDescuentos.TabStop = false;
            this.grpDescuentos.Text = "Descuentos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(114, 118);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(100, 214);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(173, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdoDes0
            // 
            this.rdoDes0.AutoSize = true;
            this.rdoDes0.Location = new System.Drawing.Point(17, 47);
            this.rdoDes0.Name = "rdoDes0";
            this.rdoDes0.Size = new System.Drawing.Size(49, 21);
            this.rdoDes0.TabIndex = 0;
            this.rdoDes0.TabStop = true;
            this.rdoDes0.Text = "0%";
            this.rdoDes0.UseVisualStyleBackColor = true;
            // 
            // rdoDes5
            // 
            this.rdoDes5.AutoSize = true;
            this.rdoDes5.Location = new System.Drawing.Point(17, 92);
            this.rdoDes5.Name = "rdoDes5";
            this.rdoDes5.Size = new System.Drawing.Size(49, 21);
            this.rdoDes5.TabIndex = 1;
            this.rdoDes5.TabStop = true;
            this.rdoDes5.Text = "5%";
            this.rdoDes5.UseVisualStyleBackColor = true;
            // 
            // rdoDes10
            // 
            this.rdoDes10.AutoSize = true;
            this.rdoDes10.Location = new System.Drawing.Point(17, 139);
            this.rdoDes10.Name = "rdoDes10";
            this.rdoDes10.Size = new System.Drawing.Size(57, 21);
            this.rdoDes10.TabIndex = 2;
            this.rdoDes10.TabStop = true;
            this.rdoDes10.Text = "10%";
            this.rdoDes10.UseVisualStyleBackColor = true;
            // 
            // rdoDes15
            // 
            this.rdoDes15.AutoSize = true;
            this.rdoDes15.Location = new System.Drawing.Point(17, 183);
            this.rdoDes15.Name = "rdoDes15";
            this.rdoDes15.Size = new System.Drawing.Size(57, 21);
            this.rdoDes15.TabIndex = 3;
            this.rdoDes15.TabStop = true;
            this.rdoDes15.Text = "15%";
            this.rdoDes15.UseVisualStyleBackColor = true;
            // 
            // rdoDes20
            // 
            this.rdoDes20.AutoSize = true;
            this.rdoDes20.Location = new System.Drawing.Point(17, 221);
            this.rdoDes20.Name = "rdoDes20";
            this.rdoDes20.Size = new System.Drawing.Size(57, 21);
            this.rdoDes20.TabIndex = 4;
            this.rdoDes20.TabStop = true;
            this.rdoDes20.Text = "20%";
            this.rdoDes20.UseVisualStyleBackColor = true;
            // 
            // ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 377);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpDescuentos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Name = "ejercicio2";
            this.Text = "Form2";
            this.grpDescuentos.ResumeLayout(false);
            this.grpDescuentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDescuentos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdoDes20;
        private System.Windows.Forms.RadioButton rdoDes15;
        private System.Windows.Forms.RadioButton rdoDes10;
        private System.Windows.Forms.RadioButton rdoDes5;
        private System.Windows.Forms.RadioButton rdoDes0;
    }
}