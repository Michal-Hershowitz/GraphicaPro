﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Dal.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string? Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("password")]
        public int? Password { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }


        public Employee(string id, string name, int password, string type)
        {
            Id = id;
            Name = name;
            Password = password;
            Type = type;
        }
    }
}
