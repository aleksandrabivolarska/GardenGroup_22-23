using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class DatabaseModel
    {
        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("sizeOnDisk")]
        public double sizeOnDisk { get; set; }

        [BsonElement("empty")]
        public bool emptyVolume { get; set; }
    }
}
