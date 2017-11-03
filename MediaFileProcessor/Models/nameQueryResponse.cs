using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class NameQueryResponse
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public JArray results { get; set; }

        public NameQueryResponse(string json)
        {
            JObject jObject = JObject.Parse(json);
            page = (int)jObject["page"];
            total_results = (int)jObject["total_results"];
            total_pages = (int)jObject["total_pages"];
            results = (JArray)jObject["results"];
        }
    }
}
