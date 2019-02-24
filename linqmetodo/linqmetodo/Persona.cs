using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqmetodo
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private string ci;
        private double altura;
        private double peso;

        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ci { get => ci; set => ci = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }

        public Persona(string Nombre, string Apellido, int Edad, string Sexo, string CI, double Altura, double Peso)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Ci = Ci;
            this.Altura = Altura;
            this.Peso = Peso;
        }
    }
}
