using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string x ;
            List<string> l = new List<string>();
            while(opcion!=4)
            {
                Console.Clear();
                Console.WriteLine("1. Introducir");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. ordenar");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca alumno");
                        x = Console.ReadLine();
                        l.Add(x);
                        break;
                    case 2:
                        Console.WriteLine("elimine un elemento alumno");
                        x = Console.ReadLine();
                        l.Remove(x);
                        break;
                    case 3:
                        foreach (string n in l)
                        {
                            Console.Write(n.ToString());
                            
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("ordenar");
                        l.Sort();
                        break;
                    case 5:
                        
                        break;
                }
            }
        }
    }
}
