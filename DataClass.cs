using RestSharp;

namespace Movie_Theater_Management
{

    public class MovieQueryObj
    {
        public int page;
        public List<MoviePreETLObj> results;
    }

    public class MoviePreETLObj
    {
        public int id { get; set; }
        public List<int> genre_ids { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public string poster_path { get; set; }
        public string title { get; set; }
        public int runtime { get; set; }
        public float vote_average;

        public Movie ConvertToMovie()
        {
            return new Movie(id, original_language, overview, release_date, poster_path, title, runtime, vote_average);
        }
    }

    public class Room
    {
        public string id;
        public string name;
        public string theaterId;
        public int room_type;

        public Room(string id, string name, string theaterId, int room_type)
        {
            this.id = id;
            this.name = name;
            this.theaterId = theaterId;
            this.room_type = room_type;
        }

        static public Room GetRoom(int index, string theaterId, int room_type, string name)
        {
            string id = $"{theaterId}_{index}";
            return new Room(id, name, theaterId, room_type);
        }
    }

    public class Schedule
    {
        public string movieId;
        public string roomId;
        public string date;
        public int time;
        public string id;

        public Schedule(string movieId, string roomId, string date, int time, string id)
        {
            this.movieId = movieId;
            this.roomId = roomId;
            this.date = date;
            this.time = time;
            this.id = id;
        }
    }

    public class ScheduleDetail
    {
        public string scheduleId;
        public string date;
        public int time;

        public ScheduleDetail(string scheduleId, string date, int time)
        {
            this.scheduleId = scheduleId;
            this.date = date;
            this.time = time;
        }
    }

    public class Room_Seat
    {
        public string roomId;
        public string id;
        public int seatType;
        public string name;

        public Room_Seat(string roomId, string id, int seatType, string name)
        {
            this.roomId = roomId;
            this.id = id;
            this.seatType = seatType;
            this.name = name;
        }

        public static Room_Seat createRoomSeat(string roomId, string name, int seatType)
        {
            Room_Seat res = new Room_Seat(roomId, "", seatType, name);
            res.roomId = roomId;
            res.name = name;
            res.seatType = seatType;
            res.id = roomId + "_" + name;
            return res;
        }
    }

    public class PaymentMethod
    {
        public string id;
        public string name;
        public string iconLink;

        public PaymentMethod(string id, string name, string iconLink)
        {
            this.id = id;
            this.name = name;
            this.iconLink = iconLink;
        }
    }
    public class Ticket
    {
        public string id;
        public string scheduleId;
        public string seatId;
        public string billId;
        public bool ordered;

        public Ticket(string id, string scheduleId, string seatId, string billId = "null", bool ordered = false)
        {
            this.id = id;
            this.scheduleId = scheduleId;
            this.seatId = seatId;
            this.billId = billId;
            this.ordered = ordered;
        }
    }

    public class TicketPrice_Schedule
    {
        public int seatType;
        public int price;
        public string scheduleId;

        public TicketPrice_Schedule(int seatType, int price, string scheduleId)
        {
            this.seatType = seatType;
            this.price = price;
            this.scheduleId = scheduleId;
        }
    }

    public class Movie
    {
        public int id { get; set; }
        public string original_language { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public string poster_path { get; set; }
        public string title { get; set; }
        public int runtime { get; set; }
        public float vote_average;

        public string streaming_state { get; set; }

        public Movie(int id, string original_language, string overview, string release_date, string poster_path, string title, int runtime, float vote_average, string streaming_state = "Streaming")
        {
            this.id = id;
            this.original_language = original_language;
            this.overview = overview;
            this.release_date = release_date;
            this.poster_path = poster_path;
            this.title = title;
            this.runtime = runtime;
            this.streaming_state = streaming_state;
            this.vote_average = vote_average;
        }
    }

    public class Movie_Genre
    {
        public int movieId;
        public int genreId;
        public Movie_Genre(int movieId, int genreId)
        {
            this.movieId = movieId;
            this.genreId = genreId;
        }
    }

    public class CreditQuery
    {
        public int id;
        public List<Cast> cast;
        public List<Crew> crew;
    }
    public class Credit
    {
        public string id;
        public int movieID;
        public int particapantID;
        public int departmentID;

        public Credit(string id, int movieID, int particapantID, int departmentID)
        {
            this.id = id;
            this.movieID = movieID;
            this.particapantID = particapantID;
            this.departmentID = departmentID;
        }
    }

    public class Crew
    {
        public int gender;
        public int id;
        public string name;
        public string profile_path;
        public string credit_id;
        public string department;
        public string job;

        public Crew(int gender, int id, string name, string profile_path, string credit_id, string department, string job)
        {
            this.gender = gender;
            this.id = id;
            this.name = name;
            this.profile_path = profile_path;
            this.credit_id = credit_id;
            this.department = department;
            this.job = job;
        }
        public Participant ConvertToParticipant()
        {
            return new Participant(gender, id, name, profile_path);
        }
    }
    public class Participant
    {
        public int gender;
        public int id;
        public string name;
        public string profile_path;

        public Participant(int gender, int id, string name, string profile_path)
        {
            this.gender = gender;
            this.id = id;
            this.name = name;
            this.profile_path = profile_path;
        }
    }

    public class Theater
    {
        public string id;
        public string name;
        public string added_at;
        public string loc;
        public float lat;
        public float lon;

        public Theater(string id, string name, string added_at, string loc, float lat, float lon)
        {
            this.id = id;
            this.name = name;
            this.added_at = added_at;
            this.loc = loc;
            this.lat = lat;
            this.lon = lon;
        }
    }
    public class Account
    {
        public string username;
        public string name;
        public string password;
        public string email;
        public string birthday;
        public string gender;
        public int role_id;
        public string join_at;

        public Account(string username, string name, string password, string email, string birthday, string gender, int role_id, string join_at)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.email = email;
            this.birthday = birthday;
            this.gender = gender;
            this.role_id = role_id;
            this.join_at = join_at;
        }
    }

    public class Cast
    {
        public int gender;
        public int id;
        public string known_for_department;
        public string name;
        public string profile_path;
        public string character;
        public string credit_id;

        public Cast(int gender, int id, string known_for_department, string name, string profile_path, string character, string credit_id)
        {
            this.gender = gender;
            this.id = id;
            this.known_for_department = known_for_department;
            this.name = name;
            this.profile_path = profile_path;
            this.character = character;
            this.credit_id = credit_id;
        }
        public Participant ConvertToParticipant()
        {
            return new Participant(gender, id, name, profile_path);
        }
    }
    public class MovieDetail
    {
        public int runtime;
        public MovieDetail(int runtime)
        {
            this.runtime = runtime;
        }
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
            RestResponse response = await client.GetAsync(request);
            return response;
        }
    }
}


