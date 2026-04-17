using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<List<VehicleEntity>> GetAll();
        Task Add(VehicleEntity vehicle);
    }
}