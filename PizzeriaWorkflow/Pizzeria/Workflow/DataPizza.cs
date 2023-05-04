using Pizzeria.Models.Enums;

namespace Pizzeria.Workflow;

public class DataPizza
{
    public int ClientId { get; set; }
    public int ProductId { get; set; }
    public int CourierId { get; set; }
    
    public ProductState? ProductState { get; set; }
    public CourierState? CourierState { get; set; }
    
    public bool Success { get; set; }
    public string? Message { get; set; }
}