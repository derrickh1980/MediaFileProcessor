using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string tiimdbVotestle { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }

        public Movie(string json)
        {
            JObject jObject = JObject.Parse(json);
            Title = (string) jObject["Title"];
            Year = (string)jObject["Year"];
            Rated = (string)jObject["Rated"];
            Released = (string)jObject["Released"];
            Runtime = (string)jObject["Runtime"];
            Genre = (string)jObject["Genre"];
            Director = (string)jObject["Director"];
            Writer = (string)jObject["Writer"];
            Actors = (string)jObject["Actors"];
            Plot = (string)jObject["Plot"];
            Language = (string)jObject["Language"];
            Country = (string)jObject["Country"];
            Awards = (string)jObject["Awards"];
            Poster = (string)jObject["Poster"];
            Metascore = (string)jObject["Metascore"];
            imdbRating = (string)jObject["imdbRating"];
            tiimdbVotestle = (string)jObject["tiimdbVotestle"];
            imdbID = (string)jObject["imdbID"];
            Type = (string)jObject["Type"];
        }
    }
}
