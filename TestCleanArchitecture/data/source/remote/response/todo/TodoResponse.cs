using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCleanArchitecture.data.source.remote.response.todo
{
    internal class TodoResponse
    {
        class Todo
        {
            int userId { get; set; }
            int id { get; set; }
            string title { get; set; }
            bool completed { get; set; }
        }

        List<Todo> todo { get; set; }
    }
}
