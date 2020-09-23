using react_application.data.Models;
using Microsoft.EntityFrameworkCore;

namespace react_application.data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {

        }

        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<TipoCambio> TipoCambio { get; set; }
        public virtual DbSet<PlanLealtad> PlanLealtad { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }
        public virtual DbSet<Pagina_Perfil> Pagina_Perfil { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pagina_Perfil>()
                .HasKey(bc => new { bc.PaginaId, bc.PerfilId });
            modelBuilder.Entity<Pagina_Perfil>()
                .HasOne(bc => bc.Pagina)
                .WithMany(b => b.Paginas_Perfiles)
                .HasForeignKey(bc => bc.PaginaId);
            modelBuilder.Entity<Pagina_Perfil>()
                .HasOne(bc => bc.Perfil)
                .WithMany(c => c.Paginas_Perfiles)
                .HasForeignKey(bc => bc.PerfilId);
            modelBuilder.Entity<Usuario>()
               .Property(b => b.FechaCreado)
               .HasDefaultValueSql("getdate()");
             modelBuilder.Entity<TipoCambio>()
               .Property(b => b.Fecha)
               .ValueGeneratedOnAddOrUpdate()
               .HasDefaultValueSql("getdate()");
           
        }
    }
}
