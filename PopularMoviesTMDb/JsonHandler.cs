using System;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace PopularMoviesTMDb
{
    class JsonHandler
    {
       // Method to query TMDb for popular movies and parse the JSON-reply into java objects
        public List<Movie> createPopularMoviesListFromJsonString(String apiKey)
        {
            List<Movie> popularMovies = new List<Movie>();
            TMDbClient tc = new TMDbClient();
            String jsonString = tc.showPopularMoviesQuery(apiKey); // requesting data from TMDb
            var message = JsonConvert.DeserializeObject<Message>(jsonString);
            System.Console.WriteLine("Total results: " + message.total_results);
            foreach (var result in message.Results)
            {
                // System.Console.WriteLine($"Movie title: {result.title}");
                int id = result.id;
                String title = result.title;
                //  String overview = result.overview;
                //  Double popularity = result.popularity;
                // creating movie object
                Movie movie = new Movie();
                movie = new Movie(id, title);
                // Adding movie to top rated movie list
                popularMovies.Add(movie);
            }
            return popularMovies;
        }

        // Method to query TMDb for top rated movies and parse the JSON-reply into java objects
        public List<Movie> createTopRatedMoviesListFromJsonString(String apiKey)
        {
            List<Movie> topRatedMovies = new List<Movie>();
            TMDbClient tc = new TMDbClient();
            String jsonString = tc.showTopRatedMoviesQuery(apiKey); // requesting data from TMDb
            var message = JsonConvert.DeserializeObject<Message>(jsonString);
            System.Console.WriteLine("Total results: " + message.total_results);
            foreach (var result in message.Results)
            {
                //  System.Console.WriteLine($"Movie title: {result.title}");
                int id = result.id;
                String title = result.title;
                //  String overview = result.overview;
                //  Double popularity = result.popularity;
                // Creating movie object
                Movie movie = new Movie();
                movie = new Movie(id, title);
                // Adding movie to top rated movie list
                topRatedMovies.Add(movie);
            }
            return topRatedMovies;
        }
       
        /*
       // Method to query TMDb for top rated movies and parse the JSON-reply into java objects
       // This method should be used when apiKey is read from file/settings/properties
        public List<Movie> createTopRatedMoviesListFromJsonString()
        {
            List<Movie> topRatedMovies = new List<Movie>();
            TMDbClient tc = new TMDbClient();
            String jsonString = tc.showTopRatedMoviesQuery();
            var message = JsonConvert.DeserializeObject<Message>(jsonString);
            System.Console.WriteLine("Total results: " + message.total_results);
            foreach (var result in message.Results)
            {
              //  System.Console.WriteLine($"Movie title: {result.title}");
                int id = result.id;
                String title = result.title;
                //  String overview = result.overview;
                //  Double popularity = result.popularity;
                Movie movie = new Movie();
                movie = new Movie(id, title);
                topRatedMovies.Add(movie);
            }
            return topRatedMovies;
        }
        
       // Method to query TMDb for popular movies and parse the JSON-reply into java objects
       // This method should be used when apiKey is read from file/settings/properties
       public List<Movie> createPopularMoviesListFromJsonString()
       {
           List<Movie> popularMovies = new List<Movie>();
           TMDbClient tc = new TMDbClient();
           String jsonString = tc.showPopularMoviesQuery();
           var message = JsonConvert.DeserializeObject<Message>(jsonString);
           System.Console.WriteLine("Total results: " + message.total_results);
           foreach(var result in message.Results)
           {
              // System.Console.WriteLine($"Movie title: {result.title}");
               int id = result.id;
               String title = result.title;
               //  String overview = result.overview;
               //  Double popularity = result.popularity;
               Movie movie = new Movie();
               movie = new Movie(id, title);
               popularMovies.Add(movie);
           }
           return popularMovies;
       }
       */
    }
}

