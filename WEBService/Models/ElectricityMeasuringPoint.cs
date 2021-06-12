using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WEBService.Models
{
    // Точка измерения электроэнергии
    public class ElectricityMeasuringPoint
    {
        [Key]
        public int ElectricityMeasuringPointId { get; set; }

        public string Name{ get; set; }

        public ElectricityMeter ElectricityMeter { get; set; }
        public CurrentTransformer CurrentTransformer { get; set; }
        public PotentialTransformer PotentialTransformer { get; set; }

        public int PointOfUseId { get; set; }
        public PointOfUse PointOfUse { get; set; }

        //public MeteringDevice MeteringDevices { get; set; }
        public List<MeteringDevice> MeteringDevices { get; set; }



    }
}
