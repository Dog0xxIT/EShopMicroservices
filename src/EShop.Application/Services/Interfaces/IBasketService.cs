using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IBasketService
{
    Task<IEnumerable<Product>> GetBasketByCustomerId(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> UpdateQty(int brandId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> Delete(int categoryId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> GetProductsByBrandAndCategoryId(int brandId, int categoryId, int pageSize = 10,
        int pageIndex = 0);
}