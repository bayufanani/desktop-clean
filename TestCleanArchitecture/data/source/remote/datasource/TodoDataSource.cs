using System.Collections.Generic;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.network.apihelper;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.data.source.remote.datasource
{
    public class TodoDataSource
    {
        ApiHelper apiHelper;

        public TodoDataSource(ApiHelper apiHelper)
        {
            this.apiHelper = apiHelper;
        }

        public Task<List<TodoResponse>> getTodo<TodoResponse>()
        {
            return this.apiHelper.getTodo<TodoResponse>();
        }
    }
}
