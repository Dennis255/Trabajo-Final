using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class Registro
    {
        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Edad { set; get; }
        public string Genero { set; get; }
        public string Nacionalidad { set; get; }
        public string FechaNacimiento { set; get; }
        public string Descripcion { set; get; }
        public string Preferencias { set; get; }

        public Registro()
        {
        }

        public Registro(string cedula, string nombre, string apellido, int edad, string genero, string nacionalidad, string fechaNacimiento, string descripcion, string preferencias)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Genero = genero;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
            Descripcion = descripcion;
            Preferencias = preferencias;
        }
    }
}
