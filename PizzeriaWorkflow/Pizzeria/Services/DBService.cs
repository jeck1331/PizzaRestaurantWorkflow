using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;
using Pizzeria.Models.Enums;

namespace Pizzeria.Services;

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

    public async Task ChangeProductState(int productId, ProductState state, int clientId, int? courierId = null)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
        if (product is not null)
        {
            product.ProductState = state;
            if (product.Client is null)
                product.Client = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == clientId) ?? null;

            if (courierId is not null)
                product.Courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == courierId) ?? null;

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

    public async Task<List<Product>> Products() => await _dbContext.Products.AsNoTracking().ToListAsync();
    public async Task<List<Client>> Clients() => await _dbContext.Clients.AsNoTracking().ToListAsync();
    public async Task<List<Courier>> Couriers() => await _dbContext.Couriers.AsNoTracking().ToListAsync();
}