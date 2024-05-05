using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Genre : Form
    {
        FirebaseClient _client;
        DataTable dt = new DataTable();
        Query query = new Query();
        public Form_Genre()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            _client = Firebase_Connect.client;
            InitializeComponent();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Name";
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else if (textBox_Name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_Name.Focus();
            }
            else
            {
                var genre = new Genre
                {
                    id = textBox_ID.Text,
                    name = textBox_Name.Text
                };
                var table = await GetFirebaseTable("genres");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == genre.id)
                    {
                        MessageBox.Show("Genre id already exist!");
                        return;
                    }
                }

                await _client
                    .Child("genres")
                    .Child(genre.id)
                    .PutAsync(genre);

                MessageBox.Show("Đã thêm mới thành công genre");

                UpdateDtgv();

                Reset();
            }
        }

        async Task<IReadOnlyCollection<FirebaseObject<Genre>>?> GetFirebaseTable(string tableLink)
        {
            if (_client == null) return null;
            var result = await _client
              .Child(tableLink)
              .OnceAsync<Genre>();
            return result;
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            UpdateDtgv();
        }

        async void UpdateDtgv()
        {
            dt.Rows.Clear();
            try
            {
                var table = await GetFirebaseTable("genres");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["name"] = roww.Object.name;
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
            textBox_ID.Clear();
            textBox_Name.Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else if (textBox_Name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_Name.Focus();
            }
            else
            {
                var genre = new Genre
                {
                    id = textBox_ID.Text,
                    name = textBox_Name.Text
                };
                var table = await GetFirebaseTable("genres");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == genre.id)
                    {
                        await _client
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

        async Task AddGenresAsync()
        {
            var task = await query.GetResponseFromURLAsync("https://api.themoviedb.org/3/genre/movie/list?language=en");
            RestResponse response = task;
            string json = response.Content;

            var model = JsonConvert.DeserializeObject<GenreSearchObj>(json);

            if (model == null)
            {
                Console.WriteLine("null");
                return;
            }

            if (model.genres == null)
            {
                Console.WriteLine("genres null");
                return;
            }
            try
            {
                foreach (Genre tmp in model.genres)
                {
                    await _client
                      .Child("genres")
                      .Child(tmp.id)
                      .PutAsync(tmp);
                }
                MessageBox.Show("Success!!!");

                UpdateDtgv();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
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
                var genre = new Genre
                {
                    id = textBox_ID.Text,
                    name = textBox_Name.Text
                };
                var table = await GetFirebaseTable("genres");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == genre.id)
                    {
                        await _client
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
            textBox_ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox_Name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
    }
}
