using System;
using AMindFulness.Data.Dependencies.Services;
using AMindFulness.Data.Dependencies.Transients;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AMindFulness.Data.Dependencies
{
    public static class AppLibraryConfig
    {
        public static void AddLibraryServices(this IServiceCollection services, string connectionString)
        {
            // DbContexts
            services.AddDbContext<Context>(options =>
                options.UseMySql(connectionString, 
                    new MySqlServerVersion(new Version(8, 0, 23)))); 

            // Repositories
            services.AddScoped<IMindfulnessRepository, MindfulnessRepository>();
            
            // Transients
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            //ViewModels
        }
    }
}