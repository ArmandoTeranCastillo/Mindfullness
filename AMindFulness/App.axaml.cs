using System;
using AMindFulness.Data;
using AMindFulness.Data.Dependencies.ContainerConfiguration;
using AMindFulness.MVVM.Views;
using Autofac;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            ServiceCollection services = new();
            
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
            
            // DbContexts
            services.AddDbContext<Context>(options =>
                options.UseMySql(connectionString, 
                    new MySqlServerVersion(new Version(8, 0, 23)))); 
            
            //Iniciar Inyección de Dependencias
            Container = ContainerConfigurator.ConfigureContainer();
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}