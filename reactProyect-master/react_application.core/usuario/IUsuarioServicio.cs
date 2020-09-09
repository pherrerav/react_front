using react_application.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace react_application.core.usuario
{
    public interface IUsuarioServicio
    {
        IEnumerable<UsuarioViewModel> GetUsuarios();
        int AgregarUsuario(UsuarioViewModel usuarioObj);
        int ModificarUsuario(UsuarioViewModel usuarioObj);
        int EliminarUsuario(int id);
        int GetUserPerfil(string CodigoUsuario);
        bool IsDuplicate(string CodigoUsuario);
    }
}
