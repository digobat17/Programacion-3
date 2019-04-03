using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialejer2
{
    class Docentes
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string Sexo;
        public int Edad { get; set; }
        public string carrera;
        public string listaalumnos;

        public Docentes(string Nombre, string Apellidos, string Sexo, int Edad, string Carrera, string Listaalumnos)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;

            this.Sexo = Sexo;
            this.Edad = Edad;
            this.carrera = Carrera;
            this.listaalumnos = Listaalumnos;
        }
    }
}

