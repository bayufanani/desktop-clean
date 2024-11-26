using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.datasource;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.repository;

namespace TestCleanArchitecture.data.repository
{
    public class TodoRepository : ITodoRepository
    {
        TodoDataSource dataSource;
        public TodoRepository(TodoDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public Task<List<TodoResponse>> getTodo<TodoResponse>()
        {
            return this.dataSource.getTodo<TodoResponse>();
        }
    }
}
