namespace Movie_Theater_Management
{
    internal class TheaterManager
    {
        public static async Task<List<Room>> GetAllRooms()
        {
            var theaters = await Helper.GetDataTable<Theater>("theaters");
            List<Room> list = new List<Room>();
            foreach (var theater in theaters)
            {
                var rooms = await Helper.GetDataTable<Room>($"rooms/{theater.Object.id}");
                foreach (var r in rooms)
                {
                    list.Add(r.Object);
                }
            }
            return list;
        }

        public static async Task<List<Room>> GetAllRoomByTheater(String theaterId)
        {
            List<Room> list = new List<Room>();
            var rooms = await Helper.GetDataTable<Room>($"rooms/{theaterId}");
            foreach (var r in rooms)
            {
                list.Add(r.Object);
            }
            return list;
        }
    }
}
