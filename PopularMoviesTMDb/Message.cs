using System.Collections.Generic;

namespace PopularMoviesTMDb
{
    class Message
    {
        // Non-standard naming due to json parsing
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<Results> Results { get; set; }
    }
}
