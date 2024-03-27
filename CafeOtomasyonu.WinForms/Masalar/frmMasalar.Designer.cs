namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasalar
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
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKayit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDurumDegisitr = new DevExpress.XtraEditors.SimpleButton();
            this.txtRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezerveDuurmu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.refresh2_32x32;
            this.btnYenile.Location = new System.Drawing.Point(219, 31);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(101, 64);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.linecolor;
            this.btnDuzenle.Location = new System.Drawing.Point(112, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(101, 64);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.add_32x32;
            this.btnYeniKayit.Location = new System.Drawing.Point(5, 31);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(101, 64);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.txtDurumDegisitr);
            this.groupControl1.Controls.Add(this.txtRezerveDegistir);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnYeniKayit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 710);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1548, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
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
            this.txtDurumDegisitr.Click += new System.EventHandler(this.txtDurumDegisitr_Click);
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
            this.txtRezerveDegistir.Click += new System.EventHandler(this.txtRezerveDegistir_Click);
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
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Masalar";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.masalarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1548, 634);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataSource = typeof(CafeOtomasyon.Entities.Models.Masalar);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurumu,
            this.colRezerveDuurmu,
            this.colEklenmeTarihi,
            this.colSonIslemTarihi,
            this.colMasaHareketleri,
            this.colIslem,
            this.colKullaniciId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 49;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.MinWidth = 25;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 1;
            this.colMasaAdi.Width = 92;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 483;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.MinWidth = 25;
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 3;
            this.colDurumu.Width = 112;
            // 
            // colRezerveDuurmu
            // 
            this.colRezerveDuurmu.Caption = "Rezerve Durumu";
            this.colRezerveDuurmu.FieldName = "RezerveDurmu";
            this.colRezerveDuurmu.MinWidth = 25;
            this.colRezerveDuurmu.Name = "colRezerveDuurmu";
            this.colRezerveDuurmu.Visible = true;
            this.colRezerveDuurmu.VisibleIndex = 4;
            this.colRezerveDuurmu.Width = 116;
            // 
            // colEklenmeTarihi
            // 
            this.colEklenmeTarihi.FieldName = "EklenmeTarihi";
            this.colEklenmeTarihi.MinWidth = 25;
            this.colEklenmeTarihi.Name = "colEklenmeTarihi";
            this.colEklenmeTarihi.Visible = true;
            this.colEklenmeTarihi.VisibleIndex = 5;
            this.colEklenmeTarihi.Width = 103;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.MinWidth = 25;
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 6;
            this.colSonIslemTarihi.Width = 113;
            // 
            // colMasaHareketleri
            // 
            this.colMasaHareketleri.FieldName = "MasaHareketleri";
            this.colMasaHareketleri.MinWidth = 25;
            this.colMasaHareketleri.Name = "colMasaHareketleri";
            this.colMasaHareketleri.Width = 94;
            // 
            // colIslem
            // 
            this.colIslem.FieldName = "Islem";
            this.colIslem.MinWidth = 25;
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            this.colIslem.Width = 377;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "Kullanıcı";
            this.colKullaniciId.FieldName = "Kullanici";
            this.colKullaniciId.MinWidth = 25;
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 7;
            this.colKullaniciId.Width = 174;
            // 
            // frmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 810);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMasalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colRezerveDuurmu;
        private DevExpress.XtraGrid.Columns.GridColumn colEklenmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraEditors.SimpleButton txtDurumDegisitr;
        private DevExpress.XtraEditors.SimpleButton txtRezerveDegistir;
    }
}