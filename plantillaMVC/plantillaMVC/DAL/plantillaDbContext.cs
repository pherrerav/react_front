using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using plantillaMVC.Models;

namespace plantillaMVC.DAL
{
    public class plantillaDbContext : DbContext
    {
        public plantillaDbContext() 
            :base("plantillaCnn")
        {

        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
    }
}