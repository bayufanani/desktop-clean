using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestCleanArchitecture.data.repository;
using TestCleanArchitecture.data.source.remote.datasource;
using TestCleanArchitecture.data.source.remote.network.apihelper;
using TestCleanArchitecture.domain.repository;
using TestCleanArchitecture.domain.usecase;
using TestCleanArchitecture.ui;

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
            var services = new ServiceCollection();

            services.AddSingleton<ApiService, ApiServiceImpl>();
            services.AddSingleton<ApiHelper, ApiHelperImpl>();
            services.AddSingleton<ITodoRepository, TodoRepository>();
            services.AddSingleton<TodoUsecase, TodoInteractor>();
            services.AddSingleton<TodoDataSource>();

            services.AddSingleton<Login>();
            services.AddSingleton<Dashboard>();

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login frm = serviceProvider.GetRequiredService<Login>();
            frm.Show();
            Application.Run();
        }
    }
}
