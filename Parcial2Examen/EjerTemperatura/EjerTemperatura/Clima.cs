using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerTemperatura
{
    class Clima
    {
        private double temperatura;
        Random rnd = new Random();
        
        private static Clima Instancia;//singleton

        public double Temperatura { get => temperatura; set => temperatura = value; }

        private Clima()
        {
            obtenerTemperatura();
            colocarTemperatura(temperatura);
        }
        
        public static Clima getInstancia() 
        {
            if (Instancia == null)
            {
                Instancia = new Clima();
            }
            return Instancia;
        }
        public double obtenerTemperatura()
        {
            Temperatura = rnd.Next(40);
            
            return temperatura;
        }
        public double colocarTemperatura(double tempe)
        {
            
            return temperatura;
        }
    }
}
