using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALLMongo
{
    public class Review
    {
        public ObjectId Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public MongoDBRef User { get; set; }
        public MongoDBRef Vehicle { get; set; }
    }
}
