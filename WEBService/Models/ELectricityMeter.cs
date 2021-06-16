using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Счетчик электрической энергии
    public class ElectricityMeter
    {
        [Key]
        public int ElectricityMeterId { get; set; }

        public string Number { get; set; }

        public string MeterType { get; set; }

        public DateTime CheckDate { get; set; }

        public int ElectricityMeasuringPointId { get; set; }
    }
}
