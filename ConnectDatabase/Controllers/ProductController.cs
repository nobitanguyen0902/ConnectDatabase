using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Models;

namespace ProjectStudy.Controllers;

public class ProductController : ControllerBase
{
    private readonly IProductRepository _rspProduct;

    public ProductController(
        IProductRepository rspProduct
    )
    {
        _rspProduct = rspProduct;
    }
    
    [HttpPost]
    [Route("product")]
    public async Task<object> AddProduct()
    {
        var objItem = new ProductModel()
        {
            id = 1,
            name = "IPhone",
            price = 1000000,
        };
        
        await _rspProduct.InsertAsync(objItem);
        
        return new
        {
            
        };
    }
}