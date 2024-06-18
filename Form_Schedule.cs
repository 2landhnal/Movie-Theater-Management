using Firebase.Database.Query;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Schedule : Form
    {
        DataTable dt = new DataTable();
        Query query = new Query();
        public Form_Schedule()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("movieId");
            dt.Columns.Add("roomId");
            dt.Columns.Add("date");
            dt.Columns.Add("time");

            InitializeComponent();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Movie ID";
            dataGridView1.Columns[2].HeaderText = "Room ID";
            dataGridView1.Columns[3].HeaderText = "Date";
            dataGridView1.Columns[4].HeaderText = "Time";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = Helper.globalTimeFormat; // Only use hours and minutes
        }

        async Task RandomAddScheduleAsyncByRoom()
        {
            var roomList = await TheaterManager.GetAllRooms();
            var movieList = await MovieManager.GetMovieStreamingList();
            Random rnd = new Random();
            foreach (Room room in roomList)
            {
                DateTime date = DateTime.Now.AddDays(rnd.Next(1, 10));
                int startTime = Helper.RoundDown(rnd.Next(480, 1321), 5);
                Movie movie = movieList[rnd.Next(0, movieList.Count)];
                int endTime = Helper.RoundUp(startTime + movie.runtime, 5) + 30;
                string id = movie.id.ToString() + room.id + Helper.getDateGlobalFormat(date) + startTime.ToString();


                Schedule schedule = new Schedule(
                    movieId: movie.id.ToString(),
                    roomId: room.id,
                    date: Helper.getDateGlobalFormat(date),
                    time: startTime,
                    id: id
                    );

                var table = await Helper.GetDataTable<Schedule>("schedules");
                var scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{schedule.date}").Child(room.id).OnceAsync<ScheduleDetail>();
                bool check = false;
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == schedule.id)
                    {
                        check = true; break;
                    }
                }
                if (check) continue;
                foreach (var tmp in scheduleDetailTable)
                {
                    if ((tmp.Object.time - startTime) * (tmp.Object.time - endTime) <= 0)
                    {
                        check = true; break;
                    }
                }
                if (check) continue;
                if (endTime >= 1440)
                {
                    scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{Helper.getDateGlobalFormat(date.AddDays(1))}").Child(room.id).OnceAsync<ScheduleDetail>();
                    foreach (var tmp in scheduleDetailTable)
                    {
                        if ((tmp.Object.time - 0) * (tmp.Object.time - endTime % 1440) <= 0)
                        {
                            check = true; break;
                        }
                    }
                    if (check) continue;
                }

                await Firebase_Connect.client
                    .Child("schedules")
                    .Child(schedule.id)
                    .PutAsync(schedule);
                for (int i = startTime; i <= endTime; i += 5)
                {
                    ScheduleDetail scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: schedule.date,
                        time: i
                        );
                    if (i >= 1440)
                    {
                        scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: Helper.getDateGlobalFormat(date.AddDays(1)),
                        time: i % 1440);
                    }
                    await Firebase_Connect.client
                    .Child("schedule_details")
                    .Child(scheduleDetail.date)
                     .Child(schedule.roomId)
                    .Child(scheduleDetail.time.ToString())
                    .PutAsync(scheduleDetail);
                }
                await AddTicketPriceForScheduleAsync(schedule);
                await AddTicketForRoomAsync(schedule.roomId, schedule);
                MessageBox.Show("Đã thêm mới thành công schedule");
            }

            UpdateDtgv();

            Reset();
        }
        async Task RandomAddScheduleAsyncByMovie()
        {
            var roomList = await TheaterManager.GetAllRooms();
            var movieList = await MovieManager.GetMovieStreamingList();
            Dictionary<String, Dictionary<String, HashSet<int>>> roomDateTimeDic = new Dictionary<string, Dictionary<string, HashSet<int>>>();
            Random rnd = new Random();
            int startTime, endTime;
            bool nextSchedule = false;
            string scheduleId;
            String date;
            foreach (var movie in movieList)
            {
                foreach (var room in roomList)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        date = Helper.getDateGlobalFormat(DateTime.Now.AddDays(i));

                        var scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{date}").Child(room.id).OnceAsync<ScheduleDetail>();
                        foreach (var tmp in scheduleDetailTable)
                        {
                            roomDateTimeDic[room.id][date].Add(tmp.Object.time);
                        }
                        for (int j = 480; j <= 1320; j += 5)
                        {
                            startTime = Helper.RoundDown(i, 5);
                            endTime = Helper.RoundUp(startTime + movie.runtime, 5) + 30;
                            for (int k = startTime; k <= (endTime >= 1440 ? 1400 : endTime); k += 5)
                            {
                                if (roomDateTimeDic[room.id][date].Contains(k))
                                {
                                    nextSchedule = true;
                                    break;
                                }
                            }
                            if (endTime >= 1440)
                            {
                                // Do sth here
                            }
                            if (nextSchedule)
                            {
                                nextSchedule = false;
                                continue;
                            }
                            scheduleId = movie.id.ToString() + room.id + date + startTime.ToString();
                            Schedule schedule = new Schedule(
                                movieId: movie.id.ToString(),
                                roomId: room.id,
                                date: date,
                                time: startTime,
                                id: scheduleId
                            );
                        }
                    }
                }
            }

            /*foreach (Room room in roomList)
            {
                DateTime date = DateTime.Now.AddDays(rnd.Next(1, 10));
                int startTime = Helper.RoundDown(rnd.Next(480, 1321), 5);
                Movie movie = movieList[rnd.Next(0, movieList.Count)];
                int endTime = Helper.RoundUp(startTime + movie.runtime, 5) + 30;
                string id = movie.id.ToString() + room.id + Helper.getDateGlobalFormat(date) + startTime.ToString();


                Schedule schedule = new Schedule(
                    movieId: movie.id.ToString(),
                    roomId: room.id,
                    date: Helper.getDateGlobalFormat(date),
                    time: startTime,
                    id: id
                    );

                var table = await Helper.GetDataTable<Schedule>("schedules");
                var scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{schedule.date}").Child(room.id).OnceAsync<ScheduleDetail>();
                bool check = false;
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == schedule.id)
                    {
                        check = true; break;
                    }
                }
                if (check) continue;
                foreach (var tmp in scheduleDetailTable)
                {
                    if ((tmp.Object.time - startTime) * (tmp.Object.time - endTime) <= 0)
                    {
                        check = true; break;
                    }
                }
                if (check) continue;
                if (endTime >= 1440)
                {
                    scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{Helper.getDateGlobalFormat(date.AddDays(1))}").Child(room.id).OnceAsync<ScheduleDetail>();
                    foreach (var tmp in scheduleDetailTable)
                    {
                        if ((tmp.Object.time - 0) * (tmp.Object.time - endTime % 1440) <= 0)
                        {
                            check = true; break;
                        }
                    }
                    if (check) continue;
                }

                await Firebase_Connect.client
                    .Child("schedules")
                    .Child(schedule.id)
                    .PutAsync(schedule);
                for (int i = startTime; i <= endTime; i += 5)
                {
                    ScheduleDetail scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: schedule.date,
                        time: i
                        );
                    if (i >= 1440)
                    {
                        scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: Helper.getDateGlobalFormat(date.AddDays(1)),
                        time: i % 1440);
                    }
                    await Firebase_Connect.client
                    .Child("schedule_details")
                    .Child(scheduleDetail.date)
                     .Child(schedule.roomId)
                    .Child(scheduleDetail.time.ToString())
                    .PutAsync(scheduleDetail);
                }
                await AddTicketPriceForScheduleAsync(schedule);
                await AddTicketForRoomAsync(schedule.roomId, schedule);
            }

            MessageBox.Show("Random done!");
            UpdateDtgv();

            Reset();*/
        }


        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (movieID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập movie id");
                movieID.Focus();
            }
            else if (roomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập room id");
                roomID.Focus();
            }
            else
            {
                int startTime = Helper.RoundDown(Helper.FromTimeToMinutes(timePicker.Value), 5);
                Movie movie = await MovieManager.GetMovieByIdAsync(int.Parse(movieID.Text));
                int endTime = Helper.RoundUp(Helper.FromTimeToMinutes(timePicker.Value) + movie.runtime, 5) + 30;
                string id = movieID.Text + roomID.Text + datePicker.Text + startTime.ToString();
                DateTime date = datePicker.Value;


                Schedule schedule = new Schedule(
                    movieId: movieID.Text,
                    roomId: roomID.Text,
                    date: datePicker.Text,
                    time: startTime,
                    id: id
                    );

                var table = await Helper.GetDataTable<Schedule>("schedules");
                var scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{schedule.date}").Child(schedule.roomId).OnceAsync<ScheduleDetail>();
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == schedule.id)
                    {
                        MessageBox.Show("Schedule id already exist!");
                        return;
                    }
                }
                foreach (var tmp in scheduleDetailTable)
                {
                    if ((tmp.Object.time - startTime) * (tmp.Object.time - endTime) <= 0)
                    {
                        MessageBox.Show("Schedule already exist!");
                        return;
                    }
                }
                if (endTime >= 1440)
                {
                    scheduleDetailTable = await Firebase_Connect.client.Child("schedule_details").Child($"{Helper.getDateGlobalFormat(date.AddDays(1))}").Child(schedule.roomId).OnceAsync<ScheduleDetail>();
                    foreach (var tmp in scheduleDetailTable)
                    {
                        if ((tmp.Object.time - 0) * (tmp.Object.time - endTime % 1440) <= 0)
                        {
                            MessageBox.Show("Schedule already exist!");
                            return;
                        }
                    }
                }

                await Firebase_Connect.client
                    .Child("schedules")
                    .Child(schedule.id)
                    .PutAsync(schedule);
                for (int i = startTime; i <= endTime; i += 5)
                {
                    ScheduleDetail scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: schedule.date,
                        time: i
                        );
                    if (i >= 1440)
                    {
                        scheduleDetail = new ScheduleDetail(
                        scheduleId: schedule.id,
                        date: Helper.getDateGlobalFormat(date.AddDays(1)),
                        time: i % 1440);
                    }
                    await Firebase_Connect.client
                    .Child("schedule_details")
                    .Child(scheduleDetail.date)
                    .Child(schedule.roomId)
                    .Child(scheduleDetail.time.ToString())
                    .PutAsync(scheduleDetail);
                }
                await AddTicketPriceForScheduleAsync(schedule);
                await AddTicketForRoomAsync(schedule.roomId, schedule);
                MessageBox.Show("Đã thêm mới thành công schedule");

                UpdateDtgv();

                Reset();
            }
        }

        async Task AddTicketForRoomAsync(string roomId, Schedule schedule)
        {
            List<Room_Seat> seatList = await TicketManager.GetSeatByRoomId(roomId);
            Ticket newTicket;
            foreach (Room_Seat seat in seatList)
            {
                string tmpId = schedule.id + seat.id;
                newTicket = new Ticket(
                    scheduleId: schedule.id,
                    seatId: seat.id,
                    id: tmpId
                    );
                await Firebase_Connect.client
                    .Child("tickets")
                    .Child(tmpId)
                    .PutAsync(newTicket);
            }
            //MessageBox.Show("Đã thêm mới thành công tickets");
        }
        async Task AddTicketPriceForScheduleAsync(Schedule schedule)
        {
            TicketPrice_Schedule newTicketPrice = new TicketPrice_Schedule(
                    scheduleId: schedule.id,
                    seatType: 1,
                    price: 100
                    );
            await Firebase_Connect.client
                .Child("ticket_price_schedule")
                .Child(schedule.id)
                .Child(newTicketPrice.seatType.ToString())
                .PutAsync(newTicketPrice);

            newTicketPrice = new TicketPrice_Schedule(
                    scheduleId: schedule.id,
                    seatType: 2,
                    price: 150
                    );
            await Firebase_Connect.client
                .Child("ticket_price_schedule")
                .Child(schedule.id)
                .Child(newTicketPrice.seatType.ToString())
                .PutAsync(newTicketPrice);

            //MessageBox.Show("Đã thêm mới thành công ticket prices");
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            UpdateDtgv();
            //await RandomAddScheduleAsyncByRoom();
            //await RandomAddScheduleAsyncByMovie();
        }

        async void UpdateDtgv()
        {
            dt.Rows.Clear();
            try
            {
                var table = await Helper.GetDataTable<Schedule>("schedules");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["movieId"] = roww.Object.movieId;
                    row["roomId"] = roww.Object.roomId;
                    row["date"] = roww.Object.date;
                    row["time"] = roww.Object.time;
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void Reset()
        {
            movieID.Items.Clear();
            roomID.Items.Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (movieID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                movieID.Focus();
            }
            else if (roomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                roomID.Focus();
            }
            else
            {
                var genre = new Genre
                {
                    id = movieID.Text,
                    name = roomID.Text
                };
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == genre.id)
                    {
                        await Firebase_Connect.client
                            .Child("genres")
                            .Child(genre.id)
                            .PutAsync(genre);

                        MessageBox.Show($"Update genre {tmp.Object.id} successfully");

                        UpdateDtgv();

                        Reset();
                        return;
                    }
                }

                MessageBox.Show("Genre id isn't exist!");
                return;
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (movieID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                movieID.Focus();
            }
            else
            {
                var genre = new Genre
                {
                    id = movieID.Text,
                    name = roomID.Text
                };
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == genre.id)
                    {
                        await Firebase_Connect.client
                    .Child("genres")
                    .Child(genre.id)
                    .DeleteAsync();

                        MessageBox.Show("Delete successfully!");

                        UpdateDtgv();

                        Reset();
                        return;
                    }
                }
                MessageBox.Show("Id not invalid!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            movieID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            roomID.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private async void Form_Schedule_Load(object sender, EventArgs e)
        {
            movieID.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            var table = await Helper.GetDataTable<Movie>("movies");
            List<string> movieIDList = new List<string>();
            foreach (var tmp in table)
            {
                movieIDList.Add(tmp.Object.id.ToString() + $" ({tmp.Object.title})");
            }
            movieID.AutoCompleteCustomSource.AddRange(movieIDList.ToArray());
            movieID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            movieID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            movieID.Leave += (s, ev) => HandleAutoCompleteTextChange(movieID);

            roomID.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            var roomTable = await Helper.GetDataTable<Room>("rooms");
            List<Room> roomList = new List<Room>();
            foreach (var tmp in roomTable)
            {
                roomList.Add(tmp.Object);
            }
            List<string> roomIDList = new List<string>();
            foreach (var tmp in roomList)
            {
                roomIDList.Add(tmp.id);
            }
            //MessageBox.Show(roomIDList.Count.ToString());
            roomID.AutoCompleteCustomSource.AddRange(roomIDList.ToArray());
            roomID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            roomID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void HandleAutoCompleteTextChange(ComboBox movieID)
        {
            string text = movieID.Text;

            string[] splits = text.Split(" ");

            movieID.Text = splits[0];
        }
    }
}
