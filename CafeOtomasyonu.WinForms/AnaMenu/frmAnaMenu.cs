using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.WinForms.Kullanicilar;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Menuler;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.XtraEditors;

namespace CafeOtomasyonu.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();
            frmKullaniciGirisi frmkullanicigirisi = new frmKullaniciGirisi();
            frmkullanicigirisi.ShowDialog();
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmurunler = new frmUrunler();
            FormGetir(frmurunler);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmmasalar = new frmMasalar();
            FormGetir(frmmasalar);
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frmmasadurumu = new frmMasaSiparisleri();
            FormGetir(frmmasadurumu);
        }
    }
}