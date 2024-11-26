using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    public interface ApiService
    {
        Task<T> get<T>(String url);
    }
}
