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
    
    public partial class frmUrunSec : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDAL urundal = new UrunDAL();
        public Urun urunmodel;
        public bool secildi;

        public frmUrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = urundal.GetAll(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount >0)
            {
                int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                urunmodel = urundal.GetByFilter(context, u => u.Id == urunId);
                secildi = true;
                this.Close(); 
            }
        }
    }
}