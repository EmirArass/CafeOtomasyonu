using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Repository;
using CafeOtomasyon.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.DataAccessLayer
{
    public class KullaniciHareketleriDAL: EntityRepositoryBase<CafeContext,KullaniciHareketleri,KullaniciHareketleriValidator>
    {
        //public static int KullaniciId { get; set; }

        public void KullaniciHareketleriEkle(CafeContext context, KullaniciHareketleri kullanicihareketleri, string aciklama)
        {
            KullaniciHareketleriDAL kullanicihareketleridal = new KullaniciHareketleriDAL();

            kullanicihareketleri.Tarih = DateTime.Now;
            kullanicihareketleri.Aciklama = aciklama;

            if (kullanicihareketleridal.AddOrUpdate(context, kullanicihareketleri))
            {
                kullanicihareketleridal.Save(context);
            }
        }
    }
}
