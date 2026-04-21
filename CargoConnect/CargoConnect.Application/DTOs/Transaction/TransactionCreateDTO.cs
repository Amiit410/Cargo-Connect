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
    public class TransactionCreateDTO
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public Guid DriverId { get; set; }
        public decimal Amount { get; set; }

        public TransactionStatus Status { get; set; }

        public TransactionType Type { get; set; }
        public string PaymentGateway { get; set; } 
        public string GatewayTransactionId { get; set; }
    }
}
