using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
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
    }
}
