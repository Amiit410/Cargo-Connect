using CargoConnect.Application.Services.Interfaces;
using CargoConnect.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(VehicleEntity vehicle)
        {
            await _service.Add(vehicle);
            return Ok("Vehicle Added");
        }
    }
}