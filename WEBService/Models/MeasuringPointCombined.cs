using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    public class MeasuringPointCombined
    {
        public ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }

        public CurrentTransformer CurrentTransformer { get; set; }

        public PotentialTransformer PotentialTransformer{ get; set; }
    
        public ElectricityMeter ElectricityMeter { get; set; }
    }
}
