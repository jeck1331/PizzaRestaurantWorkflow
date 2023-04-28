using PizzaRestaurant.Models;

namespace PizzaRestaurant.Workflow;

public class DataPizza
{
    public Client Client { get; set; } = null!;
    public Courier? Courier { get; set; }
    public Product? Product { get; set; }
}