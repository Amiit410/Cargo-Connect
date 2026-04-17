using CargoConnect.Application.Services.Implementations;
using CargoConnect.Application.Services.Interfaces;
using CargoConnect.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Infrastructure.RegisterServices
{
    public static class RegisterService
    {
        public static void AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<CargoConnectDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IVehicleService, VehicleService>();
        }
    }
}
