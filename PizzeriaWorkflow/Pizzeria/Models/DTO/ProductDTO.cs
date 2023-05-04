namespace Pizzeria.Models.DTO;

public class ProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public int CleintId { get; set; }
    public string ClientName { get; set; }
    public int? CourierId { get; set; }
    public string? CourierName { get; set; }
}