using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Kullanici : Base
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public Rol Rol { get; set; }
        public int RolID { get; set; }
        public string Il { get; set; } 
        public string Ilce { get; set; } 
        public string Adres { get; set; } 
        public string FirmaAdi { get; set; } 
        public string FirmaBilgisi { get; set; }
    }
}
