using EShop.Application.Entities;
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Catalog;
using Microsoft.Extensions.Logging;
using Mapster;
using EShop.Shared.ResponseModels.Catalog;
using System.Linq.Expressions;
using EShop.Shared.ResponseModels.Common;

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

    public async Task<PaginationResponse<GetListProductResponse>> GetAllProducts(int pageSize = 10, int pageIndex = 0)
    {
        var totalProducts = await _unitOfWork.ProductRepository.Count();

        var products = await _unitOfWork.ProductRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Product>)queryable
                .OrderBy(p => p.Id)
                .Skip(pageIndex)
                .Take(pageSize));

        var productsDto = new List<GetListProductResponse>();

        foreach (var product in products)
        {
            var rating = await _unitOfWork.RatingRepository
                .Get(filter: r => r.ProductId == product.Id) ?? new List<Rating>();

            var totalRating = rating.Count();

            productsDto.Add(
                new GetListProductResponse
                {
                    Id = product.Id,
                    CategoryId = product.CategoryId,
                    //AvailableStock = product.AvailableStock,
                    Price = product.Price,
                    BrandId = product.BrandId,
                    Discount = product.Discount,
                    Name = product.Name,
                    PictureLink = product.ImageUrl,
                    TotalRating = totalRating,
                    AvgStarPoint = totalRating != 0 ? rating.Sum(r => r.StarPoint) / totalRating : default,
                });
        }

        return new PaginationResponse<GetListProductResponse>
        {
            Total = totalProducts,
            Data = productsDto,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
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

        var rating = await _unitOfWork.RatingRepository
            .Get(filter: r => r.ProductId == product.Id) ?? new List<Rating>();

        var totalRating = rating.Count();

        return new GetProductByIdResponse
        {
            ProductId = product.Id,
            Name = product.Name,
            Summary = product.Description,
            DescriptionSections = new List<string> { product.Description },
            Price = product.Price,
            PictureFileName = product.ImageUrl,
            AvailableStock = product.Id,
            CountReview = totalRating,
            AvgStarPoint = totalRating != 0 ? rating.Sum(r => r.StarPoint) / totalRating : default,
            Brand = new()
            {
                BrandId = product.BrandId,
                BrandName = product.Brand.Name,
                //Thumbnail = product.Brand.AvatarLink,
                Code = product.Brand.Code,
            },
            Category = new()
            {
                CategoryId = product.CategoryId,
                CategoryName = product.Category.Name,
                Thumbnail = product.Category.Icon,
                Code = product.Category.Code,
            },
        };
    }

    public async Task<IEnumerable<GetListBrandsResponse>> GetAllBrands(int pageSize = 10, int pageIndex = 0)
    {
        var brands = await _unitOfWork.BrandRepository
            .Get(orderBy: queryable => (IOrderedQueryable<Brand>)queryable
                .OrderBy(p => p.Id)
                .Skip(pageIndex)
                .Take(pageSize));

        return brands.Adapt<IEnumerable<GetListBrandsResponse>>();
    }

    public async Task<GetListProductResponse> SearchWithSemanticRelevance(string searchText)
    {
        throw new NotImplementedException();
    }

    public async Task<ServiceResult> CreateProduct(CreateProductDto createProductDto)
    {
        var productEntity = new Product
        {
            Name = createProductDto.Name,
            //AvailableStock = createProductDto.AvailableStock,
            BrandId = createProductDto.BrandId,
            CategoryId = createProductDto.CategoryId,
            Description = createProductDto.Description,
            //MaxStockThreshold = createProductDto.MaxStockThreshold,
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
        //productEntity.AvailableStock = updateProductDto.AvailableStock;
        productEntity.BrandId = updateProductDto.BrandId;
        productEntity.CategoryId = updateProductDto.CategoryId;
        productEntity.Description = updateProductDto.Description;
        //productEntity.MaxStockThreshold = updateProductDto.MaxStockThreshold;
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

        productEntity.ImageUrl = url;
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
        GetProductsByAdvanceFilterRequest advanceFilterRequest, int pageSize = 10,
        int pageIndex = 0)
    {
        Expression<Func<Product, bool>> filter = p =>
            p.Price >= advanceFilterRequest.MinPrice &&
            p.Price <= advanceFilterRequest.MaxPrice &&
            advanceFilterRequest.BrandIdList.Contains(p.BrandId);

        var products = await _unitOfWork.ProductRepository
            .Get(
                filter: filter,
                orderBy: queryable => (IOrderedQueryable<Product>)queryable
                    .OrderBy(p => p.Id)
                    .Skip(pageIndex)
                    .Take(pageSize));

        var productsDto = new List<GetListProductResponse>();


        foreach (var product in products)
        {
            var rating = await _unitOfWork.RatingRepository
                .Get(filter: r => r.ProductId == product.Id) ?? new List<Rating>();

            var totalRating = rating.Count();

            productsDto.Add(
                new GetListProductResponse
                {
                    Id = product.Id,
                    CategoryId = product.CategoryId,
                    //AvailableStock = product.AvailableStock,
                    Price = product.Price,
                    BrandId = product.BrandId,
                    Discount = product.Discount,
                    Name = product.Name,
                    PictureLink = product.ImageUrl,
                    TotalRating = totalRating,
                    AvgStarPoint = totalRating != 0 ? rating.Sum(r => r.StarPoint) / totalRating : default,
                });
        }

        var totalProducts = await _unitOfWork.ProductRepository.Count();

        return new PaginationResponse<GetListProductResponse>
        {
            Total = totalProducts,
            Data = productsDto,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
    }
}