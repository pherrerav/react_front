using Horarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Horarios.ViewModel
{
    public class PerfilesViewModel:Entidad
    {
        [Required]
        [MaxLength(30)]
        public string PerfilNombre { get; set; }
    }
}