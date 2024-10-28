using AMindFulness.Data.Seeds;
using AMindFulness.MVVM.Models;
using Microsoft.EntityFrameworkCore;

namespace AMindFulness.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        
        public DbSet<Pensamiento> Pensamientos { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<DistorsionCognitiva> Distorsiones { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedInitializer.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}