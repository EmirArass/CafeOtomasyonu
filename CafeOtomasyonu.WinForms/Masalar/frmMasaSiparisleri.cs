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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerdal = new MusterilerDAL();
        private int? _masaId;

        public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satisKodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            lookUpMusteri.Properties.DataSource = musterilerdal.GetAll(context);
            if (_masaId!= null)
            {
                lblBaslik.Text = masaAdi+" Siparişleri ";
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
    }
}