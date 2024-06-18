using Firebase.Database;
using Firebase.Database.Query;
using GemBox.Spreadsheet;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_room_map : Form
    {
        FirebaseClient _client;
        DataTable dt;
        Query query;

        String currentFilePath = "";

        ExcelWorksheet getExcelWorksheet()
        {
            // If using the Professional version, put your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Load Excel workbook from file's path.
            ExcelFile workbook = ExcelFile.Load(currentFilePath);

            // Iterate through all worksheets in a workbook.
            ExcelWorksheet worksheet = workbook.Worksheets[0];
            return worksheet;
        }

        async Task AddRoomMap(String roomId)
        {
            if (currentFilePath == "") return;
            var roomMap = getExcelWorksheet();
            foreach (ExcelRow row in roomMap.Rows)
            {
                foreach (ExcelCell cell in row.AllocatedCells)
                {
                    await _client.Child("room_seat")
                   .Child(roomId)
                   .Child(roomId + "_" + cell.Name)
                   .PutAsync(Room_Seat.createRoomSeat(roomId, cell.Name, cell.IntValue));
                }
            }
            MessageBox.Show("Room map done");
        }

        static List<String> columns = new List<String> { "id", "name", "roomId", "seatType" };
        public Form_room_map()
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
            Helper.LoadingForm(this);
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else if (currentFilePath == "")
            {
                MessageBox.Show("Vui lòng chọn room map file");
            }
            else
            {
                var table = await Helper.GetDataTable<Room_Seat>($"room_seat/{textBox_ID.Text}");
                if (table.Count > 0)
                {
                    MessageBox.Show("Room map already exist!");
                    Helper.LoadingDone(this);
                    return;
                }

                await AddRoomMap(textBox_ID.Text);

                MessageBox.Show("Đã thêm mới thành công");

                //UpdateDtgv();

                Reset();
            }
            Helper.LoadingDone(this);
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
            Helper.LoadingForm(this);
            await UpdateDtgv();
            Helper.LoadingDone(this);
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

        async Task UpdateDtgv()
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
                return;
            }
            dt.Rows.Clear();
            try
            {
                Helper.LoadingForm(this);
                var table = await Helper.GetDataTable<Room_Seat>($"room_seat/{textBox_ID.Text}");
                foreach (var v in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = v.Object.id;
                    row["name"] = v.Object.name;
                    row["roomId"] = v.Object.roomId;
                    row["seatType"] = v.Object.seatType;
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Helper.LoadingDone(this);
        }

        void Reset()
        {
            textBox_ID.Clear();
        }

        private async void filePickerBtn_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Title = "Pick your xlsx file";
            FD.InitialDirectory = @"Z:\";
            FD.Filter = "All files (*.xlsx)|*.xlsx";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentFilePath = FD.FileName;
                //currentFilePath.Replace("\\", "\\\\");
                //MessageBox.Show(currentFilePath);
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            Helper.LoadingForm(this);
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_ID.Focus();
            }
            else
            {
                string id = textBox_ID.Text;
                try
                {
                    await _client
                            .Child("room_seat")
                            .Child(id)
                            .DeleteAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Helper.LoadingDone(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void Form_room_map_Load(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
