using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    public interface ApiHelper
    {
        Task<List<TodoResponse>> getTodo<TodoResponse>();
    }
}
