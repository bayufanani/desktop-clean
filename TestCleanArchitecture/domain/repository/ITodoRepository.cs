using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.model;

namespace TestCleanArchitecture.domain.repository
{
    internal interface ITodoRepository
    {
        Task<TodoResponse> getTodo();
    }
}
