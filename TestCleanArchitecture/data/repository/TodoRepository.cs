using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.datasource;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.model;
using TestCleanArchitecture.domain.repository;

namespace TestCleanArchitecture.data.repository
{
    internal class TodoRepository : ITodoRepository
    {
        TodoDataSource dataSource;
        TodoRepository(TodoDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public Task<TodoResponse> getTodo()
        {
            return this.dataSource.getTodo();
        }
    }
}
