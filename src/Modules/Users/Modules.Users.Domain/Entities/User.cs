using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Modules.Users.Domain.Entities;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public User(string id, string name, string lastname, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        Lastname = lastname;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}