using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Rol : Base
    {
        [Key]
        public int RolID { get; set; }
        public string RolTuru { get; set; }
    }
}
