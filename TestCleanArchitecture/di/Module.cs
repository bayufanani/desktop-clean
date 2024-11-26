using Microsoft.Extensions.DependencyInjection;
using TestCleanArchitecture.data.repository;
using TestCleanArchitecture.data.source.remote.datasource;
using TestCleanArchitecture.data.source.remote.network.apihelper;
using TestCleanArchitecture.domain.repository;
using TestCleanArchitecture.domain.usecase;
using TestCleanArchitecture.ui;

namespace TestCleanArchitecture.di
{
    public class Module
    {
        private static ServiceCollection services = new ServiceCollection();

        public Module() {
            services.AddSingleton<ApiService, ApiServiceImpl>();
            services.AddSingleton<ApiHelper, ApiHelperImpl>();
            services.AddSingleton<ITodoRepository, TodoRepository>();
            services.AddSingleton<TodoUsecase, TodoInteractor>();
            services.AddSingleton<TodoDataSource>();

            services.AddSingleton<Login>();
            services.AddSingleton<Dashboard>();
        }


    }
}
