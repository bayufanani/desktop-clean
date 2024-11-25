using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.network.apihelper;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.data.source.remote.datasource
{
    internal class TodoDataSource
    {
        ApiHelper apiHelper {  get; set; }

        public Task<TodoResponse> getTodo()
        {
            return apiHelper.getTodo();
        }
    }
}
