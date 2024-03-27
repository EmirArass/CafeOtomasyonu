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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        public bool giris;
        CafeContext context = new CafeContext();
        private KullaniciHareketleriDAL kullanicihareketleridal = new KullaniciHareketleriDAL();
        private KullaniciHareketleri entity=new KullaniciHareketleri();

        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtSifre.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked == true)
            {
                Properties.Settings.Default.KullaniciAdi= txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtSifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        public frmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btnGirişyap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtSifre.Text);
            if (context.Kullanicilar.Any(k=>k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtSifre.Text))
            {
                giris = true;
                //BilgileriKaydet();
                //    entity.KullaniciId = model.Id;
                //    string aciklama = model.KullaniciAdi + "Adlı Kullanıcı Sisteme Giriş Yaptı";
                //    kullanicihareketleridal.KullaniciHareketleriEkle(context, entity,aciklama);
                    
                    this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da şifresi yanlıştır", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void hyperKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frmkaydol = new frmKaydol(new CafeOtomasyon.Entities.Models.Kullanicilar());
            frmkaydol.ShowDialog();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamıUnuttum frmparolamiunuttum = new frmParolamıUnuttum();
            frmparolamiunuttum.ShowDialog();
        }
    }
}