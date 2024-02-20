using System.Threading.Tasks;
using MongoDB.Driver;
using Repository.Interface;
using Repository.Models;

namespace Repository.Business;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<UserModel> _collection;
    private const string CollectionName = "UserModel";

    public UserRepository(IMongoDatabase db)
    {
        _collection = db.GetCollection<UserModel>(CollectionName);
    }
    
    public async Task InsertAsync(UserModel entity)
    {
        await _collection.InsertOneAsync(entity);
    }
}