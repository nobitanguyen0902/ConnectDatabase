using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Interface;

public interface IProductRepository
{
    Task InsertAsync(ProductModel entity);
}