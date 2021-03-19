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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");

            var types = Enum.GetValues(typeof(TypesEnum));

            foreach (var item in types)
            {
                VehicleTypesCombobox.Items.Add(item.ToString());
            }

        }

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");



            var vehicle = new Vehicle
            {
                Type = VehicleTypesCombobox.SelectedItem.ToString(),
                DailyPrice = DailyPriceTextBox.Text.ToString(),
                Model = VehicleModelTextBox.Text.ToString(),
                ProductionYear = ProductionYearTextbox.Text.ToString(),
                DateAdded = DateTime.Now,
                Description = VehicleDescriptionTextBox.Text.ToString(),
                Owner = new MongoDBRef("users", Global.ActiveUser.Id)
            };

            collection.InsertOne(vehicle);
            //todo ovo ne pravi listu  u bazi!
            Global.ActiveUser.Vehicles.Add(new MongoDBRef("vehicles", vehicle.Id));

           

            MessageBox.Show("You have successfully added vehicle!");
        }
    }
}
