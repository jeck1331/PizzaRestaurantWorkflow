using PizzeriaWorkflow.Models.Enums;

namespace PizzeriaWorkflow.Models;

public class EventCourier
{
    public int? CourierId { get; set; }
    public CourierState State { get; set; }
}