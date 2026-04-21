using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Vehical
{
    public class VehicalUpdateDTO
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double LoadCapacity { get; set; }
    }
}
