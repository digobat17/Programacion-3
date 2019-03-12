using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean salir = false;
            bicola b = new bicola();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar Final");
                Console.WriteLine("2. Eliminar Frente");
                Console.WriteLine("3. Insertar Frente");
                Console.WriteLine("4. Eliminar Final");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Mostrar1");
                Console.WriteLine("7. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        b.insertarfinal(x);
                        break;
                    case 2:
                        x = b.eliminarfrente();
                        Console.WriteLine("EL ELEMENTO ELIMINADO " + x);
                        Console.ReadKey();
                        break;
                        
                    case 3:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        b.insertarfrente(x);
                        break;
                    case 4:
                        x = b.eliminarfinal();
                        Console.WriteLine("El elemento eliminado es : " + x);
                        Console.ReadKey();
                        break;
                    case 5:

                        b.mostrar();
                        Console.ReadKey();
                        break;
                    case 6:
                        
                        Console.ReadKey();
                        break;
                    case 7:
                        b.salir();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
