using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Repository;
using CafeOtomasyon.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Entities.DataAccessLayer
{
    public class UrunDAL:EntityRepositoryBase<CafeContext, Urun, UrunValidator>
    {
        public object UrunListele(CafeContext context)
        {
            var liste = (from u in context.Urun
                select new
                {
                    u.Id,
                    u.MenuId,
                    Menu = u.Menu.MenuAdi,
                    u.UrunKodu,
                    u.UrunAdi,
                    u.BirimFiyat1,
                    u.BirimFiyat2,
                    u.BirimFiyat3,
                    u.Aciklama,
                    u.Resimler,
                    u.Tarih

                }).ToList();
            return liste;

        }
    }
}
