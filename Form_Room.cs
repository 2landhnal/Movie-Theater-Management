using Firebase.Database;
using Firebase.Database.Query;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Room : Form
    {
        FirebaseClient _client;
        DataTable dt;
        Query query;
        static List<String> columns = new List<String> { "id", "name", "theaterId", "room_type" };
        public Form_Room()
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
            if (textBox_index.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_index.Focus();
            }
            else if (comboBox_theaterId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập theater id");
                comboBox_theaterId.Focus();
            }
            else
            {
                //MessageBox.Show(dateTimePicker.Value.ToString("yyyy-MM-dd"));
                var room = Room.GetRoom
                (
                    index: int.Parse(textBox_index.Text),
                    name: textBox_name.Text,
                    room_type: int.Parse(textBox_type.Text),
                    theaterId: comboBox_theaterId.Text
                );
                var theaterTable = await Helper.GetDataTable<Theater>("theaters");
                bool theaterExist = false;
                foreach (var tmp in theaterTable)
                {
                    if (tmp.Object.id == room.theaterId)
                    {
                        theaterExist = true;
                        break;
                    }
                }
                if (!theaterExist)
                {
                    MessageBox.Show("Theater id not exist!");
                    return;
                }

                var roomTable = await Helper.GetDataTable<Room>($"rooms");
                foreach (var tmp in roomTable)
                {
                    if (tmp.Object.id == room.id)
                    {
                        MessageBox.Show("Room already exist!");
                        return;
                    }
                }

                await _client
                    .Child("rooms")
                    .Child(room.id)
                    .PutAsync(room);

                MessageBox.Show("Đã thêm mới thành công");

                UpdateDtgv();

                Reset();
            }
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            Helper.LoadingForm(this);
            UpdateDtgv();
            Helper.LoadingDone(this);
            /*var theaterTable = await Helper.GetDataTable<Theater>($"theaters");
            List<Room> roomList = new List<Room>();
            foreach (var theater in theaterTable)
            {
                var roomTable = await Helper.GetDataTable<Room>($"rooms/{theater.Object.id}");
                foreach (var room in roomTable)
                {
                    roomList.Add(room.Object);
                }
            }
            foreach (var room in roomList)
            {
                await _client
                            .Child("rooms")
                            .Child(room.id)
                            .PutAsync(room);
            }*/
        }

        async void UpdateDtgv()
        {
            dt.Rows.Clear();
            try
            {
                var table = await Helper.GetDataTable<Room>($"rooms");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["name"] = roww.Object.name;
                    row["theaterId"] = roww.Object.theaterId;
                    row["room_type"] = roww.Object.room_type;
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
            textBox_index.Clear();
            textBox_type.Clear();
            textBox_name.Clear();
            comboBox_theaterId.Text = string.Empty;
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (textBox_index.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_index.Focus();
            }
            else if (comboBox_theaterId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập theater id");
                comboBox_theaterId.Focus();
            }
            else
            {
                var room = Room.GetRoom
               (
                   index: int.Parse(textBox_index.Text),
                   name: textBox_name.Text,
                   room_type: int.Parse(textBox_type.Text),
                   theaterId: comboBox_theaterId.Text
               );
                var table = await Helper.GetDataTable<Room>("rooms");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == room.id)
                    {
                        await _client
                            .Child("rooms")
                            .Child(room.id)
                            .PutAsync(room);

                        MessageBox.Show($"Update room {tmp.Object.id} successfully");

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
            if (textBox_index.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_index.Focus();
            }
            else
            {
                string id = $"{comboBox_theaterId.Text}_{textBox_index.Text}";
                var table = await Helper.GetDataTable<Room>("rooms");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id.ToString() == id)
                    {
                        await _client
                            .Child("rooms")
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
                textBox_index.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Split("_")[1];
                textBox_name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox_theaterId.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox_type.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void textBox_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_index_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void Form_Room_Load(object sender, EventArgs e)
        {
            //comboBox_theaterId.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            var table = await Helper.GetDataTable<Theater>("theaters");
            List<string> theaterIdList = new List<string>();
            foreach (var tmp in table)
            {
                if (!comboBox_theaterId.Items.Contains(tmp.Object.id))
                {
                    comboBox_theaterId.Items.Add(tmp.Object.id);
                }
            }
            //MessageBox.Show(theaterIdList.Count.ToString());
            //comboBox_theaterId.AutoCompleteCustomSource.AddRange(theaterIdList.ToArray());
            //comboBox_theaterId.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBox_theaterId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}
