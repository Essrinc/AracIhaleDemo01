using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Arac:Base
    {
        [Key]
        public int AracID { get; set; }
        public KayitTip KayitTip { get; set; }
        public int KayitTipID { get; set; }
        public string SirketAdi { get; set; }
        public AracStatu AracStatu { get; set; }
        public int AracStatuID { get; set; }
        public int AracFiyat { get; set; }
        public string KMBilgisi { get; set; }
        public string Donanim { get; set; }
        public string Resim1 { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Resim4 { get; set; }
        public string Resim5 { get; set; }
        public string Aciklama { get; set; }
        public int MarkaId { get; set; }
        public int YilId { get; set; }
        public int ModelId { get; set; }
        public int GovdeTipi { get; set; }
        public int YakitTipi { get; set; }
        public int VitesTipi { get; set; }
        public int Versiyon { get; set; }
        public int RenkId { get; set; }

    }
}
