using MongoDB.Bson;
using MongoDB.Driver;
using RentALL;
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
        public RequestTypesEnum Status { get; set; }
        public  User Owner { get; set; }
        public User Renter { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
