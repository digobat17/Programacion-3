using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x= Clima.getInstancia().obtenerTemperatura();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //obtenertemperatura
           
            lblResultado.Text =Convert.ToString( x);

        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            //colocartemperatura
            double y =Clima.getInstancia().colocarTemperatura(x);
            txt1.Text =Convert.ToString( y);
           
        }
    }
}
