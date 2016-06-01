namespace Boreal.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
        public OrderItemStatus OrderItemStatus { get; set; }
    }
}