using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnostarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] persona = new Alumno[7];
            persona[0] = new Alumno("Diego","La Torre", 18, "Masculino", "13121920", 1.74, 76);
            persona[1] = new Alumno("Alejandro", "Castro", 19, "Masculino", "0000001", 1.70, 70);
            persona[2] = new Alumno("Isabel", "Lopez", 19, "Femenino", "0000002", 1.70, 70);
            persona[3] = new Alumno("Rossimar", "Guzman", 18, "Femenino", "00000003", 1.40, 43);
            persona[4] = new Alumno("Franco", "Adamczykc", 18, "Masculino", "0000004", 1.74, 65);
            persona[5] = new Alumno("Gustavo", "Zarate", 19, "Masculino", "000005", 1.76, 65);
            persona[6] = new Alumno("Dieter", "Quiño", 19, "Masculino", "0000006", 1.70, 70);
            //1.-lista de alumnos ordenados por apellido descendientemente
            var consulta1 = from alm in persona
                            orderby alm.Apellido, alm.Apellido descending
                            select new { alm.Apellido };
            foreach(var alum in consulta1)
            {
                Console.WriteLine("{0}",alum.Apellido);
                
            }
            
            //2.-lista de alumnos cuya edad=18 y sexo masculino
            Console.WriteLine("************************");
            var consulta2 = from alm in persona
                            where alm.Edad == 18 && alm.Sexo=="Masculino"
                            select alm;
            foreach(var alum in consulta2)
            {
                Console.WriteLine("{0} {1} {2}", alum.Edad, alum.Sexo,alum.Nombre);
            }
            Console.WriteLine("*****************************");
            //3.-grupos de alumno por sexo
            var consulta3 = from alm in persona
                            group alm by alm.Sexo into sexo
                            select sexo;
            foreach (var GrupSexo in consulta3)
            {
                Console.WriteLine(GrupSexo.Key);
                foreach (var alum in GrupSexo)
                {
                    Console.WriteLine("{0} {1}",alum.Nombre,alum.Apellido );
                }
            
            }
            Console.WriteLine("********************************");
            //4.- cantidad de alumnos por sexo
            var consulta4=from alm in persona
                          group alm by alm.Sexo into sexo
                          select new { Sexo = sexo.Key, cantidad = sexo.Count() };
            foreach (var grupoedad in consulta4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.cantidad);

            }
            Console.WriteLine("********************************");
            //5.-promedio de edad por sexo
            
            Console.ReadKey();

        }
    }
}
