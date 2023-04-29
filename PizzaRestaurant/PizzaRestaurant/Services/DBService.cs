﻿using Microsoft.EntityFrameworkCore;
using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;

namespace PizzaRestaurant.Services;

public class DBService
{
    private readonly AppDbContext _dbContext;
    public DBService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateClientAsync(Client client)
    {
        _dbContext.Clients.Add(client);
        await _dbContext.SaveChangesAsync();
    }
    public async Task CreateCourierAsync(Courier courier)
    {
        _dbContext.Couriers.Add(courier);
        await _dbContext.SaveChangesAsync();
    }
    public async Task CreateProductAsync(Product product)
    {
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
    }

    public async Task ChangeProductState(int productId, ProductState state)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
        if (product is not null)
        {
            product.ProductState = state;
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }
    }
    public async Task ChangeCourierState(int courierId, CourierState state)
    {
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == courierId);
        if (courier is not null)
        {
            courier.State = state;
            _dbContext.Couriers.Update(courier);
            await _dbContext.SaveChangesAsync();
        }
    }
    
    public async Task SetClientProduct(int clientId, Product product)
    {
        var client = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == clientId);
        if (client is not null)
        {
            if (client.Products.All(x => x.Id != product.Id))
            {
                client.Products.Add(product);
            }
            await _dbContext.SaveChangesAsync();
        }
    }
    
    public async Task DeleteProductAsync(int id)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (product is not null)
        {
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
    }
    
    public async Task DeleteClientAsync(int id)
    {
        var client = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == id);
        if (client is not null)
        {
            _dbContext.Clients.Remove(client);
            await _dbContext.SaveChangesAsync();
        }
    }
    
    public async Task DeleteCourierAsync(int id)
    {
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == id);
        if (courier is not null)
        {
            _dbContext.Couriers.Remove(courier);
            await _dbContext.SaveChangesAsync();
        }
    }
    
}