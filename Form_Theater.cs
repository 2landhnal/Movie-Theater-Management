using Firebase.Database;
using Firebase.Database.Query;
using GemBox.Spreadsheet;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Theater : Form
    {
        DataTable dt;
        Query query;
        String currentAddedAt;
        FirebaseClient _client;
        static List<String> columns = new List<String> { "id", "name", "added_at", "loc", "lat", "lon" };
        public Form_Theater()
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
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_id.Focus();
            }
            else if (textBox_name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_name.Focus();
            }
            else
            {
                //MessageBox.Show(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                var theater = new Theater
                (
                    id: textBox_id.Text,
                    name: textBox_name.Text,
                    added_at: DateTime.Now.ToString("yyyy-MM-dd"),
                    lon: float.Parse(textBox_lon.Text),
                    lat: float.Parse(textBox_lat.Text),
                    loc: textBox_loc.Text
                );
                var table = await Helper.GetDataTable<Theater>("theaters");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == theater.id)
                    {
                        MessageBox.Show("Genre id already exist!");
                        return;
                    }
                }

                await _client
                    .Child("theaters")
                    .Child(theater.id.ToString())
                    .PutAsync(theater);

                MessageBox.Show("Đã thêm mới thành công");

                UpdateDtgv();

                Reset();
            }
        }

        private async void AddTheaterAndRoomAndRoomMap()
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_id.Focus();
            }
            else if (textBox_name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_name.Focus();
            }
            else
            {
                //MessageBox.Show(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                var theater = new Theater
                (
                    id: textBox_id.Text,
                    name: textBox_name.Text,
                    added_at: DateTime.Now.ToString("yyyy-MM-dd"),
                    lon: float.Parse(textBox_lon.Text),
                    lat: float.Parse(textBox_lat.Text),
                    loc: textBox_loc.Text
                );
                var table = await Helper.GetDataTable<Theater>("theaters");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == theater.id)
                    {
                        MessageBox.Show("Genre id already exist!");
                        return;
                    }
                }

                await _client
                    .Child("theaters")
                    .Child(theater.id.ToString())
                    .PutAsync(theater);

                MessageBox.Show("Đã thêm mới thành công");

                await AddRooms(theater.id);
                await AddRoomMap(theater.id);

                UpdateDtgv();

                Reset();
            }
        }

        ExcelWorksheet getExcelWorksheet()
        {
            // If using the Professional version, put your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Load Excel workbook from file's path.
            ExcelFile workbook = ExcelFile.Load("Z:\\Visual Studio 2022\\Movie Theater Management\\Book.xlsx");

            // Iterate through all worksheets in a workbook.
            ExcelWorksheet worksheet = workbook.Worksheets[new Random().Next(0, 4)];
            return worksheet;
        }

        async Task AddRoomMap(String theaterId)
        {
            var roomTable = await Helper.GetDataTable<Room>($"rooms/{theaterId}");
            foreach (var room in roomTable)
            {
                var roomMap = getExcelWorksheet();
                foreach (ExcelRow row in roomMap.Rows)
                {
                    foreach (ExcelCell cell in row.AllocatedCells)
                    {
                        await _client.Child("room_seat")
                       .Child(room.Object.id)
                       .Child(room.Object.id + "_" + cell.Name)
                       .PutAsync(new Room_Seat(room.Object.id, cell.Name, cell.IntValue));
                    }
                }
            }
            MessageBox.Show("Room map Done");
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            //AddTheaterAndRoomAndRoomMap();
            UpdateDtgv();
            //AddRooms();
            //AddSchedules();
            //AddRoomMap();
        }

        async Task AddRooms(String theaterId)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Room room = new Room(theaterId + "_" + (i + 1).ToString(), $"Room {i + 1}", theaterId, 0);
                    await _client.Child("rooms")
                        .Child(theaterId.ToString())
                        .Child(theaterId + "_" + (i + 1).ToString())
                        .PutAsync(room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        async void UpdateDtgv()
        {
            dt.Rows.Clear();
            try
            {
                var table = await Helper.GetDataTable<Theater>("theaters");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["name"] = roww.Object.name;
                    row["lat"] = roww.Object.lat;
                    row["lon"] = roww.Object.lon;
                    row["loc"] = roww.Object.loc;
                    row["added_at"] = roww.Object.added_at;
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
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_lat.Clear();
            textBox_loc.Clear();
            textBox_lon.Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_id.Focus();
            }
            else if (textBox_name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập name");
                textBox_name.Focus();
            }
            else
            {
                var theater = new Theater
                (
                    id: textBox_id.Text,
                    name: textBox_name.Text,
                    added_at: currentAddedAt,
                    lon: float.Parse(textBox_lon.Text),
                    lat: float.Parse(textBox_lat.Text),
                    loc: textBox_loc.Text
                );
                var table = await Helper.GetDataTable<Theater>("theaters");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == theater.id)
                    {
                        await _client
                            .Child("theaters")
                            .Child(theater.id.ToString())
                            .PutAsync(theater);

                        MessageBox.Show($"Update id {tmp.Object.id} successfully");

                        UpdateDtgv();

                        Reset();
                        return;
                    }
                }

                MessageBox.Show("Id isn't exist!");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_id.Focus();
            }
            else
            {
                string id = textBox_id.Text;
                var table = await Helper.GetDataTable<Theater>("theaters");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == id)
                    {
                        await _client
                    .Child("theaters")
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                textBox_id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox_name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox_loc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox_lat.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox_lon.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                currentAddedAt = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
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

        private void textBox_lat_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
