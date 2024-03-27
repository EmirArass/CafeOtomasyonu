using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("Urun")]
    public class Urun:IEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat1 { get; set; }
        public decimal BirimFiyat2 { get; set; }
        public decimal BirimFiyat3 { get; set; }

        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Resimler { get; set; }


        public Menu Menu { get; set; }
    }
}
