using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final
{
    public partial class Mostrar : Form
    {
        public ListaUsuario listaUsuario2 = new ListaUsuario();
        public Mostrar()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = listaUsuario2.Usuarios;
        }
    }
}
