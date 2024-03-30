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
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaRezervasyonu : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemyapildi;
        private CafeOtomasyon.Entities.Models.Masalar masalar;
        private MasalarDAL masalardal = new MasalarDAL();
        private CafeContext context = new CafeContext();

        public frmMasaRezervasyonu(int masaId)
        {
            _masaId = masaId;
            InitializeComponent();
            
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            masalar = masalardal.GetByFilter(context, m => m.Id == _masaId);
            masalar.Islem = txtIslem.Text;
            masalar.SonIslemTarihi = Convert.ToDateTime(dateEdit1.EditValue);
            masalar.KullaniciId = KullaniciAyarlari.kullaniciId;
            masalar.RezerveDurmu = true;
            masalardal.Save(context);
            islemyapildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}