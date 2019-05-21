using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeUsuarios.Entidades
{
    public class Cargos
    {
        [Key]

        public int CargosId       { get; set; }
        public String Descripcion { get; set; }

        public Cargos()
        {
            CargosId = 0;
            Descripcion = String.Empty;
        }

    }
}
