using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Vehical
{
    public class VehicalViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Driver is required")]
        public Guid DriverId { get; set; }

        public DriverEntity? Driver { get; set; }

        [Required(ErrorMessage = "Vehicle type is required")]
        public VehicalType Type { get; set; }

        [Required(ErrorMessage = "Number plate is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Number plate must be between 5 and 15 characters")]
        public string NumberPlate { get; set; }

        [Range(0.1, 100, ErrorMessage = "Length must be greater than 0")]
        public double Length { get; set; }

        [Range(0.1, 100, ErrorMessage = "Width must be greater than 0")]
        public double Width { get; set; }

        [Range(0.1, 100, ErrorMessage = "Height must be greater than 0")]
        public double Height { get; set; }

        [Range(1, 100000, ErrorMessage = "Load capacity must be greater than 0")]
        public double LoadCapacity { get; set; }
    }
}