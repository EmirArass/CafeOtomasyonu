﻿using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("Kullanicilar")]
    public class Kullanicilar:IEntity
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Gorevi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AktiflikDurumu { get; set; }

        public virtual ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public virtual ICollection<Masalar> masalar { get; set; }
    }
}
