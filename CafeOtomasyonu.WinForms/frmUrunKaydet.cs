using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DataAccessLayer;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyonu.WinForms.Urunler;

namespace CafeOtomasyonu.WinForms
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDAL menudal = new MenuDAL();
        private UrunDAL urundal = new UrunDAL();
        private Urun _entity;
        CafeContext context = new CafeContext();

        public bool kaydet = false;
        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookupeditMenu.Properties.DataSource = menudal.GetAll(context);
            lookupeditMenu.DataBindings.Add("EditValue", _entity,"MenuId");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", _entity,"UrunAdi");
            calcBirimFiyati1.DataBindings.Add("Text", _entity,"BirimFiyat1", true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity,"BirimFiyat2",true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity,"BirimFiyat3",true);
            memoAciklama.DataBindings.Add("Text", _entity,"Aciklama");
            dateTarih.DataBindings.Add("Text", _entity,"Tarih", true);
            if (_entity.Id != 0)
            {
                if (_entity.Resimler != null)
                {
                    pictureEdit1.Image = Image.FromFile(_entity.Resimler);
                }
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != null)
            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                File.Copy(pictureEdit1.GetLoadedImageLocation(),hedefyol);
                _entity.Resimler = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                kaydet = true;
            }

            if (urundal.AddOrUpdate(context,_entity))
            {
                urundal.Save(context); 
                MessageBox.Show("Ürün Kaydı Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}