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
        ITodoRepository repository { get; set; }
        public Task<TodoResponse> getTodo()
        {
            return repository.getTodo();
        }
    }
}
