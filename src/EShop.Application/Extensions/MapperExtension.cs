using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Entities;
using EShop.Domain.Aggregates.BuyerAggregate;
using EShop.Domain.Enums;
using OrderEntityApplication = EShop.Application.Entities.Order;
using OrderItemEntityApplication = EShop.Application.Entities.OrderItem;
using OrderEntityDomain = EShop.Domain.Aggregates.OrderAggregate.Order;
using OrderItemEntityDomain = EShop.Domain.Aggregates.OrderAggregate.OrderItem;
using Address = EShop.Domain.Aggregates.OrderAggregate.Address;

namespace EShop.Application.Extensions
{
    public static class MapperExtension
    {
        #region Map To Entity Domain

        public static Buyer MapToEntityDomain(this User rootEntity)
        {
            var paymentMethodEntityDomain = rootEntity.Payments
                ?.Select(MapToEntityDomain).ToList();

            return new Buyer(
                rootEntity.Id,
                rootEntity.UserName,
                paymentMethodEntityDomain);
        }

        public static PaymentMethod MapToEntityDomain(this Payment rootEntity)
        {
            return new PaymentMethod(
                rootEntity.Id, rootEntity.Alias, rootEntity.CardNumber,
                rootEntity.SecurityNumber, rootEntity.CardHolderName, rootEntity.Expiration,
                (int)rootEntity.CardType);
        }

        public static OrderEntityDomain MapToEntityDomain(this OrderEntityApplication rootEntity)
        {
            var addressEntityApplication = rootEntity.Address;

            var address = new Address(
                addressEntityApplication.AddressLine1 ?? addressEntityApplication.AddressLine2,
                addressEntityApplication.City,
                addressEntityApplication.State,
                addressEntityApplication.Country,
                addressEntityApplication.ZipCode);

            var orderItems = rootEntity.OrderItems
                ?.Select(MapToEntityDomain).ToList();

            var orderEntityDomain = new OrderEntityDomain(
                rootEntity.Id, DateTime.UtcNow, rootEntity.BuyerId,
                rootEntity.PaymentId, address, (OrderStatus)rootEntity.OrderStatus, orderItems);

            return orderEntityDomain;
        }

        public static OrderItemEntityDomain MapToEntityDomain(this OrderItemEntityApplication rootEntity)
        {
            return new OrderItemEntityDomain(
                rootEntity.Id, rootEntity.ProductId, rootEntity.ProductName,
                rootEntity.PictureUrl, rootEntity.UnitPrice, rootEntity.Discount,
                rootEntity.Units);
        }

        #endregion

        #region Map To Entity Application
        public static void ConvertToEntityApplication(this OrderEntityDomain rootEntity, ref OrderEntityApplication orderEntityApplication)
        {
            orderEntityApplication.Id = rootEntity.OrderId;
            orderEntityApplication.BuyerId = rootEntity.BuyerId;
            orderEntityApplication.PaymentId = rootEntity.PaymentId;
            orderEntityApplication.Id = rootEntity.OrderId;
            orderEntityApplication.OrderStatus = (Enums.OrderStatus)rootEntity.OrderStatus;
            orderEntityApplication.AddressId = 0;
            orderEntityApplication.Amount = rootEntity.GetTotal();
            orderEntityApplication.Address = new Entities.Address();
            orderEntityApplication.OrderItems = null;
        }

        public static void ConvertToEntityApplication(this Buyer rootEntity, ref User userEntity)
        {
            userEntity.Id = rootEntity.BuyerId;
            userEntity.UserName = rootEntity.BuyerName;
            userEntity.Payments = rootEntity.PaymentMethods.Select(MapToEntityApplication).ToList();
        }

        public static Payment MapToEntityApplication(this PaymentMethod rootEntity)
        {
            return new Payment
            {
                Id = rootEntity.CardTypeId,
                Alias = rootEntity.Alias,
                CardHolderName = rootEntity.CardHolderName,
                CardNumber = rootEntity.CardNumber,
                CardType = (Enums.CardType)rootEntity.CardTypeId,
                Expiration = rootEntity.Expiration,
                SecurityNumber = rootEntity.SecurityNumber
            };
        }
        #endregion
    }
}
