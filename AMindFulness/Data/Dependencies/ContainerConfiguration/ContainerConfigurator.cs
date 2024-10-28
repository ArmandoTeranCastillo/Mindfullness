using System;
using AMindFulness.Data.Dependencies.ContainerConfiguration.Modules;
using AMindFulness.Data.Dependencies.Services;
using AMindFulness.Data.Dependencies.Transients;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace AMindFulness.Data.Dependencies.ContainerConfiguration
{
    public static class ContainerConfigurator
    {
        public static IContainer ConfigureContainer(string connectionString)
        {
            ContainerBuilder builder = new();

            // Register DbContext
            builder.Register(_ =>
            {
                DbContextOptionsBuilder<Context> optionsBuilder = new();
                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))); 
                return optionsBuilder.Options;
            }).As<DbContextOptions<Context>>().InstancePerLifetimeScope();
    
            // Register all services
            builder.RegisterType<Context>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MindfulnessRepository>().As<IMindfulnessRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
    
            // Register all modules
            builder.RegisterModule<PensamientosModule>();
    
            return builder.Build();
        }
    }
}