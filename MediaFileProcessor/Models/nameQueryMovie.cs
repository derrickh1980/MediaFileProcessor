using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class NameQueryMovie
    {
        public int vote_count { get; set; }
        public int id { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public string title { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public JArray genre_ids { get; set; }
        public string backdrop_path { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }

        public NameQueryMovie(string json)
        {
            JObject jObject = JObject.Parse(json);
            vote_count = (int) jObject["vote_count"];
            id = (int)jObject["id"];
            video = (bool)jObject["video"];
            vote_average = (float)jObject["vote_average"];
            title = (string)jObject["title"];
            popularity = (float)jObject["popularity"];
            poster_path = (string)jObject["poster_path"];
            original_language = (string)jObject["original_language"];
            original_title = (string)jObject["original_title"];
            genre_ids = (JArray)jObject["genre_ids"];
            backdrop_path = (string)jObject["backdrop_path"];
            adult = (bool)jObject["adult"];
            overview = (string)jObject["overview"];
            release_date = (string)jObject["release_date"];
        }
    }
}
