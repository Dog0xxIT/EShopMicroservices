using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Extensions;
using EShop.Application.Services.Interfaces;
using EShop.Domain.Enums;
using Mapster;
using Microsoft.Extensions.Logging;
using OrderDomain = EShop.Domain.Aggregates.OrderAggregate.Order;
using OrderItemDomain = EShop.Domain.Aggregates.OrderAggregate.OrderItem;
using EShop.Shared.ResponseModels.Order;
using Address = EShop.Domain.Aggregates.OrderAggregate.Address;
using Order = EShop.Application.Entities.Order;

namespace EShop.Application.Services.ApplicationService
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IUnitOfWork unitOfWork, ILogger<OrderService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IEnumerable<OrderDto>> GetAllByBuyerId(int buyerId, int pageSize = 10, int pageIndex = 0)
        {
            var orders = await _unitOfWork.OrderRepository
                .Get(
                    orderBy: queryable => (IOrderedQueryable<Order>)queryable
                        .OrderBy(o => o.Id)
                        .Skip(pageIndex)
                        .Take(pageSize),
                    filter: o => o.BuyerId == buyerId);

            var orderEntityDomainList = orders
                .Select(o => o.MapToOrderEntityDomain())
                .Adapt<IEnumerable<OrderDto>>();
            return orderEntityDomainList;
        }

        public async Task<OrderDto?> GetById(int orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetById(orderId);

            return order?.MapToOrderEntityDomain().Adapt<OrderDto>();
        }

        public async Task<ServiceResult> CreateOrder(CreateOrderDto createOrderDto)
        {
            try
            {
                var orderItemsDomain = new List<OrderItemDomain>();

                foreach (var orderItemDto in createOrderDto.OrderItems)
                {
                    var product = await _unitOfWork.ProductRepository.GetById(orderItemDto.ProductId);
                    orderItemsDomain.Add(new OrderItemDomain(
                        0, orderItemDto.ProductId, product.Name,
                        product.ImageUrl, product.Price, 0,
                        orderItemDto.Units));
                }

                var orderDomain = new OrderDomain(
                    orderId: 0,
                    orderDate: DateTime.UtcNow,
                    buyerId: createOrderDto.BuyerId,
                    paymentId: createOrderDto.PaymentId,
                    address: new Address(createOrderDto.Street, createOrderDto.City, createOrderDto.State,
                        createOrderDto.Country, createOrderDto.ZipCode),
                    orderStatus: OrderStatus.Draft,
                    orderItems: orderItemsDomain);

                var orderEntityApplication = orderDomain.MapToOrderEntityApplication();

                await _unitOfWork.OrderRepository.Create(orderEntityApplication);
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }

        public async Task<ServiceResult> CreateOrderDraft(CreateOrderDto createOrderDto)
        {
            try
            {
                var orderItemsDomain = new List<OrderItemDomain>();

                foreach (var orderItemDto in createOrderDto.OrderItems)
                {
                    var product = await _unitOfWork.ProductRepository.GetById(orderItemDto.ProductId);
                    orderItemsDomain.Add(new OrderItemDomain(
                        0, orderItemDto.ProductId, product.Name,
                        product.ImageUrl, product.Price, 0,
                        orderItemDto.Units));
                }

                var orderDomain = new OrderDomain(
                    orderId: 0,
                    orderDate: DateTime.UtcNow,
                    buyerId: createOrderDto.BuyerId,
                    paymentId: createOrderDto.PaymentId,
                    address: new Address(createOrderDto.Street, createOrderDto.City, createOrderDto.State,
                        createOrderDto.Country, createOrderDto.ZipCode),
                    orderStatus: OrderStatus.Draft,
                    orderItems: orderItemsDomain);

                var orderEntityApplication = orderDomain.MapToOrderEntityApplication();

                await _unitOfWork.OrderRepository.Create(orderEntityApplication);
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }

        public async Task<ServiceResult> CancelOrder(int orderId)
        {
            var orderEntityApplication = await _unitOfWork.OrderRepository.GetById(orderId);
            if (orderEntityApplication is null)
            {
                return ServiceResult.Failed("Not exists order");
            }

            try
            {
                var orderEntityDomain = orderEntityApplication.MapToOrderEntityDomain();
                orderEntityDomain.SetCancelledStatus();
                _unitOfWork.OrderRepository.Update(orderEntityDomain.MapToOrderEntityApplication());
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }

        public async Task<ServiceResult> ShipOrder(int orderId)
        {
            var orderEntityApplication = await _unitOfWork.OrderRepository.GetById(orderId);
            if (orderEntityApplication is null)
            {
                return ServiceResult.Failed("Not exists order");
            }

            try
            {
                var orderEntityDomain = orderEntityApplication.MapToOrderEntityDomain();
                orderEntityDomain.SetShippedStatus();
                _unitOfWork.OrderRepository.Update(orderEntityDomain.MapToOrderEntityApplication());
                await _unitOfWork.Commit();
                return ServiceResult.Success;
            }
            catch (Exception ex)
            {
                return ServiceResult.Failed(ex.Message);
            }
        }
    }
}
