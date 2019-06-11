using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesVectoresCONSOLE
{
    class Vector
    {
       private double[] a;
       private double[] b;
       private double[] c;
        private double[] r;


        public double[] A { get => a; set => a = value; }
        public double[] B { get => b; set => b = value; }
        public double[] C { get => c; set => c = value; }
        public double[] R { get => r; set => r = value; }

        /*public Vector(double[] su , double[] re)
{
a = su;
b = re;
}*/
        public void cargar()
        {
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new double[n];
            B = new double[n];
            C = new double[n];
            R = new double[n];
            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
            }
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
                
            }
            for(int i = 0;i<A.Length;i++)
            {
                R[i] = A[i] - B[i];
            }
        }
        public void Sumar()
        {
            Console.WriteLine("La suma de los vectores es: ");
            for (int i =0;i<A.Length;i++)
            {
                Console.Write("[" + C[i] + "] ");
            }
            Console.ReadLine();
        }
        public void Restar()
        {
            Console.WriteLine("La resta de los vectores es: ");
            for(int i=0;i<A.Length;i++)
            {
                Console.Write("[" + R[i] + "] ");
            }
            Console.ReadLine();
        }
       /* public void Multiplicar(int x,int y)
        {
            C = new double[x,y];
            for(int i=0;i<x;i++)
            {
                for(int j =0;j<y;j++)
                {
                    C[x, y] = int.Parse(Console.ReadLine());
                }
            }


        }*/
    }
}
