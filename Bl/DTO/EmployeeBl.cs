using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bl.DTO
{
    public class EmployeeBl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnore]
        public string? Id { get;  }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("password")]
        public int? Password { get; set; }

        public EmployeeBl(string id, string name, int password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        public EmployeeBl()
        {

        }

    }
}
