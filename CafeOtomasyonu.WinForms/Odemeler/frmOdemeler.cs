﻿using CafeOtomasyon.Entities.Models;
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

namespace CafeOtomasyonu.WinForms.Odemeler
{
    public partial class frmOdemeler : DevExpress.XtraEditors.XtraForm
    {
        private string _satiskodu;
        private string _odemeturu;
        public OdemeHareketleri _odemehareketleri;
        public bool kaydedildi;

        public frmOdemeler(string odemeturu, string satiskodu)
        {
            InitializeComponent();
            _satiskodu = satiskodu;
            _odemeturu = odemeturu;
            if (_odemeturu == "Nakit")
            {
                lblBaslik.Text = "Nakit ile Ödeme";
            }
            else if(_odemeturu == "Kredi Kartı")
            {
                lblBaslik.Text = "Kredi Kartı ile ödeme";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _odemehareketleri = new OdemeHareketleri
            {
                SatisKodu = _satiskodu,
                OdemeTuru = _odemeturu,
                Odenen = calcOdenecekTutar.Value,
                Aciklama = txtAciklama.Text,
                Tarih = Convert.ToDateTime(dateTarih.Text)
            };
            kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}