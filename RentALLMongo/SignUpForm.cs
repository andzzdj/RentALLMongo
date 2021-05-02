using MongoDB.Driver;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RentALL
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpUserButton_Click(object sender, EventArgs e)
        {
            //var connectionString = ConfigurationManager.AppSettings["mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false"];

            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");

            var collection = database.GetCollection<User>("users");

            var query = collection.AsQueryable()
                                  .Where(p => p.Username == UsernameTextbox.Text).FirstOrDefault();
            if (query == null)
            {
                User user = new User
                {
                    Name = NameTextbox.Text,
                    Surname = SurnameTextbox.Text,
                    Town = TownTextobx.Text,
                    Username = UsernameTextbox.Text,
                    Password = PasswordTextbox.Text,
                    Phone = PhoneTxtbox.Text,
                    Email = EmailTxtbox.Text
                };

                collection.InsertOne(user);

                MessageBox.Show("You have signed up successfully, please sign in to continue!");
            }
            else
            {
                MessageBox.Show("Username already exists!");
            }
        }
    }
}
