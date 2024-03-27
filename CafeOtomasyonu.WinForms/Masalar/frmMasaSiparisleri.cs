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
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();

        public frmMasaSiparisleri()
        {
            InitializeComponent();
            DinamicTables.MasalariGetir(context, flowLayoutPanel1);
        }
    }
}