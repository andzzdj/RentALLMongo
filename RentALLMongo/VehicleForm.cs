using MongoDB.Driver;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RentALLMongo
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.ShowDialog();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void myVehiclesButton_Click(object sender, EventArgs e)
        {
            Vehicles.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");

            var vehicles = collection.AsQueryable().Where(x => x.UserOwner.Id == Global.ActiveUser.Id).ToList();

            foreach (Vehicle v in vehicles)
            {
                Vehicles.Items.Add("Type: " + v.Type + "  Model: " + v.Model + "  Daily price: " + v.DailyPrice + "  Production year: " + v.ProductionYear);
            }
        }

        private void Vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Description.Items.Clear();
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            var index = Vehicles.SelectedIndex;

            var vehicles = collection.AsQueryable().Where(x => x.UserOwner.Id == Global.ActiveUser.Id).ToList();

            Description.Items.Add(vehicles.ElementAt(index).Description);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var index = Vehicles.SelectedIndex;
            if (index >= 0)
            {
                Vehicles.Items.Clear();
                Description.Items.Clear();
                var update = updateComboBox.SelectedItem.ToString();
                var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                var database = client.GetDatabase("RentALLDb");
                var collection = database.GetCollection<Vehicle>("vehicles");

                var vehicles = collection.AsQueryable().Where(x => x.UserOwner.Id == Global.ActiveUser.Id).ToList();

                var selectedvehicle = vehicles.ElementAt(index);

                if (update == "Daily price")
                {
                    string newPrice = updateTextBox.Text;

                    var filter = Builders<Vehicle>.Filter.Where(p => p.Id == selectedvehicle.Id);
                    var updateVehicle = Builders<Vehicle>.Update.Set("DailyPrice", newPrice);
                    collection.UpdateOne(filter, updateVehicle);
                    MessageBox.Show("Daily price is updated successfully!");
                }
                else
                {
                    string newDescription = updateTextBox.Text;

                    var filter = Builders<Vehicle>.Filter.Where(p => p.Id == selectedvehicle.Id);
                    var updateVehicle = Builders<Vehicle>.Update.Set("Description", newDescription);
                    collection.UpdateOne(filter, updateVehicle);
                    MessageBox.Show("Description is updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a car you want to update!");
            }
        }

        private void deleteVehicleButton_Click(object sender, EventArgs e)
        {
            if (Vehicles.SelectedIndex >= 0)
            {
                var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
                var database = client.GetDatabase("RentALLDb");
                var collection = database.GetCollection<Vehicle>("vehicles");
                var index = Vehicles.SelectedIndex;

                var vehicles = collection.AsQueryable().Where(x => x.UserOwner.Id == Global.ActiveUser.Id).ToList();

                var filter = Builders<Vehicle>.Filter.Where(p => p.Id == vehicles.ElementAt(index).Id);

                collection.DeleteOne(filter);
                MessageBox.Show("Vehicle successfully deleted!");
                Description.Items.Clear();
            }
            else
            {
                MessageBox.Show("You have to choose a car you want to delete!");
            }
        }

        private void otherVehiclesButton_Click(object sender, EventArgs e)
        {
            OtherVehiclesForm otherVehiclesForm = new OtherVehiclesForm();
            otherVehiclesForm.ShowDialog();
        }
    }
}
