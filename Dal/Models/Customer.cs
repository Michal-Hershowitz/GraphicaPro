using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


        
    }
}
