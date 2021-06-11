using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    //Дочерняя организация
    public class Subsidiary
    {
        [Key]
        public int SubsidiaryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public Organization Organization { get; set; }
        
        [Required]
        public int OrganizationId { get; set; }

        public List<PointOfUse> PointsOfUse { get; set; }

    }
}
