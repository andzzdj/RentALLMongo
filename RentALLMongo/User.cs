using MongoDB.Bson;
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
        
        //todo dodaj potrebne liste

    }
}
