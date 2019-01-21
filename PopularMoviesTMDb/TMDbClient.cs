using System;
using System.Net;
using System.IO;

namespace PopularMoviesTMDb
{
    class TMDbClient
    {
        // URL (parts) as static strings for ease of use and more readable code.
        private static String popularMoviesUrlStart = "https://api.themoviedb.org/3/movie/popular?api_key=";
        private static String topRatedMoviesUrlStart = "https://api.themoviedb.org/3/movie/top_rated?api_key=";
        private static String urlEnding = "&page=1";

        // Query TMDb for popular movies
        public String showPopularMoviesQuery(String apiKey)
        {
            TMDbClient tMDbClient = new TMDbClient();
            String popularMoviesUrl = popularMoviesUrlStart + apiKey + urlEnding;
            String json = Get(popularMoviesUrl);
            return json;
        }

        // Query TMDb for top rated movies
        public String showTopRatedMoviesQuery(String apiKey)
        {
            TMDbClient tMDbClient = new TMDbClient();
            String topRatedMoviesUrl = topRatedMoviesUrlStart + apiKey + urlEnding;
            String json = Get(topRatedMoviesUrl);
            return json;
        }
      

        public String Get(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //  request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }

        }

       
    }
}
