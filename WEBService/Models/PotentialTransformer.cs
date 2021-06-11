using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Трансформатор Напряжения
    public class PotentialTransformer
    {
        [Key]
        public int PotentialTransformerId { get; set; }

        public string Number { get; set; }
        public string TransformerType { get; set; }
        public DateTime CheckDate { get; set; }
        public int TransformationRatio { get; set; }

        public int ElectricityMeasuringPointId { get; set; }
        public ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }
    }
}
