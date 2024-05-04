using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class MainForm : Form
    {
        IFirebaseClient _client;
        DataTable dt = new DataTable();
        Query query = new Query();
        public MainForm(IFirebaseClient c)
        {
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            _client = c;
            InitializeComponent();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Name";
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (textBox_Ten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_Ten.Focus();
            }
            else if (textBox_tuoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_tuoi.Focus();
            }
            else
            {
                /*var tmp = 0;
                if (GetFirebaseTable(@"Information") != null)
                {
                    tmp = GetFirebaseTable(@"Information").Count;
                }*/

                /*var task = await query.GetResponseFromURLAsync("https://api.themoviedb.org/3/genre/movie/list?language=en");
                RestResponse respon = task;
                string json = respon.Content;
                var model = JsonConvert.DeserializeObject<GenreSearchObj>(json);
                List<Genre> list = model.genres;*/

                var genre = new Genre
                {
                    id = "aa",
                    name = "e0"
                };

                var response = await _client.SetTaskAsync("Genre/" + genre.id.ToString(), genre);

                MessageBox.Show("Đã thêm mới thành công học sinh ");

                Reset();
            }
        }

        JArray GetFirebaseTable(string link)
        {
            FirebaseResponse res = _client.Get(link);
            consoleBox.Text = res.Body.ToString();
            if (consoleBox.Text == "null")
            {
                return null;
            }
            JArray jsonArray = JArray.Parse(res.Body.ToString());
            return jsonArray;
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            try
            {
                JArray table = GetFirebaseTable(@"Information");
                for (int i = 0; i < table.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    // Lấy phần tử thứ i trong mảng JSON
                    JObject dataObject = table[i].ToObject<JObject>();
                    row["id"] = dataObject["id"].ToString();
                    row["hoten"] = dataObject["ten"].ToString();
                    row["tuoi"] = dataObject["tuoi"].ToString();

                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

            }
        }

        void Reset()
        {
            textBox_Ten.Clear();
            textBox_tuoi.Clear();
        }

        private async void refreshBtn_Click(object sender, EventArgs e)
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

            foreach (Genre tmp in model.genres)
            {
                // All movies
                consoleBox.Text += tmp.id + $" {tmp.name}" + " ";
                SetResponse res  = await _client.SetTaskAsync("Genre/" + tmp.id, tmp);
            }
        }
    }
}
