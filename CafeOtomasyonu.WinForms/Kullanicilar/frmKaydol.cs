using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DataAccessLayer;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Interfaces;
using CafeOtomasyon.Entities.Mapping;
using CafeOtomasyonu.WinForms.Masalar;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDAL kullanicilardal = new KullanicilarDAL();
        private CafeOtomasyon.Entities.Models.Kullanicilar _entity;
        private KullaniciHareketleri kullanicihareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDAL kullaniciHareketlerdDal = new KullaniciHareketleriDAL();
        public bool kaydet = false;

        public frmKaydol(CafeOtomasyon.Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleAktifMi.DataBindings.Add("EditValue", _entity, "AktiflikDurumu");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            txtParola.DataBindings.Add("Text", _entity, "Parola");
            txtHAtirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            _entity.KayitTarihi = DateTime.Now;
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                if (kullanicilardal.AddOrUpdate(context, _entity))
                {
                    kullanicilardal.Save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullanicihareketleri.KullaniciId = model;
                    string aciklama = "Yeni Kullanıcı Eklendi";
                    kullaniciHareketlerdDal.KullaniciHareketleriEkle(context,kullanicihareketleri,aciklama);
                    kaydet = true;
                    this.Close();
                } 
            }
            else
            {
                MessageBox.Show("Lütfen parola kısımlarının doğru olduğundan emin olun", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}