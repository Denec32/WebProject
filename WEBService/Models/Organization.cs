using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    //Организация
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public List<Subsidiary> Subsidiaries { get; set; }
    }
}
