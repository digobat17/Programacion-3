namespace AhorcadoCliente
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
            this.BtnEnviarPalabra = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntEmpezar = new System.Windows.Forms.Button();
            this.btnEnviarLetra = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pbahorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbahorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnviarPalabra
            // 
            this.BtnEnviarPalabra.Location = new System.Drawing.Point(608, 197);
            this.BtnEnviarPalabra.Name = "BtnEnviarPalabra";
            this.BtnEnviarPalabra.Size = new System.Drawing.Size(92, 23);
            this.BtnEnviarPalabra.TabIndex = 17;
            this.BtnEnviarPalabra.Text = "Enviar Palabra";
            this.BtnEnviarPalabra.UseVisualStyleBackColor = true;
            this.BtnEnviarPalabra.Click += new System.EventHandler(this.BtnEnviarPalabra_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(446, 199);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra.TabIndex = 16;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Palabra Adivinar";
            // 
            // bntEmpezar
            // 
            this.bntEmpezar.Location = new System.Drawing.Point(608, 139);
            this.bntEmpezar.Name = "bntEmpezar";
            this.bntEmpezar.Size = new System.Drawing.Size(75, 23);
            this.bntEmpezar.TabIndex = 14;
            this.bntEmpezar.Text = "Empezar";
            this.bntEmpezar.UseVisualStyleBackColor = true;
            this.bntEmpezar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEnviarLetra
            // 
            this.btnEnviarLetra.Location = new System.Drawing.Point(608, 168);
            this.btnEnviarLetra.Name = "btnEnviarLetra";
            this.btnEnviarLetra.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarLetra.TabIndex = 13;
            this.btnEnviarLetra.Text = "Enviar Letra";
            this.btnEnviarLetra.UseVisualStyleBackColor = true;
            this.btnEnviarLetra.Click += new System.EventHandler(this.btnEnviarLetra_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(446, 173);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(38, 20);
            this.txtLetra.TabIndex = 12;
            this.txtLetra.TextChanged += new System.EventHandler(this.txtLetra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Introduzca Letra";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(351, 252);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 39);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "-";
            // 
            // pbahorcado
            // 
            this.pbahorcado.Location = new System.Drawing.Point(538, 283);
            this.pbahorcado.Name = "pbahorcado";
            this.pbahorcado.Size = new System.Drawing.Size(145, 162);
            this.pbahorcado.TabIndex = 9;
            this.pbahorcado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.BtnEnviarPalabra);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntEmpezar);
            this.Controls.Add(this.btnEnviarLetra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pbahorcado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbahorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviarPalabra;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntEmpezar;
        private System.Windows.Forms.Button btnEnviarLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pbahorcado;
    }
}

