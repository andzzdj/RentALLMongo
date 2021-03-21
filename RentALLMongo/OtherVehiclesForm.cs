using MongoDB.Driver;
using RentALL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentALLMongo
{
    public partial class OtherVehiclesForm : Form
    {
        public OtherVehiclesForm()
        {
            InitializeComponent();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userComboBox.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var vehicleCollection = database.GetCollection<Vehicle>("vehicles");

            String model = modelComboBox.SelectedItem.ToString();
            String type = typeComboBox.SelectedItem.ToString();

            var vehicles = vehicleCollection.AsQueryable().Where(x => x.Model == model && x.Type == type).ToList();

            foreach (Vehicle v in vehicles)
            {
                if (!userComboBox.Items.Contains(v.UserOwner.Username))
                {
                    userComboBox.Items.Add(v.UserOwner.Username);
                }
            }
        }

        private void userCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionlistBox.Items.Clear();
            VehicleslistBox.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");

            String type = typeComboBox.Text;
            String model = modelComboBox.Text;
            String owner = userComboBox.Text;

            var vehicle = collection.AsQueryable()
                .Where(x => x.Type == type && x.Model == model && x.UserOwner.Username == owner).ToList();

            foreach (Vehicle v in vehicle)
            {
                VehicleslistBox.Items.Add("Daily price: " + v.DailyPrice + "  Production year: " + v.ProductionYear);
            }
        }

        private void commentsBtn_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");

            var model = modelComboBox.SelectedItem.ToString();
            var ownerUsername = userComboBox.SelectedItem.ToString();

            var vehicle = collection.AsQueryable()
            .Where(v => v.Model == model && v.UserOwner.Username == ownerUsername).FirstOrDefault();

            if (vehicle != null)
            {
                Global.VehicleToComment = vehicle;
                ReviewForm reviewForm = new ReviewForm();
                reviewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a car");
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();
            userComboBox.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var vehicleCollection = database.GetCollection<Vehicle>("vehicles");

            var allVehicles = vehicleCollection.AsQueryable().Where(v => v.Type == typeComboBox.Text).ToList();


            foreach (Vehicle v in allVehicles)
            {
                if (!modelComboBox.Items.Contains(v.Model))
                {
                    modelComboBox.Items.Add(v.Model);
                }
            }
        }

        private void VehicleslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionlistBox.Items.Clear();
            string type = typeComboBox.Text;
            string model = modelComboBox.Text;
            string owner = userComboBox.Text;

            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var vehicleCollection = database.GetCollection<Vehicle>("vehicles");

            var index = VehicleslistBox.SelectedIndex;
            var vehicle = vehicleCollection.AsQueryable().Where(v => v.Type == type && v.Model == model && v.UserOwner.Username == owner).ToList();

            DescriptionlistBox.Items.Add(vehicle.ElementAt(index).Description);
        }

        private void DescriptionlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyBookmarkBtn_Click(object sender, EventArgs e)
        {
            myBookmarksBox.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var vehicleCollection = database.GetCollection<Vehicle>("vehicles");
            var userCollection = database.GetCollection<User>("users");

            var user = userCollection.AsQueryable().Where(x => x.Id == Global.ActiveUser.Id).FirstOrDefault();
            var bookmark = user.BookmarkList;
            VehicleslistBox.Items.Clear();
            foreach(var b in bookmark)
            {
                myBookmarksBox.Items.Add("Type: " + b.Type +
                                         "  Model: " + b.Model +
                                         "  Daily price: " + b.DailyPrice +
                                         "  Production year: " + b.ProductionYear);
            }
        }

        private void bookmarkBtn_Click(object sender, EventArgs e)
        {
            if (VehicleslistBox.SelectedIndex >= 0)
            {
                string type = typeComboBox.Text;
                string model = modelComboBox.Text;
                string owner = userComboBox.Text;
                var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                var database = client.GetDatabase("RentALLDb");

                var userCollection = database.GetCollection<User>("users");
                var vehicleCollection = database.GetCollection<Vehicle>("vehicles");

                var index = VehicleslistBox.SelectedIndex;
                var vehicle = vehicleCollection.AsQueryable().Where(v => v.Type == type && v.Model == model && v.UserOwner.Username == owner).ToList().ElementAt(index);

                var userBookmarkVehicle = userCollection.AsQueryable().Where(v => v.Id == Global.ActiveUser.Id).SingleOrDefault().BookmarkList;
                var bookmark = userBookmarkVehicle.Where(b => b.Id == vehicle.Id).Any();

                if (bookmark == false)
                {
                    var user = Builders<User>.Filter.Where(p => p.Id == Global.ActiveUser.Id);
                    var def = Builders<User>.Update.Push(u => u.BookmarkList, new Vehicle { Id = vehicle.Id, Type = vehicle.Type, Model = vehicle.Model, DailyPrice = vehicle.DailyPrice, Description = vehicle.Description, Owner = vehicle.Owner, ProductionYear = vehicle.ProductionYear });
                    userCollection.UpdateOne(user, def);
                    myBookmarksBox.Items.Add("Type: " + vehicle.Type + "  Model: " + vehicle.Model + "  Daily price: " + vehicle.DailyPrice + "  Production year: " + vehicle.ProductionYear);
                }  
            }
            else
            {
                MessageBox.Show("Please choose a vehicle to bookmark!");
            }
        }

        private void OtherVehiclesForm_Load_1(object sender, EventArgs e)
        {
            var types = Enum.GetValues(typeof(TypesEnum));

            foreach (var item in types)
            {
                typeComboBox.Items.Add(item.ToString());
            }
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            var index = VehicleslistBox.SelectedIndex;
            String owner = userComboBox.Text;
            if (index >= 0)
            {
                if (owner != Global.ActiveUser.Username)
                {

                    var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                    var database = client.GetDatabase("RentALLDb");
                    var collection = database.GetCollection<Vehicle>("vehicles");
                    var collectionRequest = database.GetCollection<Request>("requests");

                    String type = typeComboBox.Text;
                    String model = modelComboBox.Text;

                    var vehicle = collection.AsQueryable()
                        .Where(x => x.Type == type && x.Model == model && x.UserOwner.Username == owner).ToList();

                    var vehicleForRequest = vehicle.ElementAt(index);

                    var request = new Request
                    {
                        SendDate = DateTime.Now,
                        Status = RequestTypesEnum.Pending,
                        Owner = vehicleForRequest.UserOwner,
                        Renter = Global.ActiveUser,
                        Vehicle = vehicleForRequest
                    };

                    collectionRequest.InsertOne(request);

                    MessageBox.Show("You have successfully sent request!");
                }
                else
                {
                    MessageBox.Show("You can't rent your own car!");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a car you want to rent!");
            }
        }

        private void myBookmarksBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeBookmarkBtn_Click(object sender, EventArgs e)
        {
            if (myBookmarksBox.SelectedIndex >= 0)
            {
                string type = typeComboBox.Text;
                string model = modelComboBox.Text;
                string owner = userComboBox.Text;
                var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                var database = client.GetDatabase("RentALLDb");

                var userCollection = database.GetCollection<User>("users");
                var index = myBookmarksBox.SelectedIndex;

                var filter = Builders<User>.Filter.Where(x => x.Id == Global.ActiveUser.Id);
                var bookmarkList = userCollection.AsQueryable().Where(x => x.Id == Global.ActiveUser.Id).Select(x => x.BookmarkList).FirstOrDefault();
                bookmarkList.Remove(bookmarkList.ElementAt(index));
                var update = Builders<User>.Update.Set("BookmarkList", bookmarkList);


                userCollection.UpdateOne(filter, update);
                myBookmarksBox.Items.RemoveAt(index);
                MessageBox.Show("Bookmark successfully removed!");
            }
            else
            {
                MessageBox.Show("Choose a vehicle to remove from bookmarks!");
            }
        }
    }
}
