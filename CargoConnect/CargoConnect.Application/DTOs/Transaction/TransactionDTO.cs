using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Transaction
{
    public class TransactionDTO
    {
        public Guid Id { get; set; }
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
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
