using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace plantillaMVC.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string PerfilNombre { get; set; }
        public virtual IEnumerable<Usuario> Usuario { get; set; }
    }
}