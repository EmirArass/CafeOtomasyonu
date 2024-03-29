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
namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaDurumu: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private CheckButton btnsender;
        private SatisKodu modelSatisKodu;
        private object _SatisKodu;
        private int _masaId;

        public frmMasaDurumu()
        {
            InitializeComponent();
            modelSatisKodu = context.SatisKodu.First();
            MasalariGetir();
        }

        public void MasalariGetir()
        {
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].SatisKodu;
                btn.Height = 64;
                btn.Width = 64;
                flowLayoutPanel1.Controls.Add(btn);
                if (model[i].RezerveDurmu && !model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.DarkOrange;
                }
                else if (model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.DarkGreen;
                }
                btn.Click += Btn_Click;
            }
        }

        public void DurumlariYenile()
        {
            btnSiparisler.Enabled = false;
            btnMasaAc.Enabled = false;
            btnRezerveyeAyir.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btnsender = sender as CheckButton;
            DurumlariYenile();
            if (btnsender.Appearance.BackColor == Color.DarkGreen)
            {
                btnMasaAc.Enabled = true;
                btnRezerveyeAyir.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.DarkOrange)
            {
                btnMasaAc.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.Red)
            {
                btnSiparisler.Enabled = true;
            }
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            _masaId = Convert.ToInt32(btnsender.Name);
            frmMasaSiparisleri frmmasasiparisleri = new frmMasaSiparisleri(masaId: _masaId, masaAdi: btnsender.Text);
            frmmasasiparisleri.ShowDialog();
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    var btn = sender as CheckButton;
        //    MessageBox.Show(btn.Text);
        //
        // "Masa Adı : " + btn.Text + " " + "Masa ID" + btn.Name;
        //
        // MessageBox.Show(tiklananbtn.Text);
        //}
    }
}