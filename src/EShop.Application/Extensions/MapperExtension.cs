using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Dto.Order;
using EShop.Application.Entities;
using EShop.Domain.Aggregates.BuyerAggregate;
using EShop.Domain.Enums;
using EShop.Domain.ValueObjects;
using OrderEntityApplication = EShop.Application.Entities.Order;
using OrderItemEntityApplication = EShop.Application.Entities.OrderItem;
using OrderEntityDomain = EShop.Domain.Aggregates.OrderAggregate.Order;
using OrderItemEntityDomain = EShop.Domain.Aggregates.OrderAggregate.OrderItem;
using EShop.Application.Services.Interfaces;

namespace EShop.Application.Extensions
{
    public static class MapperExtension
    {
        public static Buyer MapToOrderBuyerEntityDomain(this User rootEntity)
        {
            var paymentMethodEntityDomain = rootEntity.Payments?.Select(MapToPaymentMethodEntityDomain).ToList();

            return new Buyer(
                rootEntity.Id,
                rootEntity.UserName,
                paymentMethodEntityDomain);
        }

        public static PaymentMethod MapToPaymentMethodEntityDomain(this Payment rootEntity)
        {
            return new PaymentMethod(
                rootEntity.Id, rootEntity.Alias, rootEntity.CardNumber,
                rootEntity.SecurityNumber, rootEntity.CardHolderName, rootEntity.Expiration,
                (int)rootEntity.CardType);
        }

        public static OrderEntityDomain MapToOrderEntityDomain(this OrderEntityApplication rootEntity)
        {
            var address = new Address(
                rootEntity.Street, rootEntity.City, rootEntity.State,
                rootEntity.Country, rootEntity.ZipCode);

            var orderItems = rootEntity.OrderItems?.Select(MapToOrderItemEntityDomain).ToList();

            var orderEntityDomain = new OrderEntityDomain(
                rootEntity.Id, DateTime.UtcNow, rootEntity.BuyerId,
                rootEntity.PaymentId ?? 0, address, (OrderStatus)rootEntity.OrderStatus, orderItems);

            return orderEntityDomain;
        }

        public static OrderEntityApplication MapToOrderEntityApplication(this OrderEntityDomain rootEntity)
        {
            return new OrderEntityApplication
            {
                Id = rootEntity.OrderId,
                BuyerId = rootEntity.BuyerId,
                PaymentId = rootEntity.PaymentId,
                OrderStatus = (Enums.OrderStatus)rootEntity.OrderStatus,
                Description = rootEntity.Description,
                City = rootEntity.Address.City,
                Country = rootEntity.Address.Country,
                State = rootEntity.Address.State,
                Street = rootEntity.Address.Street,
                ZipCode = rootEntity.Address.ZipCode,
                OrderItems = rootEntity.OrderItems.Select(MapToOrderItemEntityApplication).ToList(),
            };
        }

        public static OrderItemEntityDomain MapToOrderItemEntityDomain(this OrderItemEntityApplication rootEntity)
        {
            return new OrderItemEntityDomain(
                rootEntity.Id, rootEntity.ProductId, rootEntity.ProductName,
                rootEntity.PictureUrl, rootEntity.UnitPrice, rootEntity.Discount,
                rootEntity.Units);
        }

        public static OrderItemEntityApplication MapToOrderItemEntityApplication(this OrderItemEntityDomain rootEntity)
        {
            return new OrderItemEntityApplication
            {
                Id = rootEntity.Id,
                ProductId = rootEntity.ProductId,
                ProductName = rootEntity.ProductName,
                PictureUrl = rootEntity.PictureUrl,
                UnitPrice = rootEntity.UnitPrice,
                Discount = rootEntity.Discount,
                Units = rootEntity.Units
            };
        }
    }
}
