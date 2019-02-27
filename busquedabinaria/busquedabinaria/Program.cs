using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedabinaria
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] vector = {46,31,22,48,7,68,80};
            Console.WriteLine("Introduzca numero");
            
           ordenamiento(vector);

            int b = int.Parse(Console.ReadLine());
            if (buscar(vector,b ))
            {
                Console.WriteLine("Se encontro elemento");
            }
            else
            {
                Console.WriteLine("no se encontro elemento");
            }
            Console.ReadKey();

        }
        static Boolean buscar(int[] vector,int b)
        {
           
            int i = 0;
            int j = vector.Length;
            int m = (j - 1) / 2 + i;
            while(b != vector[m]&&(i>(i+1)))
            {
                if(b>vector[m])
                
                    i = m;
                
                else
                
                    j = m;
                
                m = (j - 1) / 2 + i;


            }
            if (vector[m]==b)           
                return true;         
            else           
                return false;
            
        }
       static void ordenamiento(int[] vector)
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }
    }
}
