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
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int OrganizationId { get; set; }
    }
}
