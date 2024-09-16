using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Catalog;
using Microsoft.Extensions.Logging;
using Mapster;
using EShop.Shared.ResponseModels.Catalog;
using System.Linq.Expressions;
using EShop.Shared.ResponseModels.Common;
using EShop.Shared.RequestModels.Common;
using System.Collections.ObjectModel;

namespace EShop.Application.Services.ApplicationService;

public class CatalogService : ICatalogService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CatalogService> _logger;
    private readonly ICloudinaryService _cloudinaryService;

    public CatalogService(IUnitOfWork unitOfWork, ILogger<CatalogService> logger, ICloudinaryService cloudinaryService)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _cloudinaryService = cloudinaryService;
    }

    public async Task<PaginationResponse<GetListProductResponse>> GetAllProducts(PaginationRequest paginationReq)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(p => p.Id)
                .Skip(paginationReq.Page)
                .Take(paginationReq.Limit));

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
            Data = productsDto,
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

    public async Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationReq)
    {
        var totalBrands = await _unitOfWork.BrandRepository.Count();

        var brands = await _unitOfWork.BrandRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                .OrderBy(p => p.Id)
                .Skip(paginationReq.Page)
                .Take(paginationReq.Limit));

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
            Data = brandsDto,
        };
    }

    public async Task<PaginationResponse<GetListProductResponse>> SearchWithSemanticRelevance(string searchText, PaginationRequest paginationRequest)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        var products = await _unitOfWork.ProductRepository
            .Get(
                orderBy: queryable => (IOrderedQueryable<Product>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(paginationRequest.Page)
                    .Take(paginationRequest.Limit),
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
            Data = productsDto,
        };
    }

    public async Task<ServiceResult> CreateProduct(CreateProductRequest req)
    {
        var productEntity = req.Adapt<Product>();

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

    public async Task<ServiceResult> CreateBrand(CreateBrandRequest req)
    {
        var brandEntity = new Brand
        {
            Description = req.Description,
            AvatarUrl = req.AvatarUrl,
            Name = req.Name,
            Code = $"{req.Name.Trim().ToUpper()}-{Guid.NewGuid():N}"
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

    public async Task<ServiceResult> UpdateProduct(UpdateProductRequest req)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(req.Id);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        productEntity.Name = req.Name;
        productEntity.Price = req.Price;
        productEntity.CategoryId = req.CategoryId;
        productEntity.BrandId = req.BrandId;
        productEntity.Sku = req.Sku;
        productEntity.Description = req.Description;
        productEntity.Summary = req.Summary;
        productEntity.Discount = req.Discount;
        productEntity.OtherAttributes = req.OtherAttributes;
        productEntity.ImageUrl = req.ImageUrl;

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

    public async Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageReq)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(uploadProductImageReq.ProductId);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        var uri = await _cloudinaryService.UploadImage(
             uploadProductImageReq.FormFile.FileName,
             uploadProductImageReq.FormFile.OpenReadStream());

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

    public async Task<ServiceResult> UpdateBrand(UpdateBrandRequest req)
    {
        var brandEntity = await _unitOfWork.BrandRepository.GetById(req.Id);

        if (brandEntity is null)
        {
            return ServiceResult.Failed("Not exists brand");
        }

        brandEntity.Description = req.Description;
        brandEntity.AvatarUrl = req.AvatarUrl;
        brandEntity.Name = req.Name;
        brandEntity.Code = $"{req.Name.Trim().ToUpper()}-{Guid.NewGuid():N}";
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
        GetProductsByAdvanceFilterRequest advanceFilterReq)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        Expression<Func<Product, bool>> filter = p =>
            p.Price >= advanceFilterReq.MinPrice &&
            p.Price <= advanceFilterReq.MaxPrice &&
            (!advanceFilterReq.CategoryIdList.Any() || advanceFilterReq.CategoryIdList.Contains(p.CategoryId)) &&
            (!advanceFilterReq.BrandIdList.Any() || advanceFilterReq.BrandIdList.Contains(p.BrandId));

        var products = await _unitOfWork.ProductRepository
            .Get(
                filter: filter,
                orderBy: queryable => (IOrderedQueryable<Product>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(advanceFilterReq.Page)
                    .Take(advanceFilterReq.Limit));

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
            Data = productsDto,
        };
    }
}