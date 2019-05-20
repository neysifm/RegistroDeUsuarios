using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace RegistroDeUsuarios.Entidades
{
    public class Usuarios
    {
        [Key]

        public int ID_Usuarios  { get; set; }
        public String Nombre    { get; set; }
        public String Email     { get; set; }
        public String NivelUsuario { get; set; }
        public String Usuario   { get; set; }
        public String Clave     { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios(int id_usuarios, string nombre, string email, string nivelusuario, string usuario, string clave, DateTime fecha)
        {
            this.ID_Usuarios = id_usuarios;
            this.Nombre = nombre;
            this.Email = email;
            this.NivelUsuario = nivelusuario;
            this.Usuario = usuario;
            this.Clave = clave;
            this.FechaIngreso = fecha;
        }

        public Usuarios()
        {
            ID_Usuarios = 0;
            Nombre = String.Empty;
            Email = String.Empty;
            NivelUsuario = String.Empty;
            Usuario = String.Empty;
            Clave = String.Empty;
            FechaIngreso = DateTime.Now; 
        }
    }
}
