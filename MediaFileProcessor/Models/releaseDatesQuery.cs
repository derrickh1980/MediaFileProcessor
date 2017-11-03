using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class ReleaseDatesQuery
    {
        public int id { get; set; }
        public JArray results { get; set; }
        public ReleaseDatesQuery(string json)
        {
            JObject jObject = JObject.Parse(json);
            id = (int)jObject["id"];
            results = (JArray)jObject["results"];
        }
    }
}
