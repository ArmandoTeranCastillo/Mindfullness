using AMindFulness.MVVM.Models;
using Microsoft.EntityFrameworkCore;

namespace AMindFulness.Data
{
    public class Context : DbContext
    {
        public DbSet<Pensamiento> Pensamientos { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<DistorsionCognitiva> Distorsiones { get; set; }
    }
}