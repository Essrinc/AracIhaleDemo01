using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Ihale
    {
        public int IhaleID { get; set; }
        public string IhaleAdi { get; set; }

        public KayitTip KayitTip { get; set; }
        public int KayitTipID { get; set; }
        public string SirketAdi { get; set; }

        public IhaleStatu IhaleStatu { get; set; }
        public int IhaleStatuID { get; set; }
    }
}
