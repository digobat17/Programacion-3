using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACIONfinal
{
    class EntregaDePedidos
    {
        public int nropedido { get; set; }
        public string tipodepedido { get; set; }
        public int monto { get; set; }
        public string horadepedido;      
        public string horadeentrega;
        public EntregaDePedidos(int nropedido, string tipodepedido, int monto, string horadepedido,string horadeentrega )
        {
            this.nropedido = nropedido;
            this.tipodepedido=tipodepedido;
            this.monto = monto;          
            this.horadepedido=horadepedido;
            this.horadeentrega = horadeentrega;
        }
    }
}
