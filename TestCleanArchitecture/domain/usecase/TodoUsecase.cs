using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.data.source.remote.response.todo;

namespace TestCleanArchitecture.domain.usecase
{
    internal interface TodoUsecase
    {
        Task<TodoResponse> getTodo();
    }
}
