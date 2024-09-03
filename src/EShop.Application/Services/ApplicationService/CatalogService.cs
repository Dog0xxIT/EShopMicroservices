using EShop.Application.Dto;
using EShop.Application.Dto.Catalog;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Mapster;

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

    public async Task<IEnumerable<ProductDto>> GetAllProducts(int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(p => p.Id)
                .Skip(pageIndex)
                .Take(pageSize));


        var productsDto = products.Adapt<IEnumerable<ProductDto>>();

        return productsDto;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsByBrandId(int brandId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.BrandId == brandId);

        var productsDto = products.Adapt<IEnumerable<ProductDto>>();

        return productsDto;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsByCategoryId(int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.CategoryId == categoryId);

        var productsDto = products.Adapt<IEnumerable<ProductDto>>();

        return productsDto;
    }

    public async Task<IEnumerable<CategoryDto>> GetAllCategories()
    {
        var categories = await _unitOfWork.CategoryRepository
            .Get();

        var categoriesDto = categories.Adapt<IEnumerable<CategoryDto>>();

        return categoriesDto;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsByBrandAndCategoryId(int brandId, int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.CategoryId == categoryId && p.BrandId == brandId);

        var productDtoList = products.Adapt<IEnumerable<ProductDto>>();

        return productDtoList;
    }

    public async Task<ProductDto?> GetProductById(int productId)
    {
        var product = await _unitOfWork.ProductRepository.GetById(productId);

        return product?.Adapt<ProductDto>();
    }

    public async Task<IEnumerable<BrandDto>> GetAllBrands(int pageSize = 10, int pageIndex = 0)
    {
        var brands = await _unitOfWork.BrandRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                .OrderBy(p => p.Id)
                .Skip(pageIndex)
                .Take(pageSize));

        return brands.Adapt<IEnumerable<BrandDto>>();
    }

    public async Task<ProductDto> SearchWithSemanticRelevance(string searchText)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult> CreateProduct(CreateProductDto createProductDto)
    {
        var productEntity = new Product
        {
            Name = createProductDto.Name,
            AvailableStock = createProductDto.AvailableStock,
            BrandId = createProductDto.BrandId,
            CategoryId = createProductDto.CategoryId,
            Description = createProductDto.Description,
            MaxStockThreshold = createProductDto.MaxStockThreshold,
            Price = createProductDto.Price,
        };

        try
        {
            await _unitOfWork.ProductRepository.Create(productEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> CreateBrand(string name, string code)
    {
        var brandEntity = new Brand
        {
            Name = name,
            Code = code
        };

        try
        {
            await _unitOfWork.BrandRepository.Create(brandEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateProduct(UpdateProductDto updateProductDto)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(updateProductDto.Id);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        productEntity.Name = updateProductDto.Name;
        productEntity.AvailableStock = updateProductDto.AvailableStock;
        productEntity.BrandId = updateProductDto.BrandId;
        productEntity.CategoryId = updateProductDto.CategoryId;
        productEntity.Description = updateProductDto.Description;
        productEntity.MaxStockThreshold = updateProductDto.MaxStockThreshold;
        productEntity.Price = updateProductDto.Price;
        productEntity.SetTimeLastModified();

        try
        {
            _unitOfWork.ProductRepository.Update(productEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateImageUrlProduct(int productId, string url)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(productId);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        productEntity.PictureFileName = url;
        productEntity.SetTimeLastModified();

        try
        {
            _unitOfWork.ProductRepository.Update(productEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateBrand(int brandId, string name, string code)
    {
        var brandEntity = await _unitOfWork.BrandRepository.GetById(brandId);

        if (brandEntity is null)
        {
            return ServiceResult.Failed("Not exists brand");
        }

        brandEntity.Name = name;
        brandEntity.Code = code;
        brandEntity.SetTimeLastModified();

        try
        {
            _unitOfWork.BrandRepository.Update(brandEntity);
            await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }
}