using PizzaRestaurant.Models;
using PizzaRestaurant.Workflow.Steps;
using WorkflowCore.Interface;

namespace PizzaRestaurant.Workflow;

public class RestaurantWorkflow : IWorkflow<DataPizza>
{
    public string Id => "RestaurantPizza";
    public int Version => 1;

    public void Build(IWorkflowBuilder<DataPizza> builder)
    {
        builder
            .StartWith<OrderStep>()
            .Input(step => step.Client, data => data.Client)
            .Input(step => step.InitProduct, data => data.Product)
            .Output(data => data.Product, step => step.InitProduct)
            .WaitFor("CookingReady", (data,context) => context.Workflow.Id, data => DateTime.Now)
            .Output(data => data.Product, step => step.EventData)
            .Then<CookingStep>()
            .Input(step => step.Product, data => data.Product)
            .Output(data => data.Product, step => step.Product)
            .WaitFor("CourierAccept", (data,context) => context.Workflow.Id, data => DateTime.Now)
            .Output(data => data.Courier, step => step.EventData)
            .Output(data => data.Courier, data => data.EventData )
            .Then<DeliveryStep>()
            .Input(step => step.Courier, data => data.Courier)
            .Input(step => step.Product, data => data.Product)
            .Output(data => data.Courier, step => step.Courier)
            .Output(data => data.Product, step => step.Product);
        // .If(data => data.Product.ProductState != ProductState.Canceled && data.Courier.State != CourierState.Canceled).Do();

    }
}