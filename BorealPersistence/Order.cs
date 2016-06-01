using System.Collections.Generic;

namespace BorealPersistence
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public long ProductCost { get; set; }
        public long ShippingCost { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string CreditCardNo { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public string OrderStatus { get; set; }

    }
}
