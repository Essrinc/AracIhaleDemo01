using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.DTOs
{
    public class AracDTO
    {
        public List<AracStatuDTO> AracStatuList { get; set; }
        public List<AracMarkaDTO> AracMarkaList { get; set; }
        public List<AracModelDTO> AracModelList { get; set; }

        public int AracStatuID { get; set; }
        public int AracModelID { get; set; }
        public int AracMarkaID { get; set; }
        public int AracID { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public string Statu { get; set; }
        public int KaydedenKullaniciID { get; set; }
        public string KaydedenKullanici { get; set; }
        public DateTime KaydetmeZamani { get; set; }

    }
}
