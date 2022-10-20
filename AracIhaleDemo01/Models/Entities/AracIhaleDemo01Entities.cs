using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class AracIhaleDemo01Entities:DbContext
    {
        public AracIhaleDemo01Entities(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=AracIhaleDemo01;uid=sa;pwd=1842");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Ilan> Ilan { get; set; }
        public DbSet<Tramer> Tramer { get; set; }
        public DbSet<TramerCesit> TramerCesit { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<EkspertizSurec> EkspertizSurec { get; set; }
        public DbSet<EkspertizStatu> EkspertizStatu { get; set; }
        public DbSet<KayitTip> KayitTip { get; set; }
        public DbSet<Ihale> Ihale { get; set; }
        public DbSet<IhaleStatu> IhaleStatu { get; set; }
        public DbSet<IhaleFiyat> IhaleFiyat { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<AracDetay> AracDetay { get; set; }
        public DbSet<AracStatu> AracStatu { get; set; }
        public DbSet<RolYetkiIliski> RolYetkiIliski { get; set; }
        public DbSet<Yetki> Yetki { get; set; }
    }
}
