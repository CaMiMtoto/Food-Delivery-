namespace FoodDelivery.Models;

public enum OrderStatus
{
    Pending,
    Accepted,
    Preparing,
    Ready,
    Delivered,
    Completed,
    Cancelled
}