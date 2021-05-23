﻿using Domain.Abstractions.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class InfrastructureExtension
    {
        public static void InstallInfrastructure(this IServiceCollection services, string connectionString)
        {
            services
                .AddDbContextPool<AppDbContext>(options =>
                {
                    options.UseNpgsql(connectionString);
                    options.EnableSensitiveDataLogging();
                })
                .AddScoped<IAppContext, AppDbContext>();
        }
    }
}
