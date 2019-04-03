using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        delegate int Mdelegate(int a);
        static void Main(string[] args)
        {
            int x, y, y1, y0;
            Console.WriteLine("Introduzca un numero");
            x = int.Parse(Console.ReadLine());
            Mdelegate del = (int a) => { return x; };
            y0 = 0;
            y1 = 1;
            for(int i = 2;i<=x;i++)
            {
                y = y0 + y1;
                y0 = y1;
                Console.WriteLine("Fibonacci: " + (y1 = y));
            }
            Console.ReadKey();
        }
    }
}
