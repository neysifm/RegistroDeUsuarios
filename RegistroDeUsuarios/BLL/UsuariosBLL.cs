using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using RegistroDeUsuarios.DAL;
using RegistroDeUsuarios.Entidades;


namespace RegistroDeUsuarios.BLL
{
    public class UsuariosBLL
    {
        public static EntityState EntryState { get; private set; }

        public static bool Guardar(Usuarios User)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.User.Add(User) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }


            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.User.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Modificar(Usuarios user)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(user).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Usuarios user = new Usuarios();
            Contexto db = new Contexto();
            try
            {
                user = db.User.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> user)
        {
            List<Usuarios> usuario = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                usuario = db.User.Where(user).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }

    }
}
