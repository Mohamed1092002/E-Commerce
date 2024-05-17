using E_Commerce.BL.Authentication;
using E_Commerce.BL.Managers.Abstractions;
using E_Commerce.BL.Managers.Implementations;
using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.BL;

public static class DependancyInjection
{
    public static IServiceCollection AddBL(this IServiceCollection services)
    {
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddScoped<IAppUserManager, AppUserManager>();
        services.AddScoped<IProductManager, ProductManager>();
        services.AddScoped<ICategoryManager, CategoryManager>();
        return services;
    }

    public static IServiceCollection AddIdentitySettings(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole<int>>(op =>
        {
            op.Password.RequiredUniqueChars = 3;
            op.Password.RequireDigit = true;
            op.Password.RequireLowercase = true;
            op.Password.RequireUppercase = true;
        })
            .AddRoles<IdentityRole<int>>()
            .AddEntityFrameworkStores<ECommerceDbContext>()
            .AddDefaultTokenProviders();

        return services;
    }
}