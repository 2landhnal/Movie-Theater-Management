using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Movie : Form
    {
        FirebaseClient _client;
        DataTable dt;
        Query query;
        static List<String> columns = new List<String> { "id", "title", "original_language", "overview", "release_date", "poster_path", "runtime", "streaming_state", "vote_average" };
        public Form_Movie()
        {
            dt = new DataTable();
            query = new Query();
            for (int i = 0; i < columns.Count; i++)
            {
                dt.Columns.Add(columns[i]);
            }

            _client = Firebase_Connect.client;
            InitializeComponent();

            dataGridView1.DataSource = dt;

            for (int i = 0; i < columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = Helper.ToTitleCase(columns[i]);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else if (textBox_Title.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_Title.Focus();
            }
            else
            {
                //MessageBox.Show(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                var movie = new Movie
                (
                    id: int.Parse(textBox_ID.Text),
                    title: textBox_Title.Text,
                    runtime: int.Parse(textBox_runtime.Text),
                    overview: textBox_Title.Text,
                    release_date: dateTimePicker.Value.ToString("yyyy-MM-dd"),
                    poster_path: textBox_poster.Text,
                    vote_average: float.Parse(textBox_rate.Text),
                    streaming_state: textBox_streaming.Text,
                    original_language: textBox_language.Text
                );
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == movie.id)
                    {
                        MessageBox.Show("Genre id already exist!");
                        return;
                    }
                }

                await _client
                    .Child("movies")
                    .Child(movie.id.ToString())
                    .PutAsync(movie);

                MessageBox.Show("Đã thêm mới thành công");

                UpdateDtgv();

                Reset();
            }
        }

        bool isReleased(string releaseDate)
        {
            return DateTime.Now >= getDate(releaseDate);
        }
        DateTime getDate(string releaseDate)
        {
            return DateTime.ParseExact(releaseDate, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            //FixMovie_Genre();
            UpdateDtgv();
            //await PutMovieList("https://api.themoviedb.org/3/movie/upcoming");
            //PutParticipantAndCredit();
            /*try
            {
                var result = await _client.Child("users").Child("admin").OnceAsync<Account>();
                MessageBox.Show("DOne");
            }
            catch (Exception ex)
            {
                consoleBox.Text += ex.ToString();
            }*/
        }

        async void UpdateDtgv()
        {
            dt.Rows.Clear();
            try
            {
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["title"] = roww.Object.title;
                    row["original_language"] = roww.Object.original_language;
                    row["overview"] = roww.Object.overview;
                    row["release_date"] = roww.Object.release_date;
                    row["poster_path"] = roww.Object.poster_path;
                    row["runtime"] = roww.Object.runtime;
                    row["streaming_state"] = roww.Object.streaming_state;
                    row["vote_average"] = roww.Object.vote_average;
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        async void FixMovie_Genre()
        {
            var table = await _client
              .Child("movie_genre")
              .OnceAsync<Movie_Genre>();
            foreach (var row in table)
            {
                await _client
                            .Child("movie_genre")
                            .Child($"{row.Object.movieId}")
                            .Child($"{row.Object.genreId}")
                            .PutAsync(row.Object as Movie_Genre);
                await _client
                            .Child("movie_genre")
                            .Child(row.Key)
                            .DeleteAsync();
            }
            MessageBox.Show("Success!!");
        }

        void Reset()
        {
            textBox_ID.Clear();
            textBox_Title.Clear();
            textBox_language.Clear();
            textBox_overview.Clear();
            textBox_poster.Clear();
            textBox_rate.Clear();
            textBox_runtime.Clear();
            textBox_streaming.Clear();
            dateTimePicker.ResetText();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else if (textBox_Title.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_Title.Focus();
            }
            else
            {
                var movie = new Movie
                (
                    id: int.Parse(textBox_ID.Text),
                    title: textBox_Title.Text,
                    runtime: int.Parse(textBox_runtime.Text),
                    overview: textBox_Title.Text,
                    release_date: dateTimePicker.Value.ToString("yyyy-MM-dd"),
                    poster_path: textBox_poster.Text,
                    vote_average: float.Parse(textBox_rate.Text),
                    streaming_state: textBox_streaming.Text,
                    original_language: textBox_language.Text
                );
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == movie.id)
                    {
                        await _client
                            .Child("movies")
                            .Child(movie.id.ToString())
                            .PutAsync(movie);

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

        async Task<int?> GetMovieRuntime(int movie_id)
        {
            var task = await query.GetResponseFromURLAsync($"https://api.themoviedb.org/3/movie/{movie_id}");
            RestResponse response = task;
            string json = response.Content;

            var model = JsonConvert.DeserializeObject<MovieDetail>(json);

            if (model == null)
            {
                Console.WriteLine("null");
                return null;
            }

            return model.runtime;
        }

        async Task PutMovieList(string url)
        {
            var task = await query.GetResponseFromURLAsync(url);
            RestResponse response = task;
            string json = response.Content;

            var model = JsonConvert.DeserializeObject<MovieQueryObj>(json);

            if (model == null)
            {
                Console.WriteLine("null");
                return;
            }

            if (model.results == null)
            {
                Console.WriteLine("movies null");
                return;
            }
            try
            {
                /*foreach (MoviePreETLObj tmp in model.results)
                {
                    foreach (var a in tmp.genre_ids)
                    {
                        consoleBox.Text += a.ToString() + " ";
                    }
                    //consoleBox.Text += tmp.ConvertToMovie().vote_average + " ";
                }*/

                foreach (MoviePreETLObj movie in model.results)
                {
                    Movie holder = movie.ConvertToMovie();
                    var runtime = await GetMovieRuntime(movie.id);
                    holder.runtime = (int)runtime;
                    holder.streaming_state = "None";
                    holder.streaming_state = isReleased(holder.release_date) ? ((DateTime.Now - getDate(holder.release_date)).Days < 30 ? "Streaming" : "None") : "Upcoming";
                    await _client
                      .Child("movies")
                      .Child(movie.id.ToString())
                      .PutAsync(holder);

                    foreach (var id in movie.genre_ids)
                    {
                        await _client
                          .Child("movie_genre")
                          .Child($"{movie.id.ToString()}_{id.ToString()}")
                          .PutAsync(new Movie_Genre(movie.id, id));
                    }
                    await AddParticipantByMovieID(movie.id);
                }
                MessageBox.Show("Success!!!");

                UpdateDtgv();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        async Task AddParticipantByMovieID(int movie_id)
        {
            var task = await query.GetResponseFromURLAsync($"https://api.themoviedb.org/3/movie/{movie_id}/credits");
            RestResponse response = task;
            string json = response.Content;

            var model = JsonConvert.DeserializeObject<CreditQuery>(json);

            if (model == null)
            {
                Console.WriteLine("null");
                return;
            }

            try
            {
                foreach (Cast tmp in model.cast)
                {
                    Participant holder = tmp.ConvertToParticipant();
                    await _client
                      .Child("participants")
                      .Child(tmp.id.ToString())
                      .PutAsync(holder);

                    await _client
                      .Child("credits")
                      .Child(movie_id.ToString())
                      .Child(tmp.credit_id)
                      .PutAsync(new Credit(tmp.credit_id, movie_id, tmp.id, 1));
                }
                foreach (Crew tmp in model.crew)
                {
                    if (tmp.job != "Director") continue;
                    Participant holder = tmp.ConvertToParticipant();
                    await _client
                      .Child("participants")
                      .Child(tmp.id.ToString())
                      .PutAsync(holder);

                    await _client
                      .Child("credits")
                      .Child(movie_id.ToString())
                      .Child(tmp.credit_id)
                      .PutAsync(new Credit(tmp.credit_id, movie_id, tmp.id, 0));
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        async void PutParticipantAndCredit()
        {
            var table = await Helper.GetDataTable<Movie>("movies");
            foreach (var row in table)
            {
                await AddParticipantByMovieID(row.Object.id);
            }

            MessageBox.Show("Success!!!");

            UpdateDtgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else
            {
                string id = textBox_ID.Text;
                var table = await Helper.GetDataTable<Movie>("movies");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == id)
                    {
                        await _client
                    .Child("movies")
                    .Child(id)
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
            if (e.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                textBox_ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox_Title.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox_language.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox_overview.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                dateTimePicker.Value = getDate(dataGridView1.Rows[i].Cells[4].Value.ToString());
                textBox_poster.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox_runtime.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBox_streaming.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                textBox_rate.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_runtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_streaming_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_language_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
