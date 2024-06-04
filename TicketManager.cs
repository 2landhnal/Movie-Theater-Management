using Firebase.Database.Query;

namespace Movie_Theater_Management
{
    internal class TicketManager
    {
        public static async Task<List<Room_Seat>> GetSeatByRoomId(string id)
        {
            var table = await Firebase_Connect.client.Child("room_seat").Child(id).OnceAsync<Room_Seat>();
            List<Room_Seat> seatList = new List<Room_Seat>();
            foreach (var item in table)
            {
                seatList.Add(item.Object);
            }
            return seatList;
        }
    }
}
