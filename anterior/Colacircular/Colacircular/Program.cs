using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colacircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            ColaCirculuar p = new ColaCirculuar();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        p.insertar(x);
                        break;
                    case 2:
                        x = p.eliminar();
                        Console.WriteLine("EL ELEMENTO ELIMINADO " + x);
                        Console.ReadKey();
                        break;
                    case 3:

                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        p.salir();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
