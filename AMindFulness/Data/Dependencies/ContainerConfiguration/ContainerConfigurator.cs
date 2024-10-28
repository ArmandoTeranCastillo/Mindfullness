using AMindFulness.Data.Dependencies.ContainerConfiguration.Modules;
using AMindFulness.Data.Dependencies.Transients;
using Autofac;

namespace AMindFulness.Data.Dependencies.ContainerConfiguration
{
    public static class ContainerConfigurator
    {
        public static IContainer ConfigureContainer()
        {
            ContainerBuilder builder = new();
            
            //Register all services
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            
            //Register all modules
            builder.RegisterModule<PensamientosModule>();
            
            return builder.Build();
        }
    }
}