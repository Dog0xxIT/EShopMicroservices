namespace EShop.Domain.Aggregates.OrderAggregate
{
    public class OrderItem
    {
        public int Id { get; private set; }

        public int ProductId { get; private set; }

        public string ProductName { get; private set; }

        public string PictureUrl { get; private set; }

        public double UnitPrice { get; private set; }

        public double Discount { get; private set; }

        public int Units { get; private set; }

        public double TotalPrice { get; private set; }

        public OrderItem(
            int id, int productId, string productName, string pictureUrl,
            double unitPrice, double discount, int units)
        {
            ProductName = productName ?? throw new ArgumentNullException(nameof(productName));
            PictureUrl = pictureUrl ?? throw new ArgumentNullException(nameof(pictureUrl));
            UnitPrice = unitPrice;
            Discount = discount;
            Units = units;
            ProductId = productId;
            Id = id;
            TotalPrice = UnitPrice * Units;
        }

        public void SetNewDiscount(double discount)
        {
            if (discount < 0 || discount > this.TotalPrice)
            {
                throw DomainException.InvalidDiscount;
            }

            Discount = discount;
        }

        public void AddUnits(int units)
        {
            if (units < 0)
            {
                throw DomainException.InvalidUnits;
            }

            Units += units;
        }
    }
}
