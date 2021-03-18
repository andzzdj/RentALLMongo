using MongoDB.Driver;
using System;
using System.Configuration;
using System.Windows.Forms;

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
            //var connectionString = ConfigurationManager.AppSettings["mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false"];

            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");

            var collection = database.GetCollection<User>("Users");


        }
    }
}
