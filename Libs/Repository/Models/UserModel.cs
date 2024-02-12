using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Repository.Models;

public class UserModel
{
    // [BsonId]
    // [BsonRepresentation(BsonType.ObjectId)]
    public long id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
}