﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    internal class ApiHelperImpl : ApiHelper
    {
        ApiService apiService { get; }

        public Task<TodoResponse> getTodo()
        {
            return apiService.get<TodoResponse>("/todos");
        }
    }
}
