using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("Masalar")]
    public class Masalar:IEntity
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durumu { get; set; }
        public bool RezerveDurmu { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public string Islem { get; set; }
        public int? KullaniciId { get; set; }                               // int'in sonundaki soru işareti null geçilebilir anlamında Nullable<int> şeklinde de kullanılabilir
        public ICollection<MasaHareketleri> MasaHareketleri { get; set; }   
    }
}
