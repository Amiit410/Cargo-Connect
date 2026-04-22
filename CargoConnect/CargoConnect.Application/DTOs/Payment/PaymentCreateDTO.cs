using CargoConnect.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Payment
{
    public class PaymentCreateDTO
    {
        [Required(ErrorMessage = "BookingId is required")]
        public Guid BookingId { get; set; } 

        [Required(ErrorMessage = "Amount is required")]
        [Range(1, 1000000, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(PaymentStatus), ErrorMessage = "Invalid payment status")]
        public PaymentStatus Status { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        [EnumDataType(typeof(PaymentMethod), ErrorMessage = "Invalid payment method")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "TransactionId is required")]
        public Guid TransactionId { get; set; }
    }
}
