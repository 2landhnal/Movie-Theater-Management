using Firebase.Database.Query;

namespace Movie_Theater_Management
{
    internal class TheaterManager
    {
        public static async Task<List<Room>> GetAllRooms()
        {
            List<Room> list = new List<Room>();
            var rooms = await Helper.GetDataTable<Room>($"rooms");
            foreach (var r in rooms)
            {
                list.Add(r.Object);
            }
            return list;
        }

        public static async Task<List<Room>> GetAllRoomByTheater(String theaterId)
        {
            List<Room> list = new List<Room>();
            var rooms = await Firebase_Connect.client
                                                .Child("rooms")
                                                .OrderByKey()
                                                .StartAt(theaterId + "_")
                                                .OnceAsync<Room>();
            foreach (var r in rooms)
            {
                list.Add(r.Object);
            }
            return list;
        }
    }
}
