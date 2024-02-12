using MongoDB.Driver;
using Repository.Interface;
using Repository.Models;

namespace Repository.Business;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<ProductModel> _collection;
    private const string CollectionName = "ProductModel";
    
    public ProductRepository(IMongoDatabase db)
    {
        _collection = db.GetCollection<ProductModel>(CollectionName);
    }
    
    public async Task InsertAsync(ProductModel entity)
    {
        await _collection.InsertOneAsync(entity);
    }
}