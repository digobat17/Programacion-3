using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareapolaca
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca expresion : 5 + 6 * 7 / (4 - 2)");
            String expresion;
            expresion = Console.ReadLine();
            Evaluacion y = new Evaluacion(expresion);
            y.Crearpolaca();
            //Console.WriteLine("Es:" + y.Evaluarpolaca());

            Console.ReadKey();
        }
    }
}
