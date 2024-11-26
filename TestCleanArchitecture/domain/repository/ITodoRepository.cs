using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.domain.repository
{
    public interface ITodoRepository
    {
        Task<List<TodoResponse>> getTodo<TodoResponse>();
    }
}
