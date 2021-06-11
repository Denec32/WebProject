using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Расчетный прибор учета
    public class MeteringDevice
    {
        public int MeteringDeviceId { get; set; }

        public ElectricityMeasuringPoint ElectricityMeasuringPoints { get; set; }

    }
}
