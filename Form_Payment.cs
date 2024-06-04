using Firebase.Database;
using Firebase.Database.Query;
using RestSharp;
using System.Data;

namespace Movie_Theater_Management
{
    public partial class Form_Payment : Form
    {
        FirebaseClient _client;
        DataTable dt = new DataTable();
        Query query = new Query();
        public Form_Payment()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("iconLink");

            _client = Firebase_Connect.client;
            InitializeComponent();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Icon Link";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                var payment = new PaymentMethod
                (
                    id: textBox_ID.Text,
                    name: textBox_Name.Text,
                    iconLink: textBoxLink.Text

                );
                var table = await Helper.GetDataTable<PaymentMethod>("payment_methods");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == payment.id)
                    {
                        MessageBox.Show("Payment id already exist!");
                        return;
                    }
                }

                await _client
                    .Child("payment_methods")
                    .Child(payment.id)
                    .PutAsync(payment);

                MessageBox.Show("Đã thêm mới thành công payment");

                UpdateDtgv();

                Reset();
            }
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
                var table = await Helper.GetDataTable<PaymentMethod>("payment_methods");
                foreach (var roww in table)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = roww.Object.id;
                    row["name"] = roww.Object.name;
                    row["iconLink"] = roww.Object.iconLink;
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
                var payment = new PaymentMethod
                (
                    id: textBox_ID.Text,
                    name: textBox_Name.Text,
                    iconLink: textBoxLink.Text

                );
                var table = await Helper.GetDataTable<PaymentMethod>("payment_methods");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == payment.id)
                    {
                        await _client
                            .Child("payment_methods")
                            .Child(payment.id)
                            .PutAsync(payment);

                        MessageBox.Show($"Update payment {tmp.Object.id} successfully");

                        UpdateDtgv();

                        Reset();
                        return;
                    }
                }

                MessageBox.Show("Payment id isn't exist!");
                return;
            }
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
                var payment = new PaymentMethod
                (
                    id: textBox_ID.Text,
                    name: textBox_Name.Text,
                    iconLink: textBoxLink.Text

                );
                var table = await Helper.GetDataTable<PaymentMethod>("payment_methods");
                foreach (var tmp in table)
                {
                    if (tmp.Object.id == payment.id)
                    {
                        await _client
                    .Child("payment_methods")
                    .Child(payment.id)
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
                textBox_Name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
