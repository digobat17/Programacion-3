using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqmetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "La Torre", 18, "Masculino", "13121920", 1.74, 76);
            Alumnos[1] = new Persona("Alejandro", "Castro", 19, "Masculino", "7483306", 1.69, 70);
            Alumnos[2] = new Persona("Isabel", "Lopez", 19, "Femenino", "7504259", 1.65, 60);
            Alumnos[3] = new Persona("Rossimar", "Guzman", 18, "Femenino", "5713604", 1.54, 40);
            Alumnos[4] = new Persona("Franco", "Adamczyk", 18, "Masculino", "12609597", 1.74, 62);
            Alumnos[5] = new Persona("Gustavo", "Zarate", 19, "Masculino", "12575699", 1.76, 60);
            Alumnos[6] = new Persona("Dieter", "Quiñones", 19, "Masculino", "7547264", 1.67, 57);
            Console.WriteLine("Con metodos "); 

            Console.WriteLine("1.-Lista de alumnos ordenados por apellido descendientemente");

            var metodo1 = Alumnos.OrderByDescending(p => p.Apellido);

            foreach (var p in metodo1)
            {
                Console.WriteLine("{0} {1}", p.Apellido, p.Nombre);
            }
            Console.WriteLine("********************************");
            Console.WriteLine("2.-lista de alumnos cuya edad=18 y sexo masculino");

            var metodo2 = Alumnos.Where(p => p.Edad == 18 && p.Sexo=="Masculino");
            foreach(var p in metodo2)
            {
                Console.WriteLine("{0} {1} ", p.Nombre, p.Apellido);
            } 
Console.WriteLine("*******************************");
            Console.WriteLine(" 3.- Grupos de alumno por sexo");
            
            var metodo3 = Alumnos.GroupBy(p => p.Sexo ) ; 
                            
            // Grupo Edades
            foreach (var Gruposexo in metodo3)
            {
                Console.WriteLine(Gruposexo.Key);
                foreach (Persona alumno in Gruposexo)
                {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellido);

                }
            }
            Console.WriteLine("************************");
            Console.WriteLine("4.-Cantidad de alumnos por sexo");
            var metodo4 = Alumnos.GroupBy(t => new { Sexo = t.Sexo })
                         .Select(g => new {
                             Cantidad = g.Count(),
                             Sexo = g.Key.Sexo
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Cantidad);

            }
            Console.WriteLine("**********************");
            Console.WriteLine("5.- Promedio de Edad por Sexo ");
            var metodo5 = Alumnos.GroupBy(p => new { Sexo = p.Sexo })
                          .Select(h => new { Sexo = h.Key, Promedio = h.Average(q => q.Edad) });

            foreach (var grupoedad in metodo5)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Promedio);

            }
            Console.ReadKey();
        }
    }
}
