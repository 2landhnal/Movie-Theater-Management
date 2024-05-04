
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

namespace Movie_Theater_Management
{
    public class Movie
    {
        public int id { get; set; }
        public List<String> origin_country { get; set; }
        public List<Genre> genres { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public string poster_path { get; set; }
        public string title { get; set; }
        public int runtime { get; set; }

    }

    public class Genre
    {
        public string id;
        public string name;
    }
    public class GenreSearchObj
    {
        public List<Genre> genres { get; set; }
    }

    public class MoviePopularSearchObj
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }

    public class Query
    {
        public async Task<RestResponse> GetResponseFromURLAsync(string s)
        {
            var options = new RestClientOptions(s);
            RestClient client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI0ODc2MTViOGU2YzE4NjRjZGJkOTY5ZGZiNjQxYjgxMiIsInN1YiI6IjYxZGU3MTU0OTQ1YzIwMDA0MDZmMTI3NCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.VfjDT7vvp3KImoedAsA8aK1QIVBFjnGkDlHJ_u69beo");
            RestResponse response = await client.GetAsync(request, cancellationToken);
            return response;
        }
    }
}
