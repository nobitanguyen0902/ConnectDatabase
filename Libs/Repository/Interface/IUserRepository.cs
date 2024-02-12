using Repository.Models;

namespace Repository.Interface;

public interface IUserRepository
{
    Task InsertAsync(UserModel entity);
}