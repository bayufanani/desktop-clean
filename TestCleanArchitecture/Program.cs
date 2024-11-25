using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestCleanArchitecture.data.repository;
using TestCleanArchitecture.data.source.remote.network.apihelper;
using TestCleanArchitecture.domain.repository;
using TestCleanArchitecture.domain.usecase;

namespace TestCleanArchitecture
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HostApplicationBuilder builder = new HostApplicationBuilder();
            builder.Services.AddSingleton<ApiService, ApiServiceImpl>();
            builder.Services.AddSingleton<ApiHelper, ApiHelperImpl>();
            builder.Services.AddSingleton<ITodoRepository, TodoRepository>();
            builder.Services.AddSingleton<TodoUsecase, TodoInteractor>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login frm = new Login();
            frm.Show();
            Application.Run();
        }
    }
}
