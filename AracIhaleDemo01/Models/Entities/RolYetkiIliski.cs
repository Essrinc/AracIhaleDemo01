using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class RolYetkiIliski:Base
    {
        public int RolYetkiIliskiID { get; set; }
        public Rol Rol { get; set; }
        public int RolID { get; set; }

        public Yetki Yetki { get; set; }
        public int YetkiID { get; set; }
    }
}
