using react_application.data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace react_application.data.Repositorio.planLealtad
{
    public class PlanLealtadRepositorio : Repositorio<PlanLealtad>, IPlanLealtadRepositorio
    {
        public PlanLealtadRepositorio(MyDbContext dbContext)
        : base(dbContext)
        {
            table = dbContext.Set<PlanLealtad>();
        }
    }
}
