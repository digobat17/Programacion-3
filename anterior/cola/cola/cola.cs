using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class cola
    {
        public const int maximo = 10;
        private int[] vector = new int[maximo];

        private int frente = 0;
        private int Cola = -1;
        public void insertar(int valor)
        {
            if (!Llena())
            {
                Cola++;
                
                vector[Cola] = valor;
            }
            else
                Console.WriteLine("la cola esta llena");
        }
        public int eliminar()
        {
            if (!Vacia())
            {
                frente++;
                return vector[frente-1 ];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[frente];
            }
        }
        public void mostrar()
        {
            for (int i = frente; i <= Cola; i++)
            {
                Console.WriteLine("{0}", vector[i]);
            }

        } 
       
        private Boolean Vacia()
        {
            return frente>Cola;
        }
        private Boolean Llena()
        {
            return  Cola == maximo;

        }
    }
}
