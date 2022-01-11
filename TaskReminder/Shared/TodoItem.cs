using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskReminder.Shared
{
    public class TodoItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement]
        public string Title { get; set; }
        [BsonElement]
        public string? Description { get; set; }
        [BsonElement]
        public bool IsDone { get; set; }

        public TodoItem()
        {
        }

    }
}
