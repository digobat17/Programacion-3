using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Preguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Thread t = new Thread(new ThreadStart(ThreadProc));
            Thread t2 = new Thread(new ThreadStart(Preguntas));
            //Creamos la instancia del hilo 
            
            //Iniciamos el hilo 
            t2.Start();
            t.Start();
            t.Join();
            t2.Abort();
            
            /*for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Se acabo el tiempo");
                Thread.Sleep(6000);
            }*/

           // Console.WriteLine("Hilo Principal: llamadaa Join(), para esperar que el ThreadProc Termine.");
            
           // Console.WriteLine("Hilo Principal: ThreadProc.Join ha devuelto.  fin del programa.");
            Console.ReadLine();
        }
        public static void ThreadProc()
        {
            
           
            for (int i = 0; i < 1; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Se acabo el tiempo la calificacion es de : {0}");
                
                

            }
           
            

        }
        public static void Preguntas()
        {
            string respuesta;

            string pregunta1 = "a";
            string pregunta2 = "b";
            string pregunta3 = "c";
            string pregunta4 = "d";
            string pregunta5 = "e";
            string pregunta6 = "f";
            string pregunta7 = "g";
            string pregunta8 = "h";
            string pregunta9 = "i";
            string pregunta10 = "j";
            for (int i = 1; i < 11; i++)
            {
                if (pregunta1 == "a")
                {
                    Console.WriteLine("Pregunta {0} ", i);
                    
                    respuesta = Console.ReadLine();
                    
                }
                else if (pregunta2 == "b")
                {
                    Console.WriteLine("Pregunta 2");
                    respuesta = Console.ReadLine();
                    
                }
                else if (pregunta3 == "c")
                {
                    Console.WriteLine("Pregunta 3");
                    respuesta = Console.ReadLine();
                    
                }
                else if (pregunta4 == "d")
                {
                    Console.WriteLine("Pregunta 4");
                    respuesta = Console.ReadLine();
                    
                }
                else if (pregunta5 == "e")
                {
                    Console.WriteLine("Pregunta 5");
                    respuesta = Console.ReadLine();
                }
                else if (pregunta6 == "f")
                {
                    Console.WriteLine("Pregunta 6");
                    respuesta = Console.ReadLine();
                }
                else if (pregunta7 == "g")
                {
                    Console.WriteLine("Pregunta 7");
                    respuesta = Console.ReadLine();
                }
                else if (pregunta8 == "h")
                {
                    Console.WriteLine("Pregunta 8");
                    respuesta = Console.ReadLine();
                }
                else if (pregunta9 == "i")
                {
                    Console.WriteLine("Pregunta 9");
                    respuesta = Console.ReadLine();
                }
                else if (pregunta10 == "j")
                {
                    Console.WriteLine("Pregunta 10");
                    respuesta = Console.ReadLine();
                }
            }
            
        }
    }
}
