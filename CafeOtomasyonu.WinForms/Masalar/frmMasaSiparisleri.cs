using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DataAccessLayer;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyonu.WinForms.Urunler;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerdal = new MusterilerDAL();
        private MasaHareketleriDAL masahareketleridal = new MasaHareketleriDAL();
        private string _satiskodu = null;
        private int? _masaId;

        public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satisKodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            _satiskodu = satisKodu;
            context.MasaHareketleri.Where(m => m.SatisKodu == satisKodu).Load();
            context.OdemeHareketleris.Where(o=>o.SatisKodu == satisKodu).Load();
            context.Urun.Load();
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.OdemeHareketleris.Local.ToBindingList();
            lookUpMusteri.Properties.DataSource = musterilerdal.GetAll(context);
            if (_masaId!= null)
            {
                lblBaslik.Text = masaAdi+" Siparişleri ";
            }
        }

        void hesapla()
        {
            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutari1.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToDecimal(colmnTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplam.Value;
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value; 

//
//   İndirim Oranı
//

            if (calcToplam.Value != 0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colIndirimTutari1.SummaryItem.SummaryValue) /
                                         (Convert.ToDecimal(colmnTutar.SummaryItem.SummaryValue) +
                                          Convert.ToDecimal(colIndirimTutari1.SummaryItem.SummaryValue));
                //calcToplam.Value;
                //Convert.ToDecimal(colIndirimTutari1.SummaryItem.SummaryValue)
                //(Convert.ToDecimal(colmnTutar.SummaryItem.SummaryValue) +
                //Convert.ToDecimal(colIndirimTutari1.SummaryItem.SummaryValue));
            }
            else if (calcToplam.Value == 0)
            {
                calcIndirimOrani.Value = 0;
            }
        }

        private void btnMusteriResetle_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmUrunSec frmurunsec = new frmUrunSec();
            frmurunsec.ShowDialog();
            if (frmurunsec.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satiskodu,
                    MasaId = Convert.ToInt32(_masaId),
                    UrunId = frmurunsec.urunmodel.Id,
                    Miktari = 1,
                    BirimFiyati = frmurunsec.urunmodel.BirimFiyat1,
                    IndirimTutari = 0,
                    Aciklama = "",
                    Tarih = DateTime.Now
                };
                if (masahareketleridal.AddOrUpdate(context,entity))
                {
                    
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            hesapla();
        }
    }
}