using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Horarios.DAL
{
    public class CnnDbContext : DbContext
    {
        public CnnDbContext() : 
            base("name=CnnHorarios")
        {

        }
        public DbSet <Perfil> Perfiles { get; set; }
        public DbSet <Usuario> Usuarios { get; set; }
    }
}