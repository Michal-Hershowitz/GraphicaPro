using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;


namespace Dal.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("password")]
        public int? Password { get; set; }

        [BsonElement("name")]
        public string Name{ get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }
        [BsonElement("Contracts")]
        public List<Contract> Contracts { get; set; }

        public Customer(string id, int password, string name, string email, string phone)
        {
            Id = id;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            Contracts = Contracts;
        }


    }
}
