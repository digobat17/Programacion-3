using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACIONfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntregaDePedidos[] pedido;
        private void btnPedido_Click(object sender, EventArgs e)
        {

            int n,monto;
            string tipodePedido;
            string hdeEntrega;
            string horadePedido;
            n =Convert.ToInt32( txtnumerodepedido.Text);
            monto = Convert.ToInt32(txtMonto.Text);
            tipodePedido = combo1.Text;
            horadePedido = txtHoradepedido.Text;
            hdeEntrega = txtentrega.Text;
           
          
            EntregaDePedidos[] pedido = new EntregaDePedidos [n];
                       
            for (int i = 1; i < pedido.Length; i++)
            {
                pedido[i] = new EntregaDePedidos(n, tipodePedido, monto, horadePedido, hdeEntrega);
               
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Numero de Pedidos :");
            listBox2.Items.Add(n);
            listBox2.Items.Add("Monto del pedido");
            listBox2.Items.Add(monto);
            listBox2.Items.Add("Tipo de Pedido");
            listBox2.Items.Add(tipodePedido);
            listBox2.Items.Add("Hora de pedido");
            listBox2.Items.Add(horadePedido);
            listBox2.Items.Add("Hora de entrega");
            listBox2.Items.Add(hdeEntrega);

        }

        private void btnentrega_Click(object sender, EventArgs e)
        {
            string horadeentrega;
            horadeentrega = txtentrega.Text;
            listBox1.Items.Clear();
            listBox1.Items.Add("La hora de entrega fue a las :");
            listBox1.Items.Add(horadeentrega);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
                  var consulta1 = from ped in pedido
                            where ped.horadeentrega == ""
                            select ped;
             foreach (EntregaDePedidos p in consulta1)
            {
                listBox2.Items.Add(p.nropedido);
                
            }

            var consulta2 = from ped in pedido
                            where ped.monto < 250
                            select ped;
            foreach (EntregaDePedidos p in consulta2)
            {
                listBox2.Items.Add(p.tipodepedido);
               
            }
            var consulta3 = from alm in pedido
                            orderby alm.tipodepedido
                            select new { alm.tipodepedido };
            foreach (var p in consulta3)
            {

               listBox2.Items.Add(p.tipodepedido);
            }
              
        }
    }
}
