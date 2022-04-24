using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Kerry_Challenge.Models
{
    public class LikeBooksModel
    {
        [BsonElement("user_id")]
        public string? user_id { get; set; }
        [BsonElement("book_id")]
        public string? book_id { get; set; }
    }
}
