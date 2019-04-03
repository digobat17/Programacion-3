using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorypatern
{
    class Fabrica
    {
        public Ifigura Getfigure(string tipofigura)
        {
            if (tipofigura == "Cuadrado")
            {
                return new Cuadrado();
            }
           else if(tipofigura=="Rectangulo" )
            {
                return new Rectangulo();
            }
            else if(tipofigura=="Circulo")
            {
                return new Circulo();
            }
            else
            {
                return null;
            }
            

        }
    }
}
