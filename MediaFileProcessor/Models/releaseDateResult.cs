using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class ReleaseDateResult
    {
        public string iso_3166_1 { get; set; }
        public JArray release_dates { get; set; }
        public ReleaseDateResult(string json)
        {
            JObject jObject = JObject.Parse(json);
            iso_3166_1 = (string)jObject["iso_3166_1"];
            release_dates = (JArray)jObject["release_dates"];
        }
    }
}
