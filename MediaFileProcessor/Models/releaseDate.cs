using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class ReleaseDate
    {
        public string certification { get; set; }
        public string iso_639_1 { get; set; }
        public string note { get; set; }
        public DateTime release_date { get; set; }
        public int type { get; set; }
        public ReleaseDate(string json)
        {
            JObject jObject = JObject.Parse(json);
            certification = (string)jObject["certification"];
            iso_639_1 = (string)jObject["iso_639_1"];
            note = (string)jObject["note"];
            release_date = (DateTime)jObject["release_date"];
            type = (int)jObject["type"];
        }
    }
}
