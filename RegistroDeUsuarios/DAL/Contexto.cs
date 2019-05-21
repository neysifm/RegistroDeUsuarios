using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RegistroDeUsuarios.Entidades;

namespace RegistroDeUsuarios.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
