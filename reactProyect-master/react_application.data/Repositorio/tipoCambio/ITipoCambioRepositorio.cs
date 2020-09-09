using react_application.data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace react_application.data.Repositorio.tipoCambio
{
    public interface ITipoCambioRepositorio : IRepositorio<TipoCambio>
    {
        TipoCambio GetTipoCambioDia();
    }
}
