using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.domain.usecase
{
    public interface TodoUsecase
    {
        Task<List<TodoResponse>> getTodo<TodoResponse>();
    }
}
