using DataAccess.Context;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions;

public static class Registration
{
    public static IServiceCollection AddDataAccessRegistration(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        serviceCollection.AddScoped<ICartRepository, CartRepository>();
        serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
        serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        
        
        return serviceCollection;
    }
}