using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final
{
    public class ListaUsuario
    {
        public List<Registro> Usuarios { set; get; }
        public ListaUsuario()
        {
            Usuarios = new List<Registro>();
        }
        public void AgregarUsuario(Registro usuario)
        {
            Usuarios.Add(usuario);
        }
    }
}
