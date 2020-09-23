using react_application.data.Models;

namespace react_application.data.Repositorio.usuario
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        bool IsDuplicate(string CodigoUsuario);
        int GetUserPerfil(string CodigoUsuario);
    }
}
