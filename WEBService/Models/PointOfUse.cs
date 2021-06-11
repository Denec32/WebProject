using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Объект потребления
    public class PointOfUse
    {
        [Key]
        public int PointOfUseId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public int SubsidiaryId { get; set; }
        [Required]
        public Subsidiary Subsidiary { get; set; }

        public List<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }
        public List<SupplyEndpoint> SupplyEndpoints { get; set; }

    }
}
