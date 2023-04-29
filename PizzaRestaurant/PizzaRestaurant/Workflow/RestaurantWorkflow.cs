﻿using PizzaRestaurant.Workflow.Steps;
using WorkflowCore.Interface;

namespace PizzaRestaurant.Workflow;

public class RestaurantWorkflow : IWorkflow<DataPizza>
{
    public void Build(IWorkflowBuilder<DataPizza> builder)
    {
        builder
            .If(x => x.ClientId != null).Do(x => x
                .StartWith<OrderStep>()
                .Input(step => step.ClientId, data => data.ClientId)
                .Input(step => step.OrderProductId, data => data.ProductId)
                .Output(data => data.ProductState, step => step.ProductState)
                .WaitFor("AcceptKitchen", (data, context) => context.Workflow.Id, data => DateTime.Now)
                .Then<CookingStep>()
                .Input(step => step.ClientId, data => data.ClientId)
                .Input(step => step.ProductId, data => data.ProductId)
                .Output(data => data.ProductState, step => step.ProductState)
                .WaitFor("AcceptCourier", (data, context) => context.Workflow.Id, data => DateTime.Now)
                .Output(data => data.CourierId, step => step.EventData)
                .Then<DeliveryStep>()
                .Input(step => step.ClientId, data => data.ClientId)
                .Input(step => step.CourierId, data => data.CourierId)
                .Input(step => step.ProductId, data => data.ProductId)
                .Output(data => data.CourierState, step => step.CourierState)
                .Output(data => data.ProductState, step => step.ProductState)
                .Output(data => data.Success, step => step.Success)
                .Output(data => data.Error, step => step.Error)
                )
            .EndWorkflow();
    }

    public string Id => "RestaurantWorkflow";
    public int Version => 1;
}