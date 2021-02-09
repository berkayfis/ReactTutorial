using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TwitterAPI.Core.Context
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        public User User{ get; set; }
    }
}
