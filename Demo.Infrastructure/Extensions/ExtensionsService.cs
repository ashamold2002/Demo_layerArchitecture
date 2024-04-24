﻿

using Demo.Domain.Entity;
using Demo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Infrastructure.Extensions
{
    public static class ExtensionsService
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration) 
        {
            var connectionstring = configuration.GetConnectionString("DemoDb");
            services.AddDbContext<AppDbContext>(options=>options.UseMySql(connectionstring, new MySqlServerVersion(new Version())));
        }
    }
}
