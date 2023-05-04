using Pizzeria.Models;
using Pizzeria.Models.Enums;
using Pizzeria.Workflow.Steps;
using WorkflowCore.Interface;

namespace Pizzeria.Workflow;

public class RestaurantWorkflow : IWorkflow<DataPizza>
{
    public void Build(IWorkflowBuilder<DataPizza> builder)
    {
        builder
            .StartWith<OrderStep>()
                .Input(step => step.ClientId, data => data.ClientId)
                .Input(step => step.OrderProductId, data => data.ProductId)
                .Output(data => data.ProductState, step => step.ProductState)
                    .WaitFor("EventKitchen", (data, context) => context.Workflow.Id, data => DateTime.Now)
                        .Output(data => data.ProductState, step => step.EventData)
            .If(x => x.ProductState != ProductState.Canceled)
                .Do(body => body
                    .Then<CookingStep>()
                        .Input(step => step.ClientId, data => data.ClientId)
                        .Input(step => step.ProductId, data => data.ProductId)
                        .Output(data => data.ProductState, step => step.ProductState)
                            .If(x => x.ProductState != ProductState.Terminated)
                                .Do(x => x
                                    .WaitFor("EventCourier", (data, context) => context.Workflow.Id, data => DateTime.Now)
                                    .Output(data => data.CourierId, step => (step.EventData as EventCourier).CourierId)
                                    .Output(data => data.CourierState, step => (step.EventData as EventCourier)!.State)
                                        .If(z => z.CourierState != CourierState.Canceled)
                                            .Do(z => z
                                                .Then<DeliveryStep>()
                                                .Input(step => step.ClientId, data => data.ClientId)
                                                .Input(step => step.CourierId, data => data.CourierId)
                                                .Input(step => step.ProductId, data => data.ProductId)
                                                .Output(data => data.CourierState, step => step.CourierState)
                                                .Output(data => data.ProductState, step => step.ProductState)
                                                .Output(data => data.Success, step => step.Success)
                                                .Output(data => data.Message, step => step.Message)
                                            )
                                )
                )
            .Then<EndStep>()
            .EndWorkflow();
    }

    public string Id => "RestaurantWorkflow";
    public int Version => 1;
}