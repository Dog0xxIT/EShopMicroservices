using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Catalog;
using Microsoft.Extensions.Logging;
using Mapster;
using EShop.Shared.ResponseModels.Catalog;
using System.Linq.Expressions;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.RequestModels.Common;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace EShop.Application.Services.ApplicationService;

public class CatalogService : ICatalogService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CatalogService> _logger;
    private readonly ICloudinaryService _cloudinaryService;

    public CatalogService(IUnitOfWork unitOfWork, ILogger<CatalogService> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<PaginationResponse<GetListProductResponse>> GetAllProducts(PaginationRequest paginationRequest)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(p => p.Id)
                .Skip(paginationRequest.PageIndex)
                .Take(paginationRequest.PageSize));

        var productsDto = products.Select(product =>
            new GetListProductResponse
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Price = product.Price,
                BrandId = product.BrandId,
                Discount = product.Discount,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                ReviewsCount = product.ReviewsCount,
                Star = product.Star,
                TotalBuyers = product.TotalBuyers,
                Sku = product.Sku,
                Summary = product.Summary,
            }).ToList();

        return new PaginationResponse<GetListProductResponse>
        {
            Total = totalProducts,
            Data = productsDto,
            PageIndex = paginationRequest.PageIndex,
            PageSize = paginationRequest.PageSize,
            ItemsPerPage = productsDto.Count()
        };
    }
    public async Task<IEnumerable<GetAllCategoriesResponse>> GetTopCategories(int number = 10)
    {
        var categories = await _unitOfWork.CategoryRepository
            .Get();

        var categoryIdBuyerCountDict = categories
            .ToDictionary(c => c.Id, _ => 0); // key-CategoryId, value-BuyerCount

        var products = await _unitOfWork.ProductRepository.Get();
        foreach (var product in products)
        {
            categoryIdBuyerCountDict[product.CategoryId] += product.TotalBuyers;
        }

        var topCategoryIds = categoryIdBuyerCountDict
            .OrderByDescending(d => d.Value)
            .Take(number)
            .Select(k => k.Key);

        var topCategory = categories.Where(c => topCategoryIds.Contains(c.Id));

        var categoriesDto = topCategory.Adapt<IEnumerable<GetAllCategoriesResponse>>();
        return categoriesDto;
    }

    public async Task<IEnumerable<GetAllCategoriesResponse>> GetAllCategories()
    {
        var categories = await _unitOfWork.CategoryRepository
            .Get();

        var categoriesDto = categories.Adapt<IEnumerable<GetAllCategoriesResponse>>();

        return categoriesDto;
    }

    public async Task<GetProductByIdResponse?> GetProductById(int productId)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(
                filter: p => p.Id == productId,
                includeProperties: new[] { nameof(Product.Brand), nameof(Product.Category) });

        var product = products.FirstOrDefault();
        if (product == null)
        {
            return null;
        }

        return new GetProductByIdResponse
        {
            Id = product.Id,
            Name = product.Name,
            DescriptionSections = new List<string> { product.Description },
            Price = product.Price,
            ImageUrl = product.ImageUrl,
            Discount = product.Discount,
            ReviewsCount = product.ReviewsCount,
            Star = product.Star,
            TotalBuyers = product.TotalBuyers,
            Sku = product.Sku,
            Summary = product.Summary,
            Brand = new()
            {
                BrandId = product.BrandId,
                BrandName = product.Brand.Name,
                ThumbnailUrl = product.Brand.AvatarUrl,
                Code = product.Brand.Code,
            },
            Category = new()
            {
                CategoryId = product.CategoryId,
                CategoryName = product.Category.Name,
                ThumbnailUrl = product.Category.ThumbnailUrl,
                Code = product.Category.Code,
            },
        };
    }

    public async Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationRequest)
    {
        var totalBrands = await _unitOfWork.BrandRepository.Count();

        var brands = await _unitOfWork.BrandRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                .OrderBy(p => p.Id)
                .Skip(paginationRequest.PageIndex)
                .Take(paginationRequest.PageSize));

        var brandsDto = new Collection<GetListBrandsResponse>();

        foreach (var brand in brands)
        {
            var products = await _unitOfWork.ProductRepository
                .Get(filter: product => product.BrandId == brand.Id);

            brandsDto.Add(new GetListBrandsResponse
            {
                Code = brand.Code,
                Description = brand.Description,
                Id = brand.Id,
                Name = brand.Name,
                Thumnai = brand.AvatarUrl,
                ProductCount = products.Count()
            });
        }

        return new PaginationResponse<GetListBrandsResponse>
        {
            Total = totalBrands,
            Data = brandsDto,
            PageIndex = paginationRequest.PageIndex,
            PageSize = paginationRequest.PageSize,
            ItemsPerPage = brandsDto.Count()
        };
    }

    public async Task<PaginationResponse<GetListProductResponse>> SearchWithSemanticRelevance(string searchText, PaginationRequest paginationRequest)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        var products = await _unitOfWork.ProductRepository
            .Get(
                orderBy: queryable => (IOrderedQueryable<Product>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(paginationRequest.PageIndex)
                    .Take(paginationRequest.PageSize),
                filter: p => p.Name.Contains(searchText));

        var productsDto = products.Select(product =>
            new GetListProductResponse
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Price = product.Price,
                BrandId = product.BrandId,
                Discount = product.Discount,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                ReviewsCount = product.ReviewsCount,
                Star = product.Star,
                TotalBuyers = product.TotalBuyers,
                Sku = product.Sku,
                Summary = product.Summary,
            });

        return new PaginationResponse<GetListProductResponse>
        {
            Total = totalProducts,
            Data = productsDto,
            PageIndex = paginationRequest.PageIndex,
            PageSize = paginationRequest.PageSize,
            ItemsPerPage = productsDto.Count()
        };
    }

    public async Task<ServiceResult> CreateProduct(CreateProductDto createProductDto)
    {
        var productEntity = new Product
        {
            Name = createProductDto.Name,
            BrandId = createProductDto.BrandId,
            CategoryId = createProductDto.CategoryId,
            Description = createProductDto.Description,
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
        productEntity.BrandId = updateProductDto.BrandId;
        productEntity.CategoryId = updateProductDto.CategoryId;
        productEntity.Description = updateProductDto.Description;
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

    public async Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageRequest)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(uploadProductImageRequest.ProductId);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        var uri = await _cloudinaryService.UploadProductImage(
             uploadProductImageRequest.ProductId,
             uploadProductImageRequest.FormFile.FileName,
             uploadProductImageRequest.FormFile.OpenReadStream());

        productEntity.ImageUrl = uri.AbsoluteUri;
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

    public async Task<PaginationResponse<GetListProductResponse>> GetProductsByAdvanceFilter(
        GetProductsByAdvanceFilterRequest advanceFilterRequest)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        Expression<Func<Product, bool>> filter = p =>
            p.Price >= advanceFilterRequest.MinPrice &&
            p.Price <= advanceFilterRequest.MaxPrice &&
            (!advanceFilterRequest.CategoryIdList.Any() || advanceFilterRequest.CategoryIdList.Contains(p.CategoryId)) &&
            (!advanceFilterRequest.BrandIdList.Any() || advanceFilterRequest.BrandIdList.Contains(p.BrandId));

        var products = await _unitOfWork.ProductRepository
            .Get(
                filter: filter,
                orderBy: queryable => (IOrderedQueryable<Product>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(advanceFilterRequest.PageIndex)
                    .Take(advanceFilterRequest.PageSize));

        var productsDto = products.Select(product =>
            new GetListProductResponse
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Price = product.Price,
                BrandId = product.BrandId,
                Discount = product.Discount,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                ReviewsCount = product.ReviewsCount,
                Star = product.Star,
                TotalBuyers = product.TotalBuyers,
                Sku = product.Sku,
                Summary = product.Summary,
            });

        return new PaginationResponse<GetListProductResponse>
        {
            Total = totalProducts,
            Data = productsDto,
            PageIndex = advanceFilterRequest.PageIndex,
            PageSize = advanceFilterRequest.PageSize,
            ItemsPerPage = productsDto.Count()
        };
    }
}