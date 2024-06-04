using Firebase.Database;


namespace Movie_Theater_Management
{
    public partial class Firebase_Connect : Form
    {
        static string auth = "N5ZcmKVbqP4InPTJYkbIzZ5aZ9qAcKC8bLGUomhd"; // your app secret
        static public FirebaseClient client = null;

        public Firebase_Connect()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FirebaseAuth();
        }

        void FirebaseAuth()
        {
            if (client != null)
            {
                return;
            }

            client = new FirebaseClient(
              "https://winform-dc210-default-rtdb.asia-southeast1.firebasedatabase.app/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              }
            );

            if (client != null)
            {
                this.Hide();
                MessageBox.Show("Kết nối Firebase thành công !!!");
                var mainForm = new HomePage();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }
    }
}
