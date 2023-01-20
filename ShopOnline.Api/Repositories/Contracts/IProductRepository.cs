using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts;

public interface IProductRepository
{
    Task<IEnumerable<ProductCategory>> GetProductCategories();
    Task<ProductCategory> GetProductCategory(int id);
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetProduct(int id);
}
