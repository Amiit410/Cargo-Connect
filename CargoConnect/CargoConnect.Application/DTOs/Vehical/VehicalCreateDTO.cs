using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Vehical
{
    public class VehicalCreateDTO
    {
        public Guid DriverId { get; set; }
        public VehicalType Type { get; set; }
        public string NumberPlate { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double LoadCapacity { get; set; }
    }
}
