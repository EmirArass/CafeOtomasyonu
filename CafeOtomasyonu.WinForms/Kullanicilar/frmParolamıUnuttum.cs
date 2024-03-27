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
using CafeOtomasyon.Entities.Mapping;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmParolamıUnuttum : DevExpress.XtraEditors.XtraForm
    {

        private CafeContext context = new CafeContext();
        KullanicilarDAL kullanicilardal = new KullanicilarDAL();
        private KullaniciHareketleri kullanicihareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDAL kullaniciHareketlerddal = new KullaniciHareketleriDAL();


        public frmParolamıUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilardal.GetByFilter(context,
                k => k.KullaniciAdi == txtKullaniciEmail.Text || k.Email == txtKullaniciEmail.Text);
            if (entity != null)
            {
                if (entity.HatirlatmaSorusu==txtSoru.Text && entity.Cevap==txtCevap.Text)
                {
                    if (txtYeniParola.Text==txtYeniParolaTekrar.Text)
                    {
                        entity.Parola = txtYeniParolaTekrar.Text;
                        if (kullanicilardal.AddOrUpdate(context,entity))
                        {
                            kullanicilardal.Save(context);
                            kullanicihareketleri.KullaniciId = entity.Id;
                            string aciklama = entity.KullaniciAdi + " Adlı Kullanıcının parolası yenilendi";
                            kullaniciHareketlerddal.KullaniciHareketleriEkle(context, kullanicihareketleri, aciklama);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Girilien soru veya cevap yanlıştır", "Uyarı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}