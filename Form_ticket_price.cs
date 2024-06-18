using Firebase.Database;
using Firebase.Database.Query;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_ticket_price : Form
    {
        FirebaseClient _client;
        DataTable dt;
        Query query;
        static List<String> columns = new List<String> { "scheduleId", "seatType", "price" };
        public Form_ticket_price()
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
            if (textBox_scheduleId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_scheduleId.Focus();
            }
            else
            {
                var ticketPrice = new TicketPrice_Schedule
                (
                    scheduleId: textBox_scheduleId.Text,
                    seatType: int.Parse(comboBox_seatType.Text),
                    price: int.Parse(textBox_price.Text)
                );
                var table = await Helper.GetDataTable<TicketPrice_Schedule>($"ticket_price_schedule/{textBox_scheduleId.Text}");
                foreach (var tmp in table)
                {
                    if (tmp.Object.seatType == ticketPrice.seatType)
                    {
                        MessageBox.Show("Ticket price already exist!");
                        return;
                    }
                }

                await _client
                    .Child("ticket_price_schedule")
                    .Child(textBox_scheduleId.Text)
                    .Child(comboBox_seatType.Text)
                    .PutAsync(ticketPrice);

                MessageBox.Show("Đã thêm mới thành công");

                UpdateDtgv();
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
            UpdateDtgv();
        }

        async void UpdateDtgv()
        {
            if (textBox_scheduleId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_scheduleId.Focus();
                return;
            }
            dt.Rows.Clear();
            try
            {
                var table = await Helper.GetDataTable<TicketPrice_Schedule>($"ticket_price_schedule/{textBox_scheduleId.Text}");
                if (table.Count == 0)
                {
                    MessageBox.Show("Ticket price info isn't exist!");
                    return;
                }
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["scheduleId"] = roww.Object.scheduleId;
                    row["seatType"] = roww.Object.seatType;
                    row["price"] = roww.Object.price;
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
            textBox_scheduleId.Clear();
            comboBox_seatType.Text = "";
            textBox_price.Clear();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (textBox_scheduleId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_scheduleId.Focus();
            }
            else
            {
                var ticketPrice = new TicketPrice_Schedule
                (
                    scheduleId: textBox_scheduleId.Text,
                    seatType: int.Parse(comboBox_seatType.Text),
                    price: int.Parse(textBox_price.Text)
                );
                var table = await Helper.GetDataTable<TicketPrice_Schedule>($"ticket_price_schedule/{ticketPrice.scheduleId}");
                if (table.Count == 0)
                {
                    MessageBox.Show("Ticket price info isn't exist!");
                    return;
                }
                foreach (var tmp in table)
                {
                    if (tmp.Object.seatType == ticketPrice.seatType)
                    {
                        await _client
                            .Child("ticket_price_schedule")
                            .Child(ticketPrice.scheduleId)
                            .Child(comboBox_seatType.Text)
                            .PutAsync(ticketPrice);

                        MessageBox.Show($"Update ticket price successfully");

                        UpdateDtgv();
                        return;
                    }
                }
                MessageBox.Show($"Ticket price isn't exist!");
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox_scheduleId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id");
                textBox_scheduleId.Focus();
            }
            else
            {
                string seatType = comboBox_seatType.Text;
                var table = await Helper.GetDataTable<TicketPrice_Schedule>($"ticket_price_schedule/{textBox_scheduleId.Text}");
                foreach (var tmp in table)
                {
                    if (tmp.Object.seatType.ToString() == seatType)
                    {
                        await _client
                            .Child("ticket_price_schedule")
                            .Child(textBox_scheduleId.Text)
                            .Child(seatType)
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
                textBox_scheduleId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                comboBox_seatType.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox_price.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
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

        private void textBox_runtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_scheduleId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void Form_ticket_price_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                if (!comboBox_seatType.Items.Contains(i.ToString()))
                {
                    comboBox_seatType.Items.Add(i.ToString());
                }
            }
        }
    }
}
