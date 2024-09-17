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

    public async Task<PaginationResponse<GetListProductResponse>> GetAllProducts(GetAllProductRequest req)
    {
        var response = new PaginationResponse<GetListProductResponse>();

        if (req.Min > req.Max)
        {
            return response;
        }

        var brands = new List<int>();
        if (req.Brands != null)
        {
            brands = req.Brands
                .Replace(" ", string.Empty)
                .Split(",")
                .Select(i => Convert.ToInt32(i))
                .ToList();
        }

        var categories = new List<int>();
        if (req.Categories != null)
        {
            categories = req.Categories
                .Replace(" ", string.Empty)
                .Split(",")
                .Select(i => Convert.ToInt32(i))
                .ToList();
        }

        Expression<Func<Product, bool>> filter = product =>
            (req.Min == null || product.Price >= req.Min) &&
            (req.Max == null || product.Price <= req.Max) &&
            (!brands.Any() || brands.Contains(product.CategoryId)) &&
            (!categories.Any() || categories.Contains(product.CategoryId)) &&
            (string.IsNullOrEmpty(req.Keyword) || (product.Name.Contains(req.Keyword)
                                                   || product.Description.Contains(req.Keyword)
                                                   || product.Sku.Contains(req.Keyword))) &&
            (string.IsNullOrEmpty(req.Sku) || product.Sku.Equals(req.Sku));


        Func<IQueryable<Product>, IOrderedQueryable<Product>> orderingFunc =
            queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(product => product.Id)
                .Skip((req.Page - 1) * req.Limit)
                .Take(req.Limit);

        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: orderingFunc, filter: filter);

        var sortByList = new Dictionary<string, string>
        {
            ["id"] = nameof(Product.Id),
            ["price"] = nameof(Product.Price),
            ["date_modified"] = nameof(Product.LastModified),
        };

        if (sortByList[req.SortBy] == nameof(Product.Price))
        {
            products = req.SortDescending ? products.OrderBy(product => product.Price) : products.OrderByDescending(product => product.Price);
        }
        else if (sortByList[req.SortBy] == nameof(Product.LastModified))
        {
            products = req.SortDescending ? products.OrderBy(product => product.LastModified) : products.OrderByDescending(product => product.LastModified);
        }

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

        var totalProducts = await _unitOfWork.ProductRepository.Count();
        var totalPage = req.Limit != 1 ? (totalProducts / req.Limit) + 1 : 0;

        return new PaginationResponse<GetListProductResponse>
        {
            Data = productsDto,
            Meta = new Pagination
            {
                Count = productsDto.Count(),
                CurrentPage = req.Page,
                Total = totalProducts,
                TotalPages = totalPage,
                PerPage = req.Limit
            }
        };
    }

    public async Task<PaginationResponse<GetAllCategoriesResponse>> GetAllCategories(PaginationRequest paginationReq)
    {

        var categories = Enumerable.Empty<Category>();

        if (paginationReq.SortDescending)
        {
            categories = await _unitOfWork.CategoryRepository.Get(
                orderBy: queryable => (IOrderedQueryable<Category>)queryable
                    .OrderByDescending(c => c.Id)
                    .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                    .Take(paginationReq.Limit));
        }
        else
        {
            categories = await _unitOfWork.CategoryRepository.Get(
                orderBy: queryable => (IOrderedQueryable<Category>)queryable
                    .OrderBy(c => c.Id)
                    .Skip((paginationReq.Page - 1) * paginationReq.Limit)
                    .Take(paginationReq.Limit));
        }

        var categoriesDto = categories.Adapt<List<GetAllCategoriesResponse>>();

        var totalCategory = await _unitOfWork.CategoryRepository.Count();
        var totalPage = paginationReq.Limit != 1 ? (totalCategory / paginationReq.Limit) + 1 : 0;

        return new PaginationResponse<GetAllCategoriesResponse>
        {
            Data = categoriesDto,
            Meta = new Pagination
            {
                Count = categoriesDto.Count(),
                CurrentPage = paginationReq.Page,
                Total = totalCategory,
                TotalPages = totalPage,
                PerPage = paginationReq.Limit
            }
        };
    }

    public async Task<GetProductByIdResponse?> GetProductById(int productId)
    {
        var products = await _unitOfWork.ProductRepository
            .Get(
                filter: p => p.Id == productId,
                includeProperties: [nameof(Product.Brand), nameof(Product.Category)]);

        var product = products.FirstOrDefault();
        if (product is null)
        {
            return null;
        }

        return new GetProductByIdResponse
        {
            Id = product.Id,
            Name = product.Name,
            DescriptionSections = [product.Description],
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
            Variants = new()
        };
    }

    public async Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationReq)
    {
        var brands = Enumerable.Empty<Brand>();

        if (paginationReq.SortDescending)
        {
            brands = await _unitOfWork.BrandRepository
                .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                    .OrderByDescending(p => p.Id)
                    .Skip(paginationReq.Page)
                    .Take(paginationReq.Limit));
        }
        else
        {
            brands = await _unitOfWork.BrandRepository
                .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                    .OrderByDescending(p => p.Id)
                    .Skip(paginationReq.Page)
                    .Take(paginationReq.Limit));
        }

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

        var totalBrand = await _unitOfWork.BrandRepository.Count();
        var totalPage = paginationReq.Limit != 1 ? (totalBrand / paginationReq.Limit) + 1 : 0;

        return new PaginationResponse<GetListBrandsResponse>
        {
            Data = brandsDto,
            Meta = new Pagination
            {
                Count = brandsDto.Count(),
                CurrentPage = paginationReq.Page,
                Total = totalBrand,
                TotalPages = totalPage,
                PerPage = paginationReq.Limit
            }
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

    public async Task<ServiceResult> DeleteImageProduct(int productId)
    {
        var productEntity = await _unitOfWork.ProductRepository.GetById(productId);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        var uri = await _cloudinaryService.DeleteImage(productId);

        productEntity.ImageUrl = string.Empty;
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

    public async Task<bool> CheckExistBrand(int brandId)
    {
        var brand = await _unitOfWork.BrandRepository.GetById(brandId);
        return brand != null;
    }

    public async Task<bool> CheckExistProduct(int productId)
    {
        var product = await _unitOfWork.ProductRepository.GetById(productId);
        return product != null;
    }

    public async Task<bool> CheckExistCategory(int categoryId)
    {
        var category = await _unitOfWork.CategoryRepository.GetById(categoryId);
        return category != null;
    }
}