using plantillaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace plantillaMVC.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        /*public virtual Perfil Perfil { get; set; }
        public byte PerfilId { get; set; }
        public virtual IEnumerable<Perfil> Perfiles { get; set; }*/
    }
}