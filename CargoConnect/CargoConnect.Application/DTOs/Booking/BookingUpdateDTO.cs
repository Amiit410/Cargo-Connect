using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Booking
{
    public class BookingUpdateDTO
    {
        public BookingStatus Status { get; set; } = BookingStatus.Pending;
    }
}
