using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.repository;

namespace TestCleanArchitecture.domain.usecase
{
    internal class TodoInteractor : TodoUsecase
    {
        ITodoRepository repository;
        TodoInteractor(ITodoRepository repository)
        {
            this.repository = repository;
        }
        public Task<TodoResponse> getTodo()
        {
            return this.repository.getTodo();
        }
    }
}
