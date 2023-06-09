﻿using PizzeriaWorkflow.Models.Enums;

namespace PizzeriaWorkflow.Models;

public class Courier
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public CourierState? State { get; set; }
    
    public int? ProductId { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}