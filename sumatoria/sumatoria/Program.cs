using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumatoria
{
    public class Operaciones 
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplostres; 
        public int Sumar(int x, int y)
        {
            int iSuma = x + y;
            if ((iSuma % 3 == 0) && (CuandoRecibaMultiplostres != null))  
            { CuandoRecibaMultiplostres(iSuma); }
            return iSuma;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            o.CuandoRecibaMultiplostres += RecibeMultiplotres;

            int res = o.Sumar(4, 3);
            Console.WriteLine("La suma es = {0}", res);
            res = o.Sumar(7, 8);
            Console.WriteLine("La suma es = {0}", res);
            Console.ReadKey();
        }
        static void RecibeMultiplotres(int n) 
        {
            Console.WriteLine("Se obtuvo un multiplo de cinco valor: {0}", n);
        }
    }
    }

