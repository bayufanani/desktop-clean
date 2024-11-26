using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    public class ApiHelperImpl : ApiHelper
    {
        ApiService apiService;
        public ApiHelperImpl(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public Task<List<TodoResponse>> getTodo<TodoResponse>()
        {
            return this.apiService.get<List<TodoResponse>>("/todos");  
        }
    }
}
