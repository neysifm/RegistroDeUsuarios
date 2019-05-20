using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDeUsuarios.Properties;
using RegistroDeUsuarios.BLL;
using RegistroDeUsuarios.Entidades;

namespace RegistroDeUsuarios
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ErrorProviderNombre.SetError(TextBoxNombre, "Nombre invalido!!");
            ErrorProviderContraseña.SetError(TextBoxContraseña, "Contraseña invalida!!");

        }

        private Usuarios LlenarClase()
        {
            Usuarios user = new Usuarios
            {
                Nombre = TextBoxNombre.Text,
                Clave = TextBoxContraseña.Text,
                FechaIngreso = DateTimePickerFecha.Value
            };
            return user;
        }

        private void LimpiarError()
        {
            ErrorProviderNombre.Clear();
            ErrorProviderContraseña.Clear();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (BLL.UsuariosBLL.Buscar(Convert.ToInt32(NumericUpDownID.Value)) == null)
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }
            var user = BLL.UsuariosBLL.Buscar(Convert.ToInt32(NumericUpDownID.Value));
            TextBoxNombre.Text = user.Nombre;
            TextBoxContraseña.Text = user.Clave;
            DateTimePickerFecha.Value = user.FechaIngreso;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            LimpiarError();
            Usuarios user = LlenarClase();
                if (BLL.UsuariosBLL.Modificar(LlenarClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
            }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {

        }
     
    }
}
