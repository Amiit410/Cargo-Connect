using CargoConnect.Domain.Entities;
using CargoConnect.Repository.Data;
using Microsoft.EntityFrameworkCore;
using CargoConnect.Application.Services.Interfaces;

namespace CargoConnect.Application.Services.Implementations
{
    public class VehicleService : IVehicleService
    {
        private readonly CargoConnectDbContext _context;

        public VehicleService(CargoConnectDbContext context)
        {
            _context = context;
        }

        public async Task<List<VehicleEntity>> GetAll()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task Add(VehicleEntity vehicle)
        {
            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
        }
    }
}