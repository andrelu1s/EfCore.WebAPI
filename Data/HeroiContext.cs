using EfCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=1;Persist Security Info=True;User ID=sa;Initial Catalog=TesteEF;Data Source=192.168.2.186\SQLEXPRESS");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
                {
                    entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
                });
        }
    }
}
