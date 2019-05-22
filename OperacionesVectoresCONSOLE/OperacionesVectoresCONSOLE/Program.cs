using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesVectoresCONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            Console.WriteLine("Suma de dos vectores");
            v.cargar();
            v.Sumar();
            v.Restar();
             
            
        }
    }
}
