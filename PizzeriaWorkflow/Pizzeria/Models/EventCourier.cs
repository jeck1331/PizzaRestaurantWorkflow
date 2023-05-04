using Pizzeria.Models.Enums;

namespace Pizzeria.Models;

public class EventCourier
{
    public int? CourierId { get; set; }
    public CourierState State { get; set; }
}