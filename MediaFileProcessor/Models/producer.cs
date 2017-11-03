using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class Producer
    {
        public int id { get; set; }
        public string name { get; set; }
        public Producer(string json)
        {
            JObject jObject = JObject.Parse(json);
            id = (int)jObject["id"];
            name = (string)jObject["name"];
        }
    }
}
