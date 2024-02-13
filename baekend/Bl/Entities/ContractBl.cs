using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bl.Entities
{
    public class ContractBl
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string ContractDetails { get; set; }
        public DateTime Date { get; set; }
        public string PaymentDetails { get; set; }

        public ContractBl() { }
    }
}
