using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Films
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<FilmDetails> Results { get; set; }

    }

    public partial class FilmDetails
    {
        public string Title { get; set; }
        public int Episode_id { get; set; }
        public string Opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTime Release_date{ get; set; }
        public string[] Species { get; set; }
        public string[] Starships { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Characters { get; set; }

    }
}
