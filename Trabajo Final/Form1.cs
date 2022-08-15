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
    public partial class Form1 : Form
    {
        //nombre de la lista de ingreso
        ListaUsuario listaUsuarios = new ListaUsuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //nombre de la variable de la clase registro
                Registro registro = new Registro();
                registro.Cedula = txtCedula.Text;
                registro.Nombre = txtNombre.Text;
                registro.Apellido = txtApellido.Text;
                registro.Edad = Convert.ToInt32(txtEdad.Text);
                registro.Genero = Genero();
                registro.Nacionalidad = comboNacionalidad.Text;
                registro.FechaNacimiento = dtpFecha.Text;
                registro.Descripcion = rtxtDescripcion.Text;
                registro.Preferencias = listBoxPreferencias.Text;
                listaUsuarios.AgregarUsuario(registro);
                MessageBox.Show("Datos guardados corectamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Genero()
        {
            string aux = "";
            if (rbtnMasculino.Checked)
            {
                aux = "Masculino";
            }
            if (rbtnFemenino.Checked)
            {
                aux = "Femenino";
            }
            return aux;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            try
            {
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "0";
                rbtnMasculino.Checked = false;
                rbtnFemenino.Checked = false;
                comboNacionalidad.Text = "";
                dtpFecha.Value = DateTime.Now;
                rtxtDescripcion.Text = "";
                listBoxPreferencias.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            Mostrar form2 = new Mostrar();//formulario 2
            form2.Show();
            form2.listaUsuario2 = listaUsuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tutuju
        }
    }
}
