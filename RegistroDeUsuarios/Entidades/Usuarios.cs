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

        public int UsuariosId  { get; set; }
        public String Nombres    { get; set; }
        public String Email     { get; set; }
        public String NivelUsuario { get; set; }
        public String Usuario   { get; set; }
        public String Clave     { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios(int usuariosId, string nombres, string email, string nivelusuario, string usuario, string clave, DateTime fecha)
        {
            this.UsuariosId = usuariosId;
            this.Nombres = nombres;
            this.Email = email;
            this.NivelUsuario = nivelusuario;
            this.Usuario = usuario;
            this.Clave = clave;
            this.FechaIngreso = fecha;
        }

        public Usuarios()
        {
            UsuariosId = 0;
            Nombres = String.Empty;
            Email = String.Empty;
            NivelUsuario = String.Empty;
            Usuario = String.Empty;
            Clave = String.Empty;
            FechaIngreso = DateTime.Now; 
        }
    }
}
