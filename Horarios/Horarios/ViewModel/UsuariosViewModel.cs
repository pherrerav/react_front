using Horarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Horarios.ViewModel
{
    public class UsuariosViewModel: Entidad
    {
        [Required]
        [MaxLength (20)]
        public string CodigoUsuario { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; }
        [Required]
        public bool Estado { get; set; }
        public virtual Perfil Perfil { get; set; }
        [Required]
        public byte PerfilId { get; set; }
        public virtual IEnumerable<Perfil> Perfiles { get; set; }
    }
}