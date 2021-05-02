using MongoDB.Driver;
using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using MongoDB.Driver.Linq;
using RentALLMongo;

namespace RentALL
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");

            var collection = database.GetCollection<User>("users");

            String username = usernameTextBox1.Text;
            String password = passwordTextBox1.Text;

            var query = collection.AsQueryable()
                                  .Where(p => p.Username == username && p.Password == password).FirstOrDefault();

            if (query == null)
            {
                MessageBox.Show("Username or password not correct.");
            }
            else
            {
                Global.ActiveUser = query;
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }
    }
}
