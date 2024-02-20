using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Models;

namespace Business.Api.Controllers;

public class UserController : ControllerBase
{
    private readonly IUserRepository _rspUser;

    public UserController(
        IUserRepository rspUser
    )
    {
        _rspUser = rspUser;
    }
    
    [HttpPost]
    [Route("user")]
    public async Task<object> AddUser()
    {
        var objItem = new UserModel()
        {
            id = 1,
            name = "Nguyen van A",
            email = "abc@gmail.com",
            phone = "03974543545",
            address = "Ly thuong kiet"
        };
        
        await _rspUser.InsertAsync(objItem);
        
        return new
        {
            
        };
    }
}