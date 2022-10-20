using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Ilan:Base
    {
        public int IlanID { get; set; }
        public string IlanBaslik { get; set; }
        public string IlanAciklama { get; set; }
    }
}
