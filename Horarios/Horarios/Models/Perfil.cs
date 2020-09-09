using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horarios.Models
{
    public class Perfil : Entidad
    {
        public string PerfilNombre { get; set; }
        public virtual IEnumerable<Usuario> Usuario { get; set; }
    }
}