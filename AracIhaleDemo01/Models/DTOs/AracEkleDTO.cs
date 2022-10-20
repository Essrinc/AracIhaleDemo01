using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.DTOs
{
    public class AracEkleDTO
    {
        public string KullaniciAdi { get; set; } //kullanici

        public string AracStatuAdi { get; set; } //aracstatu

        public int AracFiyat { get; set; } //arac

        public string IhaleBaslangicFiyat { get; set; } //ihalefiyat

        public string AracMarka { get; set; } //aracdetay
        public string AracModel { get; set; }
        public string GovdeTipi { get; set; }
        public DateTime Yil { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public string Versiyon { get; set; }
        public string Renk { get; set; }

        public string Resim1 { get; set; } //arac
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Resim4 { get; set; }
        public string Resim5 { get; set; }
        public string Aciklama { get; set; }





    }
}
