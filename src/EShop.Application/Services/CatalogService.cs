using EShop.Shared.RequestModels.Catalog;
using Microsoft.Extensions.Logging;
using Mapster;
using EShop.Shared.ResponseModels.Catalog;
using System.Linq.Expressions;
using EShop.Shared.RequestModels.Common;
using System.Collections.ObjectModel;
using static EShop.Shared.ResponseModels.Catalog.GetProductByIdResponse;
using EShop.Application.Interfaces;
using EShop.Application.Models;

namespace EShop.Application.Services;

public class CatalogService : ICatalogService
{
    private readonly IDbContext _context;
    private readonly ILogger<CatalogService> _logger;
    private readonly ICloudinaryService _cloudinaryService;

    public CatalogService(IDbContext context, ILogger<CatalogService> logger, ICloudinaryService cloudinaryService)
    {
        _context = context;
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

        var queryable = _context.Products
            .Where(product => req.Min == null || product.Price >= req.Min)
            .Where(product => req.Max == null || product.Price <= req.Max)
            .Where(product => !brands.Any() || brands.Contains(product.CategoryId))
            .Where(product => !categories.Any() || categories.Contains(product.CategoryId))
            .Where(product => string.IsNullOrEmpty(req.Sku) || product.Sku.Equals(req.Sku))
            .Where(product => string.IsNullOrEmpty(req.Keyword) || product.Name.Contains(req.Keyword)
                                                                || product.Description.Contains(req.Keyword)
                                                                || product.Sku.Contains(req.Keyword))
            .Skip((req.Page - 1) * req.Limit)
            .Take(req.Limit)
            .AsNoTracking();

        var sortByList = new Dictionary<string, string>
        {
            ["id"] = nameof(Product.Id),
            ["price"] = nameof(Product.Price),
            ["date_modified"] = nameof(Product.LastModified),
        };

        if (sortByList[req.SortBy] == nameof(Product.Price))
        {
            queryable = req.SortDescending ?
                queryable.OrderBy(product => product.Price) :
                queryable.OrderByDescending(product => product.Price);
        }
        else if (sortByList[req.SortBy] == nameof(Product.LastModified))
        {
            queryable = req.SortDescending ?
                queryable.OrderBy(product => product.LastModified) :
                queryable.OrderByDescending(product => product.LastModified);
        }

        var products = await queryable.ToListAsync();

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
                Summary = product.ShortDescription,
            }).ToList();

        var totalProducts = await _context.Products.CountAsync();
        var totalPage = req.Limit != 1 ? totalProducts / req.Limit + 1 : 0;

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
        var queryable = _context.Categories
            .Skip((paginationReq.Page - 1) * paginationReq.Limit)
            .Take(paginationReq.Limit);

        queryable = paginationReq.SortDescending
            ? queryable.OrderByDescending(c => c.Id)
            : queryable.OrderBy(c => c.Id);

        var categories = await queryable.ToListAsync();

        var categoriesDto = categories.Adapt<List<GetAllCategoriesResponse>>();

        var totalCategory = await _context.Categories.CountAsync();
        var totalPage = paginationReq.Limit != 1 ? totalCategory / paginationReq.Limit + 1 : 0;

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
        var product = await _context.Products
            .Include(p => p.Brand)
            .Include(p => p.Category)
            .Include(p => p.ProductVariant)
                .ThenInclude(pv => pv.VariantOptions)
                    .ThenInclude(vo => vo.OptionType)
            .SingleOrDefaultAsync(p => p.Id == productId);

        if (product is null)
        {
            return null;
        }

        var variantsResponse = new List<Variant>();

        foreach (var productVariant in product.ProductVariant)
        {
            var variantList = productVariant.VariantOptions.Select(v => new Variant
            {
                OptionType = v.OptionType.Name,
                OptionTypeId = v.OptionTypeId,
                OptionValue = v.OptionValue,
                ProductId = productVariant.ProductId,
                ProductVariantId = productVariant.Id,
                Sku = productVariant.Sku,
            });
            variantsResponse.AddRange(variantList);
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
            ShortDescription = product.ShortDescription,
            Brand = new()
            {
                BrandId = product.BrandId,
                BrandName = product.Brand?.Name,
                ThumbnailUrl = product.Brand?.AvatarUrl,
                Code = product.Brand.Code,
            },
            Category = new()
            {
                CategoryId = product.CategoryId,
                CategoryName = product.Category?.Name,
                ThumbnailUrl = product.Category?.ThumbnailUrl,
                Code = product.Category?.Code,
            },
            Variants = variantsResponse,
        };
    }

    public async Task<PaginationResponse<GetListBrandsResponse>> GetAllBrands(PaginationRequest paginationReq)
    {
        var queryable = _context.Brands
             .Skip(paginationReq.Page)
             .Take(paginationReq.Limit);

        queryable = paginationReq.SortDescending ?
            queryable.OrderByDescending(p => p.Id) :
            queryable.OrderBy(p => p.Id);

        var brands = await queryable.ToListAsync();

        var brandsDto = new Collection<GetListBrandsResponse>();

        foreach (var brand in brands)
        {
            var countProduct = await _context.Products
                .Where(product => product.BrandId == brand.Id)
                .CountAsync();

            brandsDto.Add(new GetListBrandsResponse
            {
                Code = brand.Code,
                Description = brand.Description,
                Id = brand.Id,
                Name = brand.Name,
                Thumnai = brand.AvatarUrl,
                ProductCount = countProduct
            });
        }

        var totalBrand = await _context.Brands.CountAsync();
        var totalPage = paginationReq.Limit != 1 ? totalBrand / paginationReq.Limit + 1 : 0;

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
            //await _unitOfWork.ProductRepository.Create(productEntity);
            //await _unitOfWork.Commit();
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
            //await _unitOfWork.BrandRepository.Create(brandEntity);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateProduct(UpdateProductRequest req)
    {
        var productEntity = await _context.Products.FindAsync(req.Id);

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
        productEntity.ShortDescription = req.Summary;
        productEntity.Discount = req.Discount;
        productEntity.ImageUrl = req.ImageUrl;

        productEntity.SetTimeLastModified();

        try
        {
            //_unitOfWork.ProductRepository.Update(productEntity);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateImageProduct(UploadProductImageRequest uploadProductImageReq)
    {
        var productEntity = await _context.Products.FindAsync(uploadProductImageReq.ProductId);

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
            //_unitOfWork.ProductRepository.Update(productEntity);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> DeleteImageProduct(int productId)
    {
        var productEntity = await _context.Products.FindAsync(productId);

        if (productEntity is null)
        {
            return ServiceResult.Failed("Not exists product");
        }

        var uri = await _cloudinaryService.DeleteImage(productId);

        productEntity.ImageUrl = string.Empty;
        productEntity.SetTimeLastModified();

        try
        {
            //_unitOfWork.ProductRepository.Update(productEntity);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<ServiceResult> UpdateBrand(UpdateBrandRequest req)
    {
        var brandEntity = await _context.Brands.FindAsync(req.Id);

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
            //_unitOfWork.BrandRepository.Update(brandEntity);
            //await _unitOfWork.Commit();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            return ServiceResult.Failed(ex.Message);
        }
    }

    public async Task<bool> CheckExistBrand(int brandId)
    {
        var brand = await _context.Brands.FindAsync(brandId);
        return brand != null;
    }

    public async Task<bool> CheckExistProduct(int productId)
    {
        var product = await _context.Products.FindAsync(productId);
        return product != null;
    }

    public async Task<bool> CheckExistCategory(int categoryId)
    {
        var category = await _context.Categories.FindAsync(categoryId);
        return category != null;
    }
}