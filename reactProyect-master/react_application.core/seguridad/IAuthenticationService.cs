using react_application.data.Models;

namespace react_application.core.seguridad
{
    public interface IAuthenticationService
    {
        Authentication AdAuthentication(string userName, string password);
        int SistemValidation(string userName);
        int Login(string userName, string password);
        int ValidarAcceso(int pagina, int perfil);
    }
}
