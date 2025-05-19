using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.ApiManager
{
    public class ApiManagerBase
    {
        protected ApiManagerBase(string baseUrl)
        {
            _client = new RestSharp.RestClient(baseUrl);
        }
        protected RestClient _client;
        protected string baseUrl { get; set; }
    }
}
