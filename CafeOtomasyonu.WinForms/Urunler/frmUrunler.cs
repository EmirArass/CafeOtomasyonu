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

namespace CafeOtomasyonu.WinForms.Urunler
{
    public partial class frmUrunler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        private UrunDAL urundal = new UrunDAL();
        //public bool kaydet = false;
        public frmUrunler()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = urundal.UrunListele(context);
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmUrunKaydet frmurunkaydet = new frmUrunKaydet(new Urun());
            frmurunkaydet.ShowDialog();
            if (frmurunkaydet.kaydet)
            {
                Listele();
            }
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmUrunKaydet frmurunkaydet = new frmUrunKaydet(urundal.GetByFilter(context, u=>u.Id == seciliId));
            frmurunkaydet.ShowDialog();
            if (frmurunkaydet.kaydet)
            {
                Listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32((gridView1.GetFocusedRowCellValue(colId)));
            if (MessageBox.Show("Seçili Kayıt Silinecek Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                urundal.Delete(context, u=>u.Id==seciliId);
                urundal.Save(context);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}