using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace plantillaMVC.Models
{
    public class Usuario
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength (30)]
        public string CodigoUsuario { get; set; }
        [Required]
        [MaxLength (20)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(40)]
        public string Apellidos { get; set; }
        [Required]
        public bool Estado { get; set; }
       /* public virtual Perfil Perfil { get; set; }
        public byte PerfilId { get; set; }*/

    }
}