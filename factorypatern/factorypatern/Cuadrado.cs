using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypatern
{
    public class Cuadrado : Ifigura
    {
        private double Base;
        private double altura;

       
        public double Base1 { get => Base; set => Base = value; }
        public double Altura { get => altura; set => altura = value; }

        public void getArea(double Base1,double Altura)
        {
            double x = Base1 * Altura;
            Console.WriteLine("El area del cuadrado es " + x);
        }
        public void getPerimetro(double Base1,double Altura)
        {
           double x =( Base1+Altura) * 2;
            Console.WriteLine("El perimetro del cuadrado es " + x);
        }
    }
    public class Rectangulo : Ifigura
    {
        private double Base;
        private double altura;

        public double Base1 { get => Base; set => Base = value; }
        public double Altura { get => altura; set => altura = value; }

        public void getArea(double Base1,double Altura)
        {
           double x = Base1 * Altura;
            Console.WriteLine("El area del rectangulo es " + x);

        }
        public void getPerimetro(double Base1,double Altura)
        {
           double x = (2 * Base1) + (2 * Altura);
            Console.WriteLine("El perimetro del rectangulo es " + x);
        }
    }
    public class Circulo : Ifigura
    {
        private double radio;
        private double pi;

        public double Radio { get => radio; set => radio = value; }
        public double Pi { get => pi; set => pi = value; }

        public void getArea(double Radio,double Pi)
        {
           double x = Math.PI * Math.Pow(Radio, 2);
            Console.WriteLine("El area del circulo es " + x);
        }
        public void getPerimetro(double Radio,double Pi)
        {
           double x = 2 * Math.PI;
            Console.WriteLine("El perimetro del circulo es " + x);
        }
    }
}
