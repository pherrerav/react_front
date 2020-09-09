using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace plantillaApi.Data.Models
{
    public class Perfil
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string PerfilNombre { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
