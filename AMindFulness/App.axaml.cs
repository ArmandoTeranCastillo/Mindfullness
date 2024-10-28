using System;
using AMindFulness.Data.Dependencies.ContainerConfiguration;
using AMindFulness.MVVM.Views;
using Autofac;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Configuration;

namespace AMindFulness
{
    public class App : Application
    {
        public static IContainer Container { get; private set; } = null!;
        
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            // Cargar configuración desde appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Asegura que el directorio base sea correcto
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener la cadena de conexión
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            
            if (connectionString == null)
            {
                throw new ArgumentNullException(null, "La cadena de conexión no puede ser nula");
            }
            
            //Iniciar Inyección de Dependencias
            Container = ContainerConfigurator.ConfigureContainer(connectionString);
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}