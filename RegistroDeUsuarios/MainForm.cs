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

        private int SetError(int error)
        {
            int paso = 0;
            List<Usuarios> user = new List<Usuarios>();
            if (error == 1 && NumericUpDownID.Value == 0)
            {

                ErrorProviderID.SetError(NumericUpDownID, "Llenar Campo!!");
                paso = 1;
                return paso;
            }
            if (error == 2 && TextBoxNombre.Text == string.Empty)
            {
                ErrorProviderNombre.SetError(TextBoxNombre, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && TextBoxContraseña.Text == string.Empty)
            {
                ErrorProviderContraseña.SetError(TextBoxContraseña, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 3 && BLL.UsuariosBLL.GetList(t => t.Nombre == TextBoxNombre.Text).Exists(t => t.Nombre == TextBoxNombre.Text) && NumericUpDownID.Value == 0)
            {
                ErrorProviderNombre.SetError(TextBoxNombre, "Debe de crear otro usuario!!");
                paso = 1;
            }


            return paso;
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            NumericUpDownID.Value = 0;
            TextBoxNombre.Clear();
            TextBoxContraseña.Clear();
            DateTimePickerFecha.Value = DateTime.Now;
            LimpiarError();
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
            if (SetError(2) == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if (SetError(3) == 1 && NumericUpDownID.Value == 0)
            {
                MessageBox.Show("Usuario existente!!");
                return;
            }
            Usuarios user = LlenarClase();
            if (NumericUpDownID.Value == 0)
            {
                if (user == null)
                {
                    return;
                }

                if (BLL.UsuariosBLL.Guardar(user))
                {
                    MessageBox.Show("Guardado!!");
                }
            }
            else
            {
                if (user == null)
                {
                    return;
                }
                if (SetError(1) == 1)
                {
                    MessageBox.Show("Campos Vacios!!");
                    return;
                }
                if (BLL.UsuariosBLL.Modificar(LlenarClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
            }
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
                LimpiarError();
                Usuarios user = LlenarClase();
                if (BLL.UsuariosBLL.Modificar(LlenarClase()))
                {
                    MessageBox.Show("Modificado!!");
                } 

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (SetError(1) == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if (BLL.UsuariosBLL.Eliminar(Convert.ToInt32(NumericUpDownID.Value)))
            {
                MessageBox.Show("Eliminado");
            }
        }
    }
}
