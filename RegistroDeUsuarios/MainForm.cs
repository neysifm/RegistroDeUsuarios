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
            ErrorProviderNombre.SetError(TextBoxNombre, "Introduzca Nombre !!");
            ErrorProviderContraseña.SetError(TextBoxContraseña, "Introduzca Contraseña !!");

        }

        private Usuarios LlenarClase()
        {
            Usuarios Usuario = new Usuarios
            {
                Nombres = TextBoxNombre.Text,
                Clave = TextBoxContraseña.Text,
                FechaIngreso = DateTimePickerFecha.Value
            };
            return Usuario;
        }

        private void LimpiarError()
        {
            ErrorProviderNombre.Clear();
            ErrorProviderContraseña.Clear();
        }

        private int SetError(int error)
        {
            int paso = 0;
            List<Usuarios> Usuario = new List<Usuarios>();
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
            if (error == 3 && BLL.UsuariosBLL.GetList(t => t.Nombres == TextBoxNombre.Text).Exists(t => t.Nombres == TextBoxNombre.Text) && NumericUpDownID.Value == 0)
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

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (BLL.UsuariosBLL.Buscar(Convert.ToInt32(NumericUpDownID.Value)) == null)
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }
            var Usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(NumericUpDownID.Value));
            TextBoxNombre.Text = Usuario.Nombres;
            TextBoxContraseña.Text = Usuario.Clave;
            DateTimePickerFecha.Value = Usuario.FechaIngreso;
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
            Usuarios Usuario = LlenarClase();
            if (NumericUpDownID.Value == 0)
            {
                if (Usuario == null)
                {
                    return;
                }

                if (BLL.UsuariosBLL.Guardar(Usuario))
                {
                    MessageBox.Show("Guardado!!");
                }
            }
            else
            {
                if (Usuario == null)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
