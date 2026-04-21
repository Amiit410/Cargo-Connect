using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Booking
{
    public class BookingCreateDTO
    {
        public Guid UserId { get; set; }
        public Guid DriverId { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public double Distance { get; set; }
        public decimal Price { get; set; }
    }
}
