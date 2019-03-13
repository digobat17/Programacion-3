using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilaalumno
{
    class pilaAlumno
    {
        public const int maximo = 15;
        private int[] vector = new int[maximo];
        private string[] vector1 = new string[maximo];
        private int tope = -1;

        public void insertarNombre(string valor)
        {
            if(!llena())
            {
                tope++;
                vector1[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarEdad(int valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public void insertarSexo(string valor)
        {
            if (!llena())
            {
                tope++;
                vector1[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarCarrera(string valor)
        {
            if (!llena())
            {
                tope++;
                vector1[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public int eliminarEdad()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return -1;
            }
        }
        public string eliminarNombre()
        {
            if (!vacia())
            {
                tope--;
                return vector1[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Convert.ToString(-1);
            }
        }
        public void mostrar()
        {
                for (int i = 0; i <= tope; i++)
                {
                    Console.WriteLine("{0},{1}", vector[i],vector1[i]);

                }
            
           
        }
        private Boolean vacia()
        {
            return tope == -1;
        }
        private Boolean llena()
        {
            return tope == maximo;

        }
    }
}
