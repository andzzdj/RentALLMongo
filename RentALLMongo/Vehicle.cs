using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALLMongo
{
    public class Vehicle
    {
        public ObjectId Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string Model { get; set; }
        public string DailyPrice { get; set; }
        public string ProductionYear { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public MongoDBRef Owner { get; set; }
        public List<MongoDBRef> Reviews { get; set; }
        public List<MongoDBRef> Requests { get; set; }
        public Vehicle()
        {
            Requests = new List<MongoDBRef>();
        }
    }
}
