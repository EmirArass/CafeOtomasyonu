using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DataAccessLayer;
using CafeOtomasyon.Entities.Models;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalardal = new MasalarDAL();
        private CafeOtomasyon.Entities.Models.Masalar _entity;
        public bool Kaydet = false;
        public frmMasaKaydet(CafeOtomasyon.Entities.Models.Masalar entity)
        {
            InitializeComponent();
            _entity = entity;
            txtMasaAdi.DataBindings.Add("Text", _entity, "MasaAdi");
            memoAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnMasaKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Durumu = false;
                _entity.RezerveDurmu = true;
                _entity.EklenmeTarihi = DateTime.Now;
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Yeni Masa Eklendi";
            }


            else if (_entity.Id != 0)
            {
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Masa Güncellendi";
            }


            if (masalardal.AddOrUpdate(context, _entity))
            {
                masalardal.Save(context);
                Kaydet = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}