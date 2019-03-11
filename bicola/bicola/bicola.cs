﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicola
{
    class bicola
    {
        public const int maximo = 10;
        private int[] vector = new int[maximo];

        private int frente = 0;
        private int Cola = 0;
        private int tope = -1;

        public void insertarfinal(int valor)
        {
            if (!Llena())
            {


                vector[Cola] = valor;
                Cola = (Cola + 1) % maximo;
            }
            else
                Console.WriteLine("la cola esta llena");
        }
        public int eliminarfrente()
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
        public void insertarfrente(int valor)
        {
            if (!Llena1())
            {
                tope++;
                vector[tope] = valor;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public int eliminarfinal()
        {
            if (!vacia1())
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
        public void mostrar()
        {
            int aux = frente;
            while (aux != Cola)
            {
                Console.Write(vector[aux] + " ");
                aux = (aux + 1) % maximo;
            }


        }
        public void mostrar1()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine("{0}", vector[i]);
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
            return frente == (Cola + 1) % maximo;

        }
        private Boolean Llena1()
        {
            return tope == maximo;
        }
        private Boolean vacia1()
        {
            return tope == -1;
        }
    }
}