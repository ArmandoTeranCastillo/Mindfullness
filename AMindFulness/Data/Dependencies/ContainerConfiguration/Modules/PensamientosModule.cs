using AMindFulness.MVVM.ViewModels.ViewModels;
using Autofac;

namespace AMindFulness.Data.Dependencies.ContainerConfiguration.Modules
{
    public class PensamientosModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PensamientosVm>().AsSelf();
        }
    }
}