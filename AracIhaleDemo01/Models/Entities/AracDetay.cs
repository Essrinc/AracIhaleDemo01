using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class AracDetay:Base
    {
        public int AracDetayID { get; set; }
        public string GrupAdi { get; set; }
        public string Value { get; set; }
    }
}
