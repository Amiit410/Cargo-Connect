using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Vehical
{
    public class VehicalUpdateModel
    {
        public Guid Id { get; set; }
        [Range(0.1, 100, ErrorMessage = "Length must be greater than 0")]
        public double? Length { get; set; }

        [Range(0.1, 100, ErrorMessage = "Width must be greater than 0")]
        public double? Width { get; set; }

        [Range(0.1, 100, ErrorMessage = "Height must be greater than 0")]
        public double? Height { get; set; }

        [Range(1, 100000, ErrorMessage = "Load capacity must be greater than 0")]
        public double? LoadCapacity { get; set; }
    }
}
