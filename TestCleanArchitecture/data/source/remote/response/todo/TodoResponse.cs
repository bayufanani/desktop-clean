using System.Collections.Generic;

namespace TestCleanArchitecture.data.source.remote.response.todo
{
    public class TodoResponse
    {

        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

    }
}
