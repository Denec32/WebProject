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
        public int ID { get; set; }

        public string Name{ get; set; }

        public int PointOfUseId { get; set; }
    }
}
