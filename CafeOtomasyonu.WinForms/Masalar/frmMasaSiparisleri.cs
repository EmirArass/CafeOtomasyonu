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
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.Urunler;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerdal = new MusterilerDAL();
        private MasaHareketleriDAL masahareketleridal = new MasaHareketleriDAL();
        private string _satiskodu = null;
        private int? _masaId;
        private OdemeHareketleriDAL odemehareketleriDal = new OdemeHareketleriDAL();
        private Satislar satislar;
        private SatislarDAL satislardal = new SatislarDAL();
        private CafeOtomasyon.Entities.Models.Masalar masalar;
        private MasalarDAL masalardal = new MasalarDAL();

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
                masalar = masalardal.GetByFilter(context, m => m.Id == _masaId);
            }
            satislar = satislardal.GetByFilter(context, s=>s.SatisKodu==_satiskodu);
            if (satislar != null)
            {
                lookUpMusteri.EditValue = satislar.MusteriId;
                txtSatisAciklama.Text = satislar.Aciklama;
                dateEdit1.Text = satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
            }
        }
        void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durumu = false;
            masalar.Islem = null;
            masalar.KullaniciId = null;
            masalardal.AddOrUpdate(context, masalar);
            masalardal.Save(context);
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

        private void btnYenile_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount >0)
            {
                if (dateEdit1.EditValue != null)
                {
                    if (satislar == null)
                    {
                        satislar = new Satislar();
                        satislar.SatisKodu = _satiskodu;
                    }
                    satislar.MusteriId = (int?)lookUpMusteri.EditValue;
                    satislar.Aciklama = txtSatisAciklama.Text;
                    satislar.SonIslemTarihi = Convert.ToDateTime(dateEdit1.EditValue);
                    satislar.Kalan = calcKalan.Value;
                    satislar.Odenen = calcOdenen.Value;
                    satislar.Tutar = calcToplam.Value;
                    satislar.IndirimToplami = calcIndirimToplami.Value;
                    satislardal.AddOrUpdate(context, satislar);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lütfen bir tarih giriniz","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Herhangi kayıt bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnNakit_Click(object sender, EventArgs e)
        {
            //frmOdemeler frmodemeler = new frmOdemeler("Nakit", _satiskodu);
            //frmodemeler.ShowDialog();
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {

        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            var btn = sender as SimpleButton;
            frmOdemeler frmodemeler = new frmOdemeler(btn.Text, _satiskodu);
            frmodemeler.ShowDialog();
            if (frmodemeler.kaydedildi)
            {
                if (odemehareketleriDal.AddOrUpdate(context,frmodemeler._odemehareketleri))
                {
                    gridViewOdemeler.RefreshData();
                    hesapla();
                }
            }
        }

        private void repositorySiparisSil_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Siparişin silinmesini olnaylıyor muusunuz?","Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Stop)== DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili ÖDemenin silinmesini olnaylıyor muusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                gridViewOdemeler.DeleteSelectedRows();
                hesapla();
            }
        }

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (_masaId != null)
            {
                if (calcKalan.Value > 0)
                {

                    if (MessageBox.Show("Seçilen müşteriye borç işlemi kaydedilecektir, devam edilsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        if (satislar != null)
                        {
                            if (satislar.MusteriId == null)
                            {
                                MessageBox.Show("Önce müşteri seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Sonuclandir();
                                this.Close();
                            }
                        }
                    }
                }
                else if(calcKalan.Value == 0)
                {

                }
            }
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            hesapla();
        }
    }
}