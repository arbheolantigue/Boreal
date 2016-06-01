namespace Boreal.Model
{
    public enum OrderStatus
    {
        New,
        Processing,
        AwaitingCustomerResponse,
        PartiallyDelivered,
        Delivered,
        Cancelled
    }
}