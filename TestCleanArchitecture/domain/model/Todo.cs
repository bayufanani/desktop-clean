using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCleanArchitecture.domain.model
{
    internal class Todo
    {
        int userId { get; set; }
        int id { get; set; }
        string title { get; set; }
        bool completed { get; set; }
    }
}
