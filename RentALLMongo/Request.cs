using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALLMongo
{
    public class Request
    {
        public ObjectId Id { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime AnsweredDate { get; set; }
        public bool IsAccepted { get; set; }
        public  MongoDBRef Owner { get; set; }
        public MongoDBRef Renter { get; set; }
        public MongoDBRef Vehicle { get; set; }
    }
}
