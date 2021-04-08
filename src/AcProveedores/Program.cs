using DatabasaeManager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcProveedores
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
            FormularioProveedores formularioProveedores = serviceProvider.GetRequiredService<FormularioProveedores>();
            Proveedores proveedores = serviceProvider.GetRequiredService<Proveedores>();

            ProveedorMediator proveedorMediator = new(proveedores,formularioProveedores);
            Application.Run(proveedores);
        }

        static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<FormularioProveedores>();
            services.AddScoped<Proveedores>();
            services.AddSingleton<IRepoProveedor,RepoProveedor>();
        }
    }
}
