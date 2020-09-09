using react_application.data.Models;
using System.Linq;

namespace react_application.data.Repositorio.tipoCambio
{
    public class TipoCambioRepositorio : Repositorio<TipoCambio>, ITipoCambioRepositorio
    {
        public TipoCambioRepositorio(MyDbContext dbContext)
        : base(dbContext)
        {
            table = dbContext.Set<TipoCambio>();
        }

        public TipoCambio GetTipoCambioDia()
        {
            var tipoCambio = table.OrderByDescending(t => t.Fecha).First();

            return tipoCambio;
        }
    }
}
