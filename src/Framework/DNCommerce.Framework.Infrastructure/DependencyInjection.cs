﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DNCommerce.Infrastructure.Data;
using DNCommerce.Framework.Application.Services;
using DNCommerce.Framework.Infrastructure.Services;
using DNCommerce.Application.Repositories;
using DNCommerce.Infrastructure.Repositories;

namespace DNCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(
                     configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
