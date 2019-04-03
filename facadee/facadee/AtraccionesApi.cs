using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadee
{
    class AtraccionesApi
    {
        public void BuscarAtracciones(String fechaIda, String fechaVuelta, String destino)
        {
            Console.WriteLine("=================");
            Console.WriteLine("Se encontraron atracciones en " + destino);
            Console.WriteLine("ENTRADA " + fechaIda + "VUELTA " + fechaVuelta);
            Console.WriteLine("DISFRUTE");
        }
    }
}
