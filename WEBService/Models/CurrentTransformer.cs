using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Трансформатор тока
    public class CurrentTransformer
    {
        [Key]
        public int CurrentTransformerId { get; set; }

        public string Number { get; set; }
        public double TransformationRatio { get; set; }
        public DateTime CheckDate { get; set; }
        public string TransformerType { get; set; }

        public int ElectricityMeasuringPointId { get; set; }
    }
}
