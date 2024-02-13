using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bl.DTO
{
    public class GraphicsWorkBl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; }

        [BsonElement("price")]
        public float? Price { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        public GraphicsWorkBl(string name, float price)
        {
            Name = name;

            Price = price;
        }

        public GraphicsWorkBl()
        {
            
        }


    }
}
