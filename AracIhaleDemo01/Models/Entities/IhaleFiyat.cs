using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class IhaleFiyat
    {
        public int IhaleFiyatID { get; set; }

        public Arac Arac { get; set; }
        public int AracID { get; set; }
        public string IhaleBaslangicFiyat { get; set; }
        public string MinimumAlımFiyat { get; set; }
    }
}
