using Firebase.Database;
using Firebase.Database.Query;

namespace Movie_Theater_Management
{
    internal class ScheduleManager
    {
        public static async Task<IReadOnlyCollection<FirebaseObject<Schedule>>?> getScheduleByDate(String date)
        {
            try
            {
                var _client = Firebase_Connect.client;
                if (_client == null) return null;
                var result = await _client
                  .Child("schedules")
                  .OrderBy("date")
                  .EqualTo(date)
                  .OnceAsync<Schedule>();
                //MessageBox.Show("2");
                return result;
            }
            catch (Exception ex)
            {
                var _client = Firebase_Connect.client;
                if (_client == null) return null;
                var result = await _client
                  .Child("schedules")
                  .OrderBy("date")
                  .EqualTo(date)
                  .OnceAsListAsync<Schedule>();
                List<FirebaseObject<Schedule>> res = new List<FirebaseObject<Schedule>>();
                foreach (var item in result)
                {
                    if (item == null || item.Object == null) continue;
                    res.Add(item);
                }
                //MessageBox.Show("1");
                return res;
            }
        }
    }
}
