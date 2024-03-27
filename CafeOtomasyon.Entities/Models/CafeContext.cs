using CafeOtomasyon.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("name=connection")
        {
        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Masalar> Masalar { get; set; }
        public DbSet<MasaHareketleri> MasaHareketleri { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public DbSet<KullaniciRolleri> KullaniciRolleri { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<OdemeHareketleri> OdemeHareketleris { get; set; }
        public DbSet<SatisKodu> SatisKodu { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new MasaHareketleriMap());
            modelBuilder.Configurations.Add(new MasalarMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new OdemeHareketleriMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
        }
    }
}
