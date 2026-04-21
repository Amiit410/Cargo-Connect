using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Transaction
{
    public class TransactionViewDTO
    {
        public Guid BookingId { get; set; }
        public BookingEntity Booking { get; set; }
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
        public Guid DriverId { get; set; }
        public DriverEntity Driver { get; set; }
        public decimal Amount { get; set; }

        public TransactionStatus Status { get; set; }

        public TransactionType Type { get; set; }

        public string PaymentGateway { get; private set; }
        public string GatewayTransactionId { get; private set; }
    }
}
