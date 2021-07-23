using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace testcsharp.Helper
{
    public class DistansAPI
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8403/api/DistanDatens")
            };
            return Client;
        }
    }
}
