using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Счетчик электрической энергии
    public class ELectricityMeter
    {
        [Key]
        public int ELectricityMeterId { get; set; }

        public string Number { get; set; }

        public string MeterType { get; set; }

        public DateTime CheckDate { get; set; }

        public int ElectricityMeasuringPointId { get; set; }
        public ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }
    }
}
