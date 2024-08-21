using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Product>> GetAllByBuyerId(int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> GetAllCartTypes(int brandId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> CreateOrder(int categoryId, int pageSize = 10, int pageIndex = 0);
    Task<IEnumerable<Product>> Cancel(int brandId, int categoryId, int pageSize = 10,
        int pageIndex = 0);
    Task<IEnumerable<Product>> Ship(int brandId, int categoryId, int pageSize = 10,
        int pageIndex = 0);
}