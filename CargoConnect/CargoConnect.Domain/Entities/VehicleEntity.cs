using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Domain.Entities
{
    public class VehicleEntity
    {
        public int Id { get; set; }

        public string? VehicleNumber { get; set; }

        public string? VehicleType { get; set; }

        public int Capacity { get; set; }

        public int DriverId { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
