using MongoDB.Driver;
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

        private void allVehiclesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");

            var allVehicles = collection.AsQueryable().ToList();
           
            foreach (var item in allVehicles)
            {

                allVehiclesCombobox.Items.Add(item.Model);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            //todo ovo je za potrebe komentara i treba da se napise na bolji nacin
            var vehicle = collection.AsQueryable()
                .Where(v=>v.Model == allVehiclesCombobox.SelectedItem.ToString()).FirstOrDefault();

            Global.VehicleToComment = vehicle;
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.ShowDialog();
        }
    }
}
