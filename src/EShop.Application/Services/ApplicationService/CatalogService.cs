using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EShop.Application.Services.ApplicationService;

public class CatalogService : ICatalogService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CatalogService> _logger;

    public CatalogService(IUnitOfWork unitOfWork, ILogger<CatalogService> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<IEnumerable<Product>> GetAllProducts(int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(p => p.Id)
                .Skip(pageIndex)
                .Take(pageSize));

        return products;
    }

    public async Task<IEnumerable<Product>> GetProductsByBrandId(int brandId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.BrandId == brandId);

        return products;
    }

    public async Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.CategoryId == categoryId);

        return products;
    }

    public async Task<IEnumerable<Product>> GetProductsByBrandAndCategoryId(int brandId, int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.CategoryId == categoryId && p.BrandId == brandId);

        return products;
    }

    public async Task<Product?> GetProductById(int productId)
    {
        var product = await _unitOfWork.ProductRepository.GetById(productId);

        return product;
    }

    public async Task<Brand> GetAllBrands()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetAllImagesOfProduct()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> SearchWithSemanticRelevance()
    {
        throw new NotImplementedException();
    }

    public async Task<int> UploadProductImage()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateProduct()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateBrand()
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateProduct()
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateBrand()
    {
        throw new NotImplementedException();
    }
}