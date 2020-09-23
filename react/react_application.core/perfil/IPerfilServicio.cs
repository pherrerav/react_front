using react_application.data.ViewModels;
using System.Collections;

namespace react_application.core.perfil
{
    public interface IPerfilServicio
    {
        IEnumerable GetPerfiles();
        ICollection BuscarPaginaPerfil(int id);
        int AgregarPerfil(PerfilViewModel perfilObj);
        int ModificarPerfil(PerfilViewModel perfilObj);
    }
}
