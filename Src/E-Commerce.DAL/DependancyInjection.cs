using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Repositories.Abstracts;
using E_Commerce.DAL.Repositories.Implementations;
using E_Commerce.DAL.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.DAL;

public static class DependancyInjection
{
    public static IServiceCollection AddDAL(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ECommerceDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.Configure<JwtSettings>(x => configuration.GetSection(JwtSettings.jwtSettings));
        services.AddScoped<IAppUserRepo,AppUserRepo>();
        services.AddScoped<IProductRepo,ProductRepo>();
        services.AddScoped<ICategoryRepo,CategoryRepo>();

        return services;
    }
}