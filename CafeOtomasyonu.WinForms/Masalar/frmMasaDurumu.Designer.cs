namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaDurumu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtDurumDegisitr = new DevExpress.XtraEditors.SimpleButton();
            this.txtRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnRezerveyeAyir = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisler = new DevExpress.XtraEditors.SimpleButton();
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1548, 76);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.txtDurumDegisitr);
            this.groupIslemler.Controls.Add(this.txtRezerveDegistir);
            this.groupIslemler.Controls.Add(this.btnSil);
            this.groupIslemler.Controls.Add(this.btnRezerveyeAyir);
            this.groupIslemler.Controls.Add(this.btnMasaAc);
            this.groupIslemler.Controls.Add(this.btnYenile);
            this.groupIslemler.Controls.Add(this.btnDuzenle);
            this.groupIslemler.Controls.Add(this.btnSiparisler);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 710);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1548, 100);
            this.groupIslemler.TabIndex = 12;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.clearheaderandfooter;
            this.btnKapat.Location = new System.Drawing.Point(1435, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(101, 64);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // txtDurumDegisitr
            // 
            this.txtDurumDegisitr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDurumDegisitr.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.trackingchanges_allmarkup;
            this.txtDurumDegisitr.Location = new System.Drawing.Point(1114, 31);
            this.txtDurumDegisitr.Name = "txtDurumDegisitr";
            this.txtDurumDegisitr.Size = new System.Drawing.Size(101, 64);
            this.txtDurumDegisitr.TabIndex = 0;
            this.txtDurumDegisitr.Text = "Durum \r\nDeğiştir";
            // 
            // txtRezerveDegistir
            // 
            this.txtRezerveDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRezerveDegistir.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.trackingchanges_trackchanges;
            this.txtRezerveDegistir.Location = new System.Drawing.Point(1221, 31);
            this.txtRezerveDegistir.Name = "txtRezerveDegistir";
            this.txtRezerveDegistir.Size = new System.Drawing.Size(101, 64);
            this.txtRezerveDegistir.TabIndex = 0;
            this.txtRezerveDegistir.Text = "Rezerve \r\nDeğiştir";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.removedataitems;
            this.btnSil.Location = new System.Drawing.Point(1328, 31);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 64);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // btnRezerveyeAyir
            // 
            this.btnRezerveyeAyir.Enabled = false;
            this.btnRezerveyeAyir.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.time;
            this.btnRezerveyeAyir.Location = new System.Drawing.Point(287, 31);
            this.btnRezerveyeAyir.Name = "btnRezerveyeAyir";
            this.btnRezerveyeAyir.Size = new System.Drawing.Size(135, 64);
            this.btnRezerveyeAyir.TabIndex = 0;
            this.btnRezerveyeAyir.Text = "Rezerveye Ayır";
            this.btnRezerveyeAyir.Click += new System.EventHandler(this.btnRezerveyeAyir_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Enabled = false;
            this.btnMasaAc.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.shopping_store;
            this.btnMasaAc.Location = new System.Drawing.Point(146, 31);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(135, 64);
            this.btnMasaAc.TabIndex = 0;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.linecolor;
            this.btnDuzenle.Location = new System.Drawing.Point(569, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(101, 64);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1548, 634);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.refresh2_32x32;
            this.btnYenile.Location = new System.Drawing.Point(428, 31);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(135, 64);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Enabled = false;
            this.btnSiparisler.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.add_32x32;
            this.btnSiparisler.Location = new System.Drawing.Point(5, 31);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(135, 64);
            this.btnSiparisler.TabIndex = 0;
            this.btnSiparisler.Text = "Siparişler";
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataSource = typeof(CafeOtomasyon.Entities.Models.Masalar);
            // 
            // frmMasaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 810);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMasaDurumu";
            this.Text = "Masa Durumları";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton txtDurumDegisitr;
        private DevExpress.XtraEditors.SimpleButton txtRezerveDegistir;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSiparisler;
        private DevExpress.XtraEditors.SimpleButton btnRezerveyeAyir;
        private DevExpress.XtraEditors.SimpleButton btnMasaAc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}