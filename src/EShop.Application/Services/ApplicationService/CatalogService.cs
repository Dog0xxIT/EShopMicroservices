using AutoMapper;
using EShop.Application.Dto;
using EShop.Application.Dto.Catalog;
using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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


        var productDtoList = products.Adapt<IEnumerable<ProductDto>>();

        return productDtoList;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsByBrandId(int brandId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.BrandId == brandId);

        var productDtoList = products.Adapt<IEnumerable<ProductDto>>();

        return productDtoList;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsByCategoryId(int categoryId, int pageSize = 10, int pageIndex = 0)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(filter: p => p.CategoryId == categoryId);

        var productDtoList = products.Adapt<IEnumerable<ProductDto>>();

        return productDtoList;
    }

    public async Task<IEnumerable<CategoryDto>> GetAllCategories()
    {
        var categories = await _unitOfWork.CategoryRepository
            .Get();

        var categoryDtoList = categories.Adapt<IEnumerable<CategoryDto>>();

        return categoryDtoList;
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

    public async Task<IEnumerable<BrandDto>> GetAllBrands()
    {
        var brands = await _unitOfWork.BrandRepository.Get();

        return brands.Adapt<IEnumerable<BrandDto>>();
    }

    public async Task<ProductDto> GetAllImagesOfProduct()
    {
        throw new NotImplementedException();
    }

    public async Task<ProductDto> SearchWithSemanticRelevance()
    {
        throw new NotImplementedException();
    }

    public async Task<int> UploadProductImage()
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> CreateProduct(CreateProductDto createProductDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> CreateBrand(string name, string code)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> UpdateProduct(UpdateProductDto updateProductDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult<int>> UpdateBrand(int brandId, string name, string code)
    {
        throw new NotImplementedException();
    }
}