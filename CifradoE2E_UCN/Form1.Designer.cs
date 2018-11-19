namespace CifradoE2E_UCN
{
    partial class Form1
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
            this.txtClavePublicaEsteExtremo = new System.Windows.Forms.RichTextBox();
            this.txtMensajeACifrar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensajeADecifrar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClavePublicaOtroExtremo = new System.Windows.Forms.RichTextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClavePublicaEsteExtremo
            // 
            this.txtClavePublicaEsteExtremo.Location = new System.Drawing.Point(9, 28);
            this.txtClavePublicaEsteExtremo.Name = "txtClavePublicaEsteExtremo";
            this.txtClavePublicaEsteExtremo.ReadOnly = true;
            this.txtClavePublicaEsteExtremo.Size = new System.Drawing.Size(403, 61);
            this.txtClavePublicaEsteExtremo.TabIndex = 0;
            this.txtClavePublicaEsteExtremo.Text = "";
            // 
            // txtMensajeACifrar
            // 
            this.txtMensajeACifrar.Location = new System.Drawing.Point(12, 224);
            this.txtMensajeACifrar.Name = "txtMensajeACifrar";
            this.txtMensajeACifrar.Size = new System.Drawing.Size(191, 130);
            this.txtMensajeACifrar.TabIndex = 1;
            this.txtMensajeACifrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Representación de clave pública de este extremo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensaje a cifrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Representaciòn mensaje cifrado";
            // 
            // txtMensajeADecifrar
            // 
            this.txtMensajeADecifrar.Location = new System.Drawing.Point(221, 224);
            this.txtMensajeADecifrar.Name = "txtMensajeADecifrar";
            this.txtMensajeADecifrar.Size = new System.Drawing.Size(191, 130);
            this.txtMensajeADecifrar.TabIndex = 4;
            this.txtMensajeADecifrar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Representación de clave pública del otro extremo";
            // 
            // txtClavePublicaOtroExtremo
            // 
            this.txtClavePublicaOtroExtremo.Location = new System.Drawing.Point(9, 115);
            this.txtClavePublicaOtroExtremo.Name = "txtClavePublicaOtroExtremo";
            this.txtClavePublicaOtroExtremo.Size = new System.Drawing.Size(403, 61);
            this.txtClavePublicaOtroExtremo.TabIndex = 6;
            this.txtClavePublicaOtroExtremo.Text = "";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(128, 360);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 8;
            this.btnCifrar.Text = "Cifrar >>";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(221, 360);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrar.TabIndex = 13;
            this.btnDescifrar.Text = "<< Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 398);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClavePublicaOtroExtremo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMensajeADecifrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensajeACifrar);
            this.Controls.Add(this.txtClavePublicaEsteExtremo);
            this.Name = "Form1";
            this.Text = "Prueba de concepto E2E - by Edwin Gómez";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtClavePublicaEsteExtremo;
        private System.Windows.Forms.RichTextBox txtMensajeACifrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMensajeADecifrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtClavePublicaOtroExtremo;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
    }
}

