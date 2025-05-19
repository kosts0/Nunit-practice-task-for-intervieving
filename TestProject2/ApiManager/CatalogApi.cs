using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Dto;
using RestSharp;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Allure.NUnit.Attributes;

namespace TestProject2.ApiManager
{
    public class CatalogApi : ApiManagerBase
    {

        public CatalogApi() : base("https://api.demoblaze.com")
        {
        }
        [AllureStep("Получение списка Items")]
        public Item[] ItemList()
        {
            RestRequest request = new RestRequest("entries", Method.Get);
            var responce =  _client.Get(request);
            var content = responce.Content;
            Item[] result = null;
            JToken json = JToken.Parse(content);
            var arrsy = json.SelectToken("$..Items");
            result = JsonConvert.DeserializeObject<Item[]>(arrsy.ToString());
            return result;
        }
    }
}
