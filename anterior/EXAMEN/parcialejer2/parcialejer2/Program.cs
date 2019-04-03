using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace parcialejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Docentes[] Alumnos = new Docentes[6];
            Alumnos[0] = new Docentes("Juan", "Perez", "Masculino", 35, "ing.industrial", "Diniosio-Pedro-Juan");
            Alumnos[1] = new Docentes("Maria", "Gomez", "Femenino", 33, "ing.civil", "Marcela-Ricardo-Maria");
            Alumnos[2] = new Docentes("Pedro", "Vaca", "Masculino",35, "ing.civil", "Marcela");
            Alumnos[3] = new Docentes("Marta", "Aramayo", "Femenino", 40, "ing.civil", "Dionisio-Pedro-Juan");
            Console.WriteLine("1.- lista de alumnos ordenada por edad y luego por nombre");
            
            var consulta1 = from alm in Alumnos
                            orderby alm.Edad
                            select new { alm.Nombre,alm.Edad};
            foreach (var p in consulta1)
            {
                Console.WriteLine("{0}, {1}", p.Nombre,p.Edad );
            }
            Console.WriteLine("2.- lista de los alumnos cuya edad sea 35");

            var consulta2 = from alm in Alumnos
                            where alm.Edad == 35
                            select alm;
            foreach (Docentes p in consulta2)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }
            Console.WriteLine("3-.");
 var consulta3 = from alm in Alumnos
                 group alm by alm.carrera into carrera               
                 select carrera;
            
            foreach (var Grupocarrera in consulta3)
            {
                Console.WriteLine(Grupocarrera.Key);
                foreach (Docentes alumno in Grupocarrera)
                {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellidos);

                }
            }
            Console.WriteLine("4.- Cantidad de  alumnos por edad ");

            var consulta4 = from almu in Alumnos                          
                            
                            group almu by almu.Edad into edad
                            select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var grupoedad in consulta4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }


        }
    }
}
