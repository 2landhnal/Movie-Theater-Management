namespace Movie_Theater_Management
{
    internal class MovieManager
    {
        public static async Task<Movie> GetMovieByIdAsync(int id)
        {
            var table = await Helper.GetDataTable<Movie>("movies");
            foreach (var item in table)
            {
                if (item.Object.id == id)
                {
                    return item.Object;
                }
            }
            return null;
        }
        public static async Task<List<Movie>> GetMovieStreamingList()
        {
            var table = await Helper.GetDataTable<Movie>("movies");
            List<Movie> list = new List<Movie>();
            foreach (var item in table)
            {
                if (item.Object.streaming_state == "Streaming")
                {
                    list.Add(item.Object);
                }
            }
            return list;
        }
    }
}
