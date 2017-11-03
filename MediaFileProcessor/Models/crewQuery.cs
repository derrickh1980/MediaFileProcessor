using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class CrewQuery
    {
        public int id { get; set; }
        public JArray cast { get; set; }
        public JArray crew { get; set; }
        public CrewQuery(string json)
        {
            JObject jObject = JObject.Parse(json);
            id = (int)jObject["id"];
            cast = (JArray)jObject["cast"];
            crew = (JArray)jObject["crew"];
        }
    }
}
