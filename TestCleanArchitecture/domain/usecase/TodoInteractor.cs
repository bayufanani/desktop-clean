using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.repository;

namespace TestCleanArchitecture.domain.usecase
{
    public class TodoInteractor : TodoUsecase
    {
        ITodoRepository repository;
        public TodoInteractor(ITodoRepository repository)
        {
            this.repository = repository;
        }

        public Task<List<TodoResponse>> getTodo<TodoResponse>()
        {
            return this.repository.getTodo<TodoResponse>();
        }
    }
}
