﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class GraphicsWork
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("price")]
        public float? Price { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        public GraphicsWork(string name,float price) 
        {
            Name = name;
            
            Price = price;
        }
    }
}
