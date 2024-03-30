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
using CafeOtomasyon.Entities.Models;

namespace CafeOtomasyonu.WinForms.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        public bool kaydet;

        public frmUrunKaydet(Urun byFilter)
        {
            InitializeComponent();
        }
    }
}