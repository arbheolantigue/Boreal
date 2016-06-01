using System.Collections.Generic;
using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;

namespace Boreal.Model
{
    public class Order : IIdentifiable<int>, IStatefulResource<OrderStatus>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public long ProductCost { get; set; }
        public long ShippingCost { get; set; }
        public string  Address { get; set; }
        public string PostalCode { get; set; }
        public string CreditCardNo { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
