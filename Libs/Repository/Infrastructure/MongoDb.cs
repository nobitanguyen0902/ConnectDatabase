using MongoDB.Driver;

namespace Repository.Infrastructure;

public interface IMongoDb
{
    public IMongoDatabase db { get; set; }
}

public class MongoDb : IMongoDb
{
    public IMongoDatabase db { get; set; }
    
    public MongoDb(IMongoDatabase db)
    {
        this.db = db;
    }
}