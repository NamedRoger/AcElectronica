using DatabasaeManager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcClientes
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

            Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            bool isOpenProcess = false;
            IntPtr frameworkHandle;
            if (processes.Length > 1)
            {
                foreach (var process in processes)
                {
                    frameworkHandle = process.MainWindowHandle;
                    if (frameworkHandle != IntPtr.Zero)
                    {
                        isOpenProcess = true;
                    }
                }
            }

            if (!isOpenProcess)
            {
                var services = new ServiceCollection();
                CongifugreServices(services);

                using ServiceProvider serviceProvider = services.BuildServiceProvider();
                Clientes clientes = serviceProvider.GetRequiredService<Clientes>();
                FormularioCliente formularioCliente = serviceProvider.GetRequiredService<FormularioCliente>();

                ClienteMediator clienteMediator = new ClienteMediator(formularioCliente,clientes);

                

                Application.Run(clientes);
            }
        }

        static void CongifugreServices(ServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<FormularioCliente>();
            services.AddScoped<Clientes>();
            services.AddSingleton<IClienteRepo, ClienteRepo>();
        }
    }
}
