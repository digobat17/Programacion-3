using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colacircular
{
    class ColaCirculuar
    {
        public const int maximo = 10;
        private int[] vector = new int[maximo]; 

        private int frente = 0;
        private int Cola = 0;
        
        public void insertar(int valor)
        {
            if (!Llena())
            {
               

                vector[Cola] = valor;
 Cola=(Cola+1)%maximo;
            }
            else
                Console.WriteLine("la cola esta llena");
        }
        public int eliminar()
        {
            if (!Vacia())
            {
                int aux;
                aux = vector[frente];
                frente = (frente + 1) % maximo;
                return aux;
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[frente];
            }
        }
        public void mostrar()
        {
            int aux = frente;
            while(aux!=Cola)
            {
                Console.Write(vector[aux] + " ");
                aux = (aux + 1) % maximo;
            }
            

        }
        public void salir()
        {
            Console.Clear();
           
        }

        private Boolean Vacia()
        {
            return frente == Cola;
        }
        private Boolean Llena()
        {
            return frente== (Cola+1)%maximo ;

        }
    }
}
