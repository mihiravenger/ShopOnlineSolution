using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ShopOnlineContext _shopOnlineContext;

    public ProductRepository(ShopOnlineContext shopOnlineContext)
    {
        _shopOnlineContext = shopOnlineContext;
    }

    public Task<Product> GetProduct(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ProductCategory>> GetProductCategories()
    {
        return await _shopOnlineContext.ProductCategories.ToListAsync();
    }

    public Task<ProductCategory> GetProductCategory(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _shopOnlineContext.Products.ToListAsync();
    }
}
