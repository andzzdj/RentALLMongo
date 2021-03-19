using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentALL
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Town { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<MongoDBRef> Vehicles { get; set; }
        public List<MongoDBRef> SentRequests { get; set; }
        public List<MongoDBRef> ReceivedRequests { get; set; }
        public User()
        {
            Vehicles = new List<MongoDBRef>();
            SentRequests = new List<MongoDBRef>();
            ReceivedRequests = new List<MongoDBRef>();
        }

        //todo dodaj potrebne liste

    }
}
