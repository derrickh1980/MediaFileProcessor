using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class CrewMember
    {
        public string credit_id { get; set; }
        public string department { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string job { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; }
        public CrewMember(string json)
        {
            JObject jObject = JObject.Parse(json);
            credit_id = (string)jObject["credit_id"];
            department = (string)jObject["department"];
            gender = (int)jObject["gender"];
            id = (int)jObject["id"];
            job = (string)jObject["job"];
            name = (string)jObject["name"];
            profile_path = (string)jObject["profile_path"];
        }
    }
}
