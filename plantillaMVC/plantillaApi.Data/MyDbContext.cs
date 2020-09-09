using Microsoft.EntityFrameworkCore;
using plantillaApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace plantillaApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
    }
}
