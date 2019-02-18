using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventostarea3
{
    class Program
    {
        
        public class factororial
        {
            public delegate void delegado(int x);
            public event delegado multiplosdetres;
            public int factorial(int x)
            {
            int x1,y=1;
            
            x1 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= x1; i++)
            {
                y = y * i;
                
            }
            Console.Write(" factorial " + y);
                
                if ((y % 3 == 0) && (multiplosdetres != null))
                    {
                    multiplosdetres(y);
                }
                Console.ReadLine();
                return y;

            }
        }
        class factoriall
        {
            static void Main(string[] args)
            {
                factororial f = new factororial();
                f.multiplosdetres += recibemultiplodetres;
               Console.WriteLine(" Introduzca un numero ");
                int y=1;
                int res = f.factorial(y);
                Console.WriteLine("factorial " + y);
            }
            static void recibemultiplodetres(int x)
            {
                Console.WriteLine(" y se obtuvo un multiplo de 3 valor : " + x);
            }
        }
    }
}
