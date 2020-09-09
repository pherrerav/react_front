using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horarios.Models
{
    public class Usuario : Entidad
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        public virtual Perfil Perfil { get; set; }
        public byte PerfilId { get; set; }
    }
}