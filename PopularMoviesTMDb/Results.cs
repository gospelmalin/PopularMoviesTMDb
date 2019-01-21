﻿using System;
using System.Collections.Generic;

namespace PopularMoviesTMDb
{
    class Results
    {
        // Non-standard naming due to json parsing
        public int vote_count { get; set; }
        public int id { get; set; }
        public Boolean video { get; set; }
        public Double vote_average { get; set; }
        public String title { get; set; }
        public Double popularity { get; set; }
        public String poster_path { get; set; }
        public String original_language { get; set; }
        public String original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public String backdrop_path { get; set; }
        public Boolean adult { get; set; }
        public String overview { get; set; }
        public String release_date { get; set; }

        public Results() { }

        public Results(int id, String title, String overview, Double popularity)
        {
            this.id = id;
            this.title = title;
            this.overview = overview;
            this.popularity = popularity;
        }

        public Results(int id, String title)
        {
            this.id = id;
            this.title = title;
        }

        public override string ToString()
        {
            return "Id: " + id + "  + Title: " + title;
        }
    }


}


