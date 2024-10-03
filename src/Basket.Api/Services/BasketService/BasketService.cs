using Basket.Api.Services.CatalogService;

namespace Basket.Api.Services.BasketService;

public class BasketService : IBasketService
{
    private readonly BasketContext _context;
    private readonly ILogger<BasketService> _logger;
    private readonly ICatalogService _catalogService;

    public BasketService(ILogger<BasketService> logger, BasketContext context, ICatalogService catalogService)
    {
        _logger = logger;
        _context = context;
        _catalogService = catalogService;
    }

    public async Task<ServiceResult> CreateBasket(string userId)
    {
        var isExist = await _context.Baskets.AsNoTracking().AnyAsync(b => b.UserId == userId);
        if (isExist)
        {
            return ServiceResult.Failed("Basket Existed");
        }

        var basket = new Data.Entities.Basket
        {
            UserId = userId,
        };
        try
        {
            await _context.Baskets.AddAsync(basket);
            await _context.SaveChangesAsync();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return ServiceResult.Failed("Server Error");
        }
    }

    public async Task<List<GetBasketByCustomerIdResponse>> GetBasketByCustomerId(string userId)
    {
        var basket = await _context.Baskets
            .Include(b => b.Items)
            .SingleOrDefaultAsync(b => b.UserId == userId);

        if (basket is null)
        {
            return new();
        }

        var basketItems = await _context.BasketItems
            .Where(b => b.BasketId == basket.Id)
            .AsNoTracking()
            .ToListAsync();

        var baskItemsDto = basketItems.Select(basketItem =>
            new GetBasketByCustomerIdResponse
            {
                ProductId = basketItem.ProductId,
                CustomerId = basket.UserId,
                Id = basketItem.Id,
                ProductName = basketItem.ProductName,
                PictureUrl = basketItem.PictureUrl,
                Quantity = basketItem.Quantity,
                UnitPrice = basketItem.UnitPrice
            }).ToList();

        return baskItemsDto;
    }

    public async Task<ServiceResult> AddToBasket(string userId, AddToBasketRequest req)
    {
        var product = await _catalogService.GetProductById("CatalogClient", req.ProductId);
        if (product is null)
        {
            return ServiceResult.Failed("Not Exists product");
        }

        var basket = await _context.Baskets
            .Include(b => b.Items)
            .SingleOrDefaultAsync(b => b.UserId == userId);

        if (basket is null)
        {
            return ServiceResult.Failed("Not Exists basket");
        }

        try
        {
            var basketItem = basket.Items.SingleOrDefault(i => i.ProductId == req.ProductId);
            if (basketItem is null)
            {
                var newBasketItem = new BasketItem
                {
                    ProductId = req.ProductId,
                    Quantity = req.Quantity,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    PictureUrl = product.ThumbnailUrl,
                };
                basket.Items.Add(newBasketItem);
                basket.SetTimeLastModified();
                _context.Baskets.Update(basket);
            }
            else
            {
                basketItem.Quantity = req.Quantity;
                basketItem.SetTimeLastModified();
                _context.BasketItems.Update(basketItem);
            }
            await _context.SaveChangesAsync();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return ServiceResult.Failed("Server Error");
        }
    }

    public async Task<ServiceResult> UpdateQty(UpdateQtyRequest req)
    {
        //Note
        var basketItem = await _context.BasketItems.FindAsync(req.BasketItemId);

        if (basketItem is null)
        {
            return ServiceResult.Failed("Not exists basket item");
        }

        try
        {
            if (req.Qty == 0)
            {
                _context.BasketItems.Remove(basketItem);
            }
            else
            {
                basketItem.Quantity = req.Qty;
                basketItem.SetTimeLastModified();
            }
            await _context.SaveChangesAsync();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return ServiceResult.Failed("Server Error");
        }
    }

    public async Task<ServiceResult> DeleteBasketItem(int id)
    {
        var basketItem = await _context.BasketItems.FindAsync(id);

        if (basketItem is null)
        {
            return ServiceResult.Failed("Not exists basket item");
        }

        try
        {
            _context.BasketItems.Remove(basketItem);
            await _context.SaveChangesAsync();
            return ServiceResult.Success;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return ServiceResult.Failed("Server Error");
        }
    }
}