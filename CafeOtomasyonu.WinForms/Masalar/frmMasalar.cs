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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalardal = new MasalarDAL();

        public frmMasalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masalardal.MasalariListele(context);
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmMasaKaydet frmmasakaydet = new frmMasaKaydet(new CafeOtomasyon.Entities.Models.Masalar());
            frmmasakaydet.ShowDialog();
            if (frmmasakaydet.Kaydet)
            {
                Listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalardal.GetByFilter(context, m => m.Id == seciliId);
            frmMasaKaydet frmmasakaydet = new frmMasaKaydet(masalar);
            frmmasakaydet.ShowDialog();
            if (frmmasakaydet.Kaydet)
            {
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32((gridView1.GetFocusedRowCellValue(colId)));
            if (MessageBox.Show("Seçili Kayıt Silinecek Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masalardal.Delete(context, m => m.Id == seciliId);
                masalardal.Save(context);
                Listele();
            }
        }

        private void txtDurumDegisitr_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalardal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.Durumu)
                {
                    masalar.Durumu = false;
                }
                else if(!masalar.Durumu)
                {
                    masalar.Durumu = true;
                }
            }
            masalardal.Save(context);
            Listele();
        }

        private void txtRezerveDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalardal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.RezerveDurmu)
                {
                    masalar.RezerveDurmu = false;
                }
                else if (!masalar.RezerveDurmu)
                {
                    masalar.RezerveDurmu = true;
                }
            }
            masalardal.Save(context);
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}