using MongoDB.Driver;
using Repository.Infrastructure;
using Repository.Interface;
using Repository.Models;

namespace Repository.Business;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<UserModel> _collection;
    private const string CollectionName = "UserModel";

    public UserRepository(IMongoDb db)
    {
        _collection = db.db.GetCollection<UserModel>(CollectionName);
    }
    
    public async Task InsertAsync(UserModel entity)
    {
        await _collection.InsertOneAsync(entity);
    }
}