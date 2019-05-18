namespace EjerTemperatura
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(330, 124);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(31, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Valor";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.Location = new System.Drawing.Point(511, 124);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(120, 23);
            this.btnMetodo1.TabIndex = 1;
            this.btnMetodo1.Text = "Obtener Temperatura";
            this.btnMetodo1.UseVisualStyleBackColor = true;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.Location = new System.Drawing.Point(511, 155);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(120, 23);
            this.btnMetodo2.TabIndex = 2;
            this.btnMetodo2.Text = "Colocar Temperatura";
            this.btnMetodo2.UseVisualStyleBackColor = true;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(301, 158);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "La temperatura es de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "grados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

