using MongoDB.Bson;
using MongoDB.Driver;


using RentALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentALLMongo
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");

            var database = client.GetDatabase("RentALLDb");

            var collection = database.GetCollection<User>("users");

            string newPassword = textBox1.Text.ToString();

            //var user = collection.AsQueryable()
            //                     .Where(p => p.Username == Global.ActiveUser.Username && 
            //                     p.Password == Global.ActiveUser.Password).FirstOrDefault();
            var filter = Builders<User>.Filter.Where(p => p.Username == Global.ActiveUser.Username &&
                                 p.Password == Global.ActiveUser.Password);
          //  var update = MongoDB.Driver.Builders<User>.Update.Set("oznake", BsonValue.Create(new List<string> { "test" }));
            var update = Builders<User>.Update.Set("Password", newPassword);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Password is updated successfully!");
        }

        private void updateTownButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");         
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<User>("users");

            string newTown = textBox2.Text.ToString();

            var filter = Builders<User>.Filter.Where(p => p.Username == Global.ActiveUser.Username &&
                                 p.Password == Global.ActiveUser.Password);
            //  var update = MongoDB.Driver.Builders<User>.Update.Set("oznake", BsonValue.Create(new List<string> { "test" }));
            var update = Builders<User>.Update.Set("Town", newTown);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Town is updated successfully!");
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<User>("users");

            var filter = Builders<User>.Filter.Where(p => p.Id == Global.ActiveUser.Id);

            collection.DeleteOne(filter);

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name != "Form1")
                    f.Close();
            }

        }
    }
}
