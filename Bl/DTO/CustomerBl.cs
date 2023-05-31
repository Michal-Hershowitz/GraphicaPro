using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bl.DTO
{
    public class CustomerBl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnore]
        public string? Id { get;  }

        [BsonElement("password")]
        public int? Password { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        public CustomerBl(string id, int password, string name, string email, string phone)
        {
            Id = id;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
        }
        public CustomerBl() { }
    }
}
