using PizzeriaWorkflow.Models.Enums;

namespace PizzeriaWorkflow.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ProductState? ProductState { get; set; }
    
    public int? ClientId { get; set; }
    public Client? Client { get; set; } = null!;
    public int? CourierId { get; set; }
    public Courier? Courier { get; set; } = null!;
}