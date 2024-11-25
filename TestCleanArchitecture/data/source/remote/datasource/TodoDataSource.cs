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
        ApiHelper apiHelper;

        TodoDataSource(ApiHelper apiHelper)
        {
            this.apiHelper = apiHelper;
        }

        public Task<TodoResponse> getTodo()
        {
            return this.apiHelper.getTodo();
        }
    }
}
