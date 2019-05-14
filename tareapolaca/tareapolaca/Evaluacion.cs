using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareapolaca
{
    class Evaluacion
    {
         private List<string> Expresionpolaca = new List<string>();
         private Stack<string> p = new Stack<string>();
         private string expresion ;

        public Evaluacion(string e)
        {
            expresion = e;
        }
        public string Crearpolaca()
        {
            int x = 0;
            while (x < expresion.Length)
            {
                foreach (char caracter in expresion)
                {
                    if (caracter == '1' || caracter == '2' || caracter == '3' || caracter == '4' || caracter == '5' || caracter == '6' || caracter == '7' || caracter == '8' || caracter == '9' || caracter == '0')
                    {
                        Expresionpolaca.Add(caracter.ToString());
                    }
                    else if (caracter == '(')
                    {
                        p.Push(caracter.ToString());
                    }
                    else if (caracter == '*' || caracter == '-' || caracter == '/' || caracter == '+')
                    {
                        while ((p.Count > 0 && p.Peek() != '('.ToString()))
                        {
                            if (prioridad(p.Peek(), caracter.ToString()))
                            {
                                Expresionpolaca.Add(p.Pop());
                            }
                            else
                            {
                                break;
                            }
                        }
                        p.Push(caracter.ToString());
                    }
                    else if (caracter == ')')
                    {
                        while ((p.Count > 0) && (p.Peek() != '('.ToString()))
                        {
                            Expresionpolaca.Add(p.Pop());
                        }
                        if (p.Count > 0)
                            p.Pop(); //quita el parentesis izquierdo de la pila
                    }
                    x++;
                }
                    while (p.Count > 0)
                    {
                        Expresionpolaca.Add(p.Pop());
                    }
                foreach (String a in Expresionpolaca)
                {
                    Console.Write("" + a);
                    expresion = a;
                }
            }
            
            return ""; 
        }

       
        public bool prioridad(string a,string b)
        {

            if (a == '+'.ToString() && b == '*'.ToString()) // + tiene menor precedencia que *
                return false;
            if (a == '-'.ToString() && b == '/'.ToString())
                return false;
            if (a == '*'.ToString() && b == '-'.ToString()) // * tiene mayor precedencia que -
                return true;
            if (a == '+'.ToString() && b == '-'.ToString()) // + tiene la misma precedencia que +
                return true;
            if (a == '/'.ToString() && b == '*'.ToString())
                return true;
            
               
            return true;

        }
        public String Evaluarpolaca()
        {
            foreach (String caracter in Expresionpolaca)
            {

                if (caracter == "*" || caracter == "/" || caracter == "-" || caracter == "+")
                {
                    int res = DimeOperador(Convert.ToInt32(p.Pop()), Convert.ToInt32(p.Pop()), caracter);
                    p.Push(res.ToString());
                }
                else if (caracter == "0" || caracter == "1" || caracter == "2" || caracter == "3" || caracter == "4" || caracter == "5" || caracter == "6" || caracter == "7" || caracter == "8" || caracter == "9")
                {
                    int res = Convert.ToInt16(caracter);
                    p.Push(res.ToString());
                }
            }
            return p.Pop();
        }
         private int DimeOperador(int p, int p_2, String p_3)
        {
            switch (p_3)
            {
                case "+":
                    return p_2 + p;
                case "-":
                    return p_2 - p;
                case "*":
                    return p_2 * p;
                case "/":
                    return p_2 / p;
                default:
                    return -1;
            }
        }
    }
}
