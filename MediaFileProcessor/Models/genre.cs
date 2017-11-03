using Newtonsoft.Json.Linq;

namespace MediaFileProcessor.Models
{
    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
        public Genre(string json)
        {
            JObject jObject = JObject.Parse(json);
            id = (int)jObject["id"];
            name = (string)jObject["name"];
        }
    }
}
