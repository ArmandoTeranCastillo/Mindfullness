using Microsoft.EntityFrameworkCore;

namespace AMindFulness.Data.Seeds
{
    public class SeedInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DistorsionCognitivaSeed());
        }
    }
}