using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareanro1
{
    class Program
    {
        static void Main(string[] args)
        {
int[] vector;
Console.WriteLine("Metodo de Burbuja");
            Console.Write("Cuantos longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
            
            
            MetodoBurbuja(vector);
            Imprimir(vector);
        }
        

       

       static public void MetodoBurbuja <T>(T[] vector) where T : IComparable<T>
        {
            T t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1].CompareTo( vector[b])>0)
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

      static  public void Imprimir<T>(T[] vector)
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }




    }
}
