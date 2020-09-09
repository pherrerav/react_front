using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace plantillaApi.Data.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string CodigoUsuario { get; set; }
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(60)]
        public string Apellidos { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
        [Required]
        public byte Estado { get; set; }

    }
}
