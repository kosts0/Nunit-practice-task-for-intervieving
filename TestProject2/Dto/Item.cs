using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProject2.Dto
{
    public class Item
    {
        [JsonProperty("cat")]
        public string Category { get; set; }
        [JsonProperty("desc")]
        public string Desc { get; set; }
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("img")]
        public string Image { get; set; }
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
