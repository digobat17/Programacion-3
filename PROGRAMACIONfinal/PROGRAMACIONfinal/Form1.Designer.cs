namespace PROGRAMACIONfinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtHoradepedido = new System.Windows.Forms.TextBox();
            this.txtentrega = new System.Windows.Forms.TextBox();
            this.txtnumerodepedido = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnentrega = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de entrega";
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "Comida elaborada",
            "Bebidas",
            "Frutas",
            "Verduras",
            "Carnes y Otros"});
            this.combo1.Location = new System.Drawing.Point(253, 108);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(119, 21);
            this.combo1.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(253, 138);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // txtHoradepedido
            // 
            this.txtHoradepedido.Location = new System.Drawing.Point(253, 166);
            this.txtHoradepedido.Name = "txtHoradepedido";
            this.txtHoradepedido.Size = new System.Drawing.Size(100, 20);
            this.txtHoradepedido.TabIndex = 8;
            // 
            // txtentrega
            // 
            this.txtentrega.Location = new System.Drawing.Point(253, 198);
            this.txtentrega.Name = "txtentrega";
            this.txtentrega.Size = new System.Drawing.Size(100, 20);
            this.txtentrega.TabIndex = 9;
            // 
            // txtnumerodepedido
            // 
            this.txtnumerodepedido.Location = new System.Drawing.Point(253, 73);
            this.txtnumerodepedido.Name = "txtnumerodepedido";
            this.txtnumerodepedido.Size = new System.Drawing.Size(100, 20);
            this.txtnumerodepedido.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(455, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 121);
            this.listBox1.TabIndex = 11;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(135, 21);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(118, 23);
            this.btnPedido.TabIndex = 12;
            this.btnPedido.Text = "Datos de Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnentrega
            // 
            this.btnentrega.Location = new System.Drawing.Point(465, 62);
            this.btnentrega.Name = "btnentrega";
            this.btnentrega.Size = new System.Drawing.Size(120, 23);
            this.btnentrega.TabIndex = 13;
            this.btnentrega.Text = "Entrega del pedido";
            this.btnentrega.UseVisualStyleBackColor = true;
            this.btnentrega.Click += new System.EventHandler(this.btnentrega_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(135, 244);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(218, 225);
            this.listBox2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnentrega);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnumerodepedido);
            this.Controls.Add(this.txtentrega);
            this.Controls.Add(this.txtHoradepedido);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtHoradepedido;
        private System.Windows.Forms.TextBox txtentrega;
        private System.Windows.Forms.TextBox txtnumerodepedido;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnentrega;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}

