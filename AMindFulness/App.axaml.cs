using System;
using AMindFulness.Data;
using AMindFulness.MVVM.Views;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AMindFulness
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            ServiceCollection services = new();
            
            //Configurar base de datos
            services.AddDbContext<Context>(options =>
                options.UseMySql("Server=sql3.freemysqlhosting.net;Database=sql3741179;User ID=sql3741179;Password=nbmBniYtSG;Port=3306;TrustServerCertificate=true;", 
                    new MySqlServerVersion(new Version(8, 0, 21))));
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}