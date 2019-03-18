using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string edad ;
            string nombre, carrera;
            bicolaDocentes<string> p = new bicolaDocentes<string>();
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por Detras");
                Console.WriteLine("2. Insertar por Delante");
                Console.WriteLine("3. Eliminar por Delante");
                Console.WriteLine("4. Eliminar por Atras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Insertar Nombre");
                        nombre = Console.ReadLine();
                        p.InsertarAtras( nombre);
                        Console.WriteLine("Insertar edad");
                        edad = Console.ReadLine();
                        p.InsertarAtras(Convert.ToString( edad));
                        Console.WriteLine("Insertar Carrera");
                        carrera = Console.ReadLine();
                        p.InsertarAtras(carrera);
                        Console.WriteLine("introducido un elemento Atras");
                       
                        break;
                    case 2:
                        Console.WriteLine("Insertar Nombre");
                        nombre = Console.ReadLine();
                        p.InsertarDelante(nombre);
                        Console.WriteLine("Insertar edad");
                        edad = Console.ReadLine();
                        p.InsertarDelante(Convert.ToString(edad));
                        Console.WriteLine("Insertar Carrera");
                        carrera = Console.ReadLine();
                        p.InsertarDelante(carrera);
                        Console.WriteLine("introducido un elemento delante");
                        
                        break;
                    case 3:
                        nombre = p.EliminarDelante();
                        edad =p.EliminarDelante();
                        carrera = p.EliminarDelante();
                        
                        Console.WriteLine("El elemento eliminado es {0}, {1},{2}", nombre,edad,carrera);
                        Console.ReadKey();
                        break;
                    case 4:
                        nombre = p.EliminarAtras();
                        edad = p.EliminarAtras();
                        carrera = p.EliminarAtras();                       
                        Console.WriteLine("El elemento eliminado es {0},{1},{2}", nombre,edad,carrera);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }


            }
        }
    }
}
