using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBService.Models;

namespace WEBApplication.Models
{
    public class UsageAndMeasuringPointViewModel
    {
        public  PointOfUse PointOfUse { get; set; }

        public List<ElectricityMeasuringPoint> ElectricityMeasuringPoint { get; set; }
    }
}
