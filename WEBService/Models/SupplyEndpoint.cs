using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Точка поставки электроэнергии
    public class SupplyEndpoint
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public float MaxPower { get; set; }

        public int PointOfUseId { get; set; }
    }
}
