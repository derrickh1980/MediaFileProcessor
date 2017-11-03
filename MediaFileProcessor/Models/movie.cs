using Newtonsoft.Json.Linq;

namespace MediaFileProcessor.Models
{
    public class Movie
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public object belongs_to_collection { get; set; }
        public int budget { get; set; }
        public JArray genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public JArray production_companies { get; set; }
        public JArray production_countries { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public JArray spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public Movie(string json)
        {
            JObject jObject = JObject.Parse(json);
            adult = (bool)jObject["adult"];
            backdrop_path = (string)jObject["backdrop_path"];
            belongs_to_collection = (object)jObject["belongs_to_collection"];
            budget = (int)jObject["budget"];
            genres = (JArray)jObject["genres"];
            homepage = (string)jObject["homepage"];
            id = (int)jObject["id"];
            imdb_id = (string)jObject["imdb_id"];
            original_language = (string)jObject["original_language"];
            original_title = (string)jObject["original_title"];
            overview = (string)jObject["overview"];
            popularity = (int)jObject["popularity"];
            poster_path = (string)jObject["poster_path"];
            production_companies = (JArray)jObject["production_companies"];
            production_countries = (JArray)jObject["production_countries"];
            release_date = (string)jObject["release_date"];
            revenue = (int)jObject["revenue"];
            runtime = (int)jObject["runtime"];
            spoken_languages = (JArray)jObject["spoken_languages"];
            status = (string)jObject["status"];
            tagline = (string)jObject["tagline"];
            title = (string)jObject["title"];
            video = (bool)jObject["video"];
            vote_average = (int)jObject["vote_average"];
            vote_count = (int)jObject["vote_count"];

        }
    }
}
