using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica f = new Fabrica();
            Console.WriteLine("Introduzca base");
           double base1 =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Introduzca altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca radio");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca pi");
            double pi = Convert.ToDouble(Console.ReadLine());
            Ifigura f1 = f.Getfigure("Cuadrado");
            f1.getArea(base1,altura);
            f1.getPerimetro(base1,altura);

            Ifigura f2 = f.Getfigure("Rectangulo");
            f2.getArea(base1,altura);
            f2.getPerimetro(base1,altura);
            Ifigura f3 = f.Getfigure("Circulo");
            f3.getArea(radio,pi);
            f3.getPerimetro(radio,pi);

            Console.ReadKey();
        }
    }
}
