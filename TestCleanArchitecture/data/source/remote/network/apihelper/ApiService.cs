using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    internal interface ApiService
    {
        Task<T> get<T>(String url);
    }
}
