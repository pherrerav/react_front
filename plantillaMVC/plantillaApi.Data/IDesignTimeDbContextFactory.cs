using System;
using System.Collections.Generic;
using System.Text;

namespace plantillaApi.Data
{
    public interface IDesignTimeDbContextFactory<TContext>
    {
        MyDbContext CreateDbContext(string[] args);
    }
}
