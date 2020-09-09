using react_application.data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace react_application.data.ViewModels
{
    public class PerfilViewModel
    {
        public int Id { get; set; }
        public string PerfilNombre { get; set; }
        public virtual ICollection<Pagina_Perfil> Paginas_Perfiles { get; set; }
    }
}
