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
    public   class MasalarDAL:EntityRepositoryBase<CafeContext,Masalar, MasalarValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            var model  = (from Masalar in context.Masalar join k in context.Kullanicilar on Masalar.KullaniciId equals k.Id into kullanici from kullanicimasa in kullanici.DefaultIfEmpty() select new
            {   
                Masalar.Aciklama,
                Masalar.Durumu,
                Masalar.EklenmeTarihi,
                Masalar.Id,
                Masalar.Islem,
                Masalar.MasaAdi,
                Masalar.RezerveDurmu,
                Masalar.SonIslemTarihi,    
                Kullanici = kullanicimasa.KullaniciAdi
            }).ToList();
            return model;
        }
    }
}
