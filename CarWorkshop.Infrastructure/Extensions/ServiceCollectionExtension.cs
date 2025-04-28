﻿using CarWorkshop.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CarWorkshop.Infrastructure.Seeders;

namespace CarWorkshop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CarWorkshop")));

            services.AddScoped<CarWorkshopSeeder>();    //sami rejestrujemy zaleznosc w wbudowanym kontenerze DI- rozne dlugosci zycia (singleton,scoped,transient)
        }
    }
}
