using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace infijaposfijanuevo
{
    static class Program
    {
        public static void Main(string[] args)
        {
            //string cadena = "(1+17)*2";
            Console.WriteLine("Ingresa la cadena a cambiar:");
            string algo = Console.ReadLine();
            Console.WriteLine(algo.PasarStringPosfijo());
            
            
            Console.Read();
        }
    }
    public static class resolver
    {
        public static string PasarStringPosfijo(this string stringeninfijo)
        {
            int tamaño = stringeninfijo.Length;
            Stack<char> pila = new Stack<char>();
            StringBuilder stringenposfijo = new StringBuilder();
            for (int i = 0; i < tamaño; i++)
            {
                if ((stringeninfijo[i] >= '0') && (stringeninfijo[i] <= '9'))
                {
                    stringenposfijo.Append(stringeninfijo[i]);
                }
                else if (stringeninfijo[i] == '(')
                {
                    pila.Push(stringeninfijo[i]);
                }
                else if ((stringeninfijo[i] == '*') || (stringeninfijo[i] == '+') || (stringeninfijo[i] == '-') || (stringeninfijo[i] == '/'))
                {
                    while ((pila.Count > 0) && (pila.Peek() != '('))
                    {
                        if (precedenciadeoperadores(pila.Peek(), stringeninfijo[i]))
                        {
                            stringenposfijo.Append(pila.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                    pila.Push(stringeninfijo[i]);
                }
                else if (stringeninfijo[i] == ')')
                {
                    while ((pila.Count > 0) && (pila.Peek() != '('))
                    {
                        stringenposfijo.Append(pila.Pop());
                    }
                    if (pila.Count > 0)
                        pila.Pop(); //quita el parentesis izquierdo de la pila
                }
            }
            while (pila.Count > 0)
            {
                stringenposfijo.Append(pila.Pop());
            }
            return stringenposfijo.ToString();
        }
        public static bool precedenciadeoperadores(char top, char p_2)
        {
            if (top == '+' && p_2 == '*') // + tiene menor precedencia que *
                return false;
            if (top == '*' && p_2 == '-') // * tiene mayor precedencia que -
                return true;
            if (top == '+' && p_2 == '-') // + tiene la misma precedencia que +
                return true;
            return true;
        }
        public static int EvaluarRes(string posfija)
        {
            Stack<int> pilaResultado = new Stack<int>();
            int tama = posfija.Length;
            for (int i = 0; i < tama; i++)
            {
                if ((posfija[i] == '*') || (posfija[i] == '+') || (posfija[i] == '-') || (posfija[i] == ' '))
                {
                    int resz = DimeOperador(pilaResultado.Pop(), pilaResultado.Pop(), posfija[i]);
                    pilaResultado.Push(resz);
                }
                else if ((posfija[i] >= '0') || (posfija[i] <= '9'))
                {
                    pilaResultado.Push((int)(posfija[i] - '0'));
                }
            }
            return pilaResultado.Pop();
        }
        public static int DimeOperador(int p, int p_2, char p_3)
        {
            switch (p_3)
            {
                case '+':
                    return p_2 + p;
                case '-':
                    return p_2 - p;
                case '*':
                    return p_2 * p;
                case '/':
                    return p_2 / p;
                default:
                    return -1;
            }
        }
    }
}