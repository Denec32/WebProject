using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    // Объект потребления
    public class PointOfUse
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int SubsidiaryId { get; set; }
    }
}
