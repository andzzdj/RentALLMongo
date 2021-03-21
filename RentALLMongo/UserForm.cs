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
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");


            var filter = Builders<User>.Filter.Where(p => p.Id == Global.ActiveUser.Id);
            var vehiclesFilter = Builders<Vehicle>.Filter.Where(p => p.Owner.Id == Global.ActiveUser.Id);
     
            collectionVehicles.DeleteMany(vehiclesFilter);
            collection.DeleteOne(filter);
           



            foreach (Form f in Application.OpenForms)
            {
                if (f.Name != "Form1")
                    f.Close();
            }

        }

        private void showRequestsButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collectionUsers = database.GetCollection<User>("users");
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionRequests = database.GetCollection<Request>("requests");

            requestsListBox.Items.Clear();
            renterUsernameListbox.Items.Clear();
            var requests = collectionRequests.AsQueryable().Where(r => r.Owner.Id == Global.ActiveUser.Id).ToList();
            if(requests.Count!=0)
            {
                foreach (var item in requests)
                {
                    requestsListBox.Items.Add(item.Vehicle.Model );
                    renterUsernameListbox.Items.Add(item.Renter.Username.ToString());

                }
            }
        }

        private void acceptRequestButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collectionUsers = database.GetCollection<User>("users");
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionRequests = database.GetCollection<Request>("requests");

            requestsListBox.Items.Clear();
            renterUsernameListbox.Items.Clear();
            var index = requestsListBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please first select request from requests list!");
            }
            else
            {
                var request = collectionRequests.AsQueryable().Where(p => p.Owner.Id == Global.ActiveUser.Id
                                   && p.Renter.Username == renterUsernameListbox.Items[index].ToString()
                                   && p.Vehicle.Model == requestsListBox.SelectedItem.ToString()).FirstOrDefault();
                if (request.Status == RequestTypesEnum.Accepted || request.Status == RequestTypesEnum.Declined)
                {
                    MessageBox.Show("You have already" + " " + request.Status.ToString() + " " + "this request!");
                }
                else
                {

                    
                        var filter = Builders<Request>.Filter.Where(p => p.Owner.Id == Global.ActiveUser.Id
                                        && p.Renter.Username == renterUsernameListbox.Items[index].ToString()
                                        && p.Vehicle.Model == requestsListBox.SelectedItem.ToString());
                        //  var update = MongoDB.Driver.Builders<User>.Update.Set("oznake", BsonValue.Create(new List<string> { "test" }));
                        var update = Builders<Request>.Update.Set("Status", RequestTypesEnum.Accepted.ToString());
                        collectionRequests.UpdateOne(filter, update);
                        MessageBox.Show("You have succesfully accepted this request. Contact info:\n"
                            + request.Renter.Username + "\n"
                            + request.Renter.Email + "\n"
                            + request.Renter.Phone + "\n");
                   
                }
            }
           

        }

        private void DeclineRequestButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collectionUsers = database.GetCollection<User>("users");
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionRequests = database.GetCollection<Request>("requests");

            requestsListBox.Items.Clear();
            renterUsernameListbox.Items.Clear();
            var index = requestsListBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please first select request from requests list!");
            }
            else
            {
                var request = collectionRequests.AsQueryable().Where(p => p.Owner.Id == Global.ActiveUser.Id
                                   && p.Renter.Username == renterUsernameListbox.Items[index].ToString()
                                   && p.Vehicle.Model == requestsListBox.SelectedItem.ToString()).FirstOrDefault();
                if (request.Status == RequestTypesEnum.Accepted || request.Status == RequestTypesEnum.Declined)
                {
                    MessageBox.Show("You have already" + " " + request.Status.ToString() + " " + "this request!");
                }
                else
                {


                    var filter = Builders<Request>.Filter.Where(p => p.Owner.Id == Global.ActiveUser.Id
                                    && p.Renter.Username == renterUsernameListbox.Items[index].ToString()
                                    && p.Vehicle.Model == requestsListBox.SelectedItem.ToString());
                    //  var update = MongoDB.Driver.Builders<User>.Update.Set("oznake", BsonValue.Create(new List<string> { "test" }));
                    var update = Builders<Request>.Update.Set("Status", RequestTypesEnum.Declined.ToString());
                    collectionRequests.UpdateOne(filter, update);
                    MessageBox.Show("You have succesfully declined this request.");

                }
            }

        }

        private void renterUsernameListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collectionUsers = database.GetCollection<User>("users");
            var collectionRequests = database.GetCollection<Request>("requests");

            int index = requestsListBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select request to see more information!");
            }
            else
            {
                var user = collectionUsers.AsQueryable().Where(p => p.Username == renterUsernameListbox.SelectedItem.ToString()).FirstOrDefault();
                var request = collectionRequests.AsQueryable().Where(p => p.Owner.Id == Global.ActiveUser.Id
                                                   && p.Renter.Username == renterUsernameListbox.Items[index].ToString()
                                                   && p.Vehicle.Model == requestsListBox.SelectedItem.ToString()).FirstOrDefault();
                MessageBox.Show("Username:" + " " + user.Username + "\n" +
                    "Town:" + user.Town + "\n" +
                    "Email:" + user.Email + "\n" +
                    "Phone:" + user.Phone + "\n"+
                    "Date sent:"+request.SendDate+"\n"+
                    "Status:"+request.Status.ToString()+"\n");
            }
        }

        private void myRequestsButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collectionUsers = database.GetCollection<User>("users");
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionRequests = database.GetCollection<Request>("requests");

            myRequestsListbox.Items.Clear();

            var requests = collectionRequests.AsQueryable().Where(p => p.Renter.Id == Global.ActiveUser.Id).ToList();

            if (requests != null)
            {
                foreach (var item in requests)
                {
                    if (item.Status != RequestTypesEnum.Pending)
                    {
                        myRequestsListbox.Items.Add("Model:" + " " + item.Vehicle.Model + " " + "Date sent:" +
                            " " + item.SendDate.ToShortDateString() + " " + "Status:" + " " + item.Status.ToString() 
                            + "Date answered:" + " " + item.AnsweredDate.ToShortDateString());

                    }
                    else 
                    {
                        myRequestsListbox.Items.Add("Model:" + " " + item.Vehicle.Model + " " + "Date sent:" + 
                            " " + item.SendDate.ToShortDateString() + " " + "Status:" + " " + item.Status.ToString());

                    }
                }
            }



        }
    }
    
}
