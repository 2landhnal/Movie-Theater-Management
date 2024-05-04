using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Movie_Theater_Management
{
    public partial class Firebase_Connect : Form
    {
        IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "N5ZcmKVbqP4InPTJYkbIzZ5aZ9qAcKC8bLGUomhd",
            BasePath = "https://winform-dc210-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        public IFirebaseClient client { get; private set; }
        public Firebase_Connect()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (client != null)
            {
                return;
            }

            client = new FireSharp.FirebaseClient(_config);

            if (client != null)
            {
                MessageBox.Show("Kết nối Firebase thành công !!!");
                var mainForm = new MainForm(client);
                mainForm.Show();
            }
        }
    }
}
