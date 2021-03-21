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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");
            var collectionReview = database.GetCollection<Review>("reviews");

            var reviewToAdd = new Review
            {
                DateAdded = DateTime.Now,
                Comment = MyCommentTextBox.Text.ToString(),
                User = new MongoDBRef("users", Global.ActiveUser.Id),
                Vehicle = new MongoDBRef("vehicles", Global.VehicleToComment.Id)
            };


            

            var veh = collection.AsQueryable().Where(v => v.Id == Global.VehicleToComment.Id
                            && v.Owner.Id == Global.ActiveUser.Id).FirstOrDefault();
            if (veh == null)
            {
                collectionReview.InsertOne(reviewToAdd);
                var vehicle = Builders<Vehicle>.Filter.Where(v => v.Id == Global.VehicleToComment.Id
                              && v.Owner.Id != Global.ActiveUser.Id);
                var def = Builders<Vehicle>.Update.Push(v => v.Reviews, new MongoDBRef("reviews", reviewToAdd.Id));//definisi update za listu vehicles

                collection.UpdateOne(vehicle, def);//bez ovoga se update ne bi izvrsio
                MessageBox.Show("You have succesfully added comment!");
                AllCommentsListbox.Items.Add(reviewToAdd.Comment);
            }
            else
            {
                MessageBox.Show("You can not comment your own vehicle!");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");
            var collectionReview = database.GetCollection<Review>("reviews");

            var comments = collectionReview.AsQueryable().Where(r => r.Vehicle.Id == Global.VehicleToComment.Id)
                .ToList();

            foreach (var item in comments)
            {
                var user = collectionUser.AsQueryable().Where(u => u.Id == item.User.Id).Select(u => u.Username);
                     
                AllCommentsListbox.Items.Add(
                    item.Comment
                    );
            }


        }

        private void AdditionalInfoButton_Click(object sender, EventArgs e)
        {
        }

        private void AllCommentsListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
            var collection = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");
            var collectionReview = database.GetCollection<Review>("reviews");

            var commentText = AllCommentsListbox.SelectedItem.ToString();
            var comment = collectionReview.AsQueryable().Where(r => r.Vehicle.Id == Global.VehicleToComment.Id
                                                            && r.Comment.Equals(commentText))
                                                            .FirstOrDefault();
            var user = collectionUser.AsQueryable().Where(u => u.Id == comment.User.Id).First();

            MessageBox.Show("DateAdded:" + " " + comment.DateAdded + "\n" +
                         "User:" +  " " + user.Username +"\n"+
                         "Comment:"+" "+ comment.Comment);
        }

        private void DeleteCommentButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");
           
            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");
            var collectionReview = database.GetCollection<Review>("reviews");

            var review = collectionReview.AsQueryable()
                .Where( r=> r.Comment == AllCommentsListbox.SelectedItem.ToString()).First();
            var index = AllCommentsListbox.SelectedIndex;
            if (review.User.Id == Global.ActiveUser.Id)
            {
                var filter = Builders<Review>.Filter.Where(r => r.User.Id == Global.ActiveUser.Id);
                var res = collectionReview.DeleteOne(filter);
                AllCommentsListbox.Items.RemoveAt(index);

                
               

            }
            else
            {
                MessageBox.Show("You can not delete comment which you did not post!");
            }

        }

        private void updateCommentButton_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("RentALLDb");

            var collectionVehicles = database.GetCollection<Vehicle>("vehicles");
            var collectionUser = database.GetCollection<User>("users");
            var collectionReview = database.GetCollection<Review>("reviews");

            var review = collectionReview.AsQueryable()
               .Where(r => r.Comment == AllCommentsListbox.SelectedItem.ToString()).First();
            var index = AllCommentsListbox.SelectedIndex;
            if (review.User.Id == Global.ActiveUser.Id)
            {
               

                string newComment = MyCommentTextBox.Text.ToString();

                var filter = Builders<Review>.Filter.Where(r =>
                                     r.Comment == AllCommentsListbox.SelectedItem.ToString() &&
                                     r.User.Id == Global.ActiveUser.Id);
                //  var update = MongoDB.Driver.Builders<User>.Update.Set("oznake", BsonValue.Create(new List<string> { "test" }));
                var update = Builders<Review>.Update.Set("Comment", newComment);

                collectionReview.UpdateOne(filter, update);
                AllCommentsListbox.Items.Clear();

                AllCommentsListbox.Items.Add(newComment);

                MessageBox.Show("Comment is updated successfully!");
            }
            else
            {
                MessageBox.Show("You can not update comment which you did not post!");
            }
        }
    }
}
