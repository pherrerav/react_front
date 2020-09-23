using System;
using System.Collections.Generic;
using System.Text;

namespace react_application.data.ViewModels
{
    public class UsuarioViewModel
    {
        public int? Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte Estado { get; set; }
        public int PerfilId { get; set; }
    }
}
