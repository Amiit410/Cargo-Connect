using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;

namespace CargoConnect.Domain.Entities
{
    public class VehicalEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("Driver")]
        public Guid DriverId { get; set; }
        public DriverEntity Driver { get; set; }

        [Required]
        public VehicalType Type { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string NumberPlate { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Length { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double Width { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public double Height { get; set; }

        [Column(TypeName = "float")]
        [Required]
        public double LoadCapacity { get; set; }

    }
}
