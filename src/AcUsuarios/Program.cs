    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabasaeManager;
using DatabasaeManager.Entidades;
using Infrastructure;
using Microsoft.Extensions. DependencyInjection;

namespace AcUsuarios
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            FormUsuario formUsuario = serviceProvider.GetRequiredService<FormUsuario>();
            Usuarios usuarios = serviceProvider.GetRequiredService<Usuarios>();
            UserMediator mediator = new UserMediator(formUsuario, usuarios);
            Application.Run(usuarios);
        }

        static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<FormUsuario>();
            services.AddScoped<Usuarios>();
            services.AddSingleton<IRepoUsuario<Usuario>,RepoUsuario>();
        }

    }
}
