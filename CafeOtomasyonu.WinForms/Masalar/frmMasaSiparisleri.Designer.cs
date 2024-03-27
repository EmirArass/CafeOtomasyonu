namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaSiparisleri
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
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDurumDegisitr = new DevExpress.XtraEditors.SimpleButton();
            this.txtRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRezerveMasa = new DevExpress.XtraEditors.SimpleButton();
            this.bntBosMasa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoluMasa = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupHesaplamalar = new DevExpress.XtraEditors.GroupControl();
            this.calcIndirimliToplam = new DevExpress.XtraEditors.CalcEdit();
            this.calcIndirimOrani = new DevExpress.XtraEditors.CalcEdit();
            this.calcKalan = new DevExpress.XtraEditors.CalcEdit();
            this.CalcToplam = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.calcIndirimToplamı = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.calcOdenen = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHesaplamalar)).BeginInit();
            this.groupHesaplamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimliToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKalan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimToplamı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataSource = typeof(CafeOtomasyon.Entities.Models.Masalar);
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
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Masa Durumları";
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
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.txtDurumDegisitr);
            this.groupIslemler.Controls.Add(this.txtRezerveDegistir);
            this.groupIslemler.Controls.Add(this.btnSil);
            this.groupIslemler.Controls.Add(this.btnYenile);
            this.groupIslemler.Controls.Add(this.btnDuzenle);
            this.groupIslemler.Controls.Add(this.btnSiparisEkle);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 710);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1548, 100);
            this.groupIslemler.TabIndex = 9;
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
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.refresh2_32x32;
            this.btnYenile.Location = new System.Drawing.Point(219, 31);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(101, 64);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.linecolor;
            this.btnDuzenle.Location = new System.Drawing.Point(112, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(101, 64);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.add_32x32;
            this.btnSiparisEkle.Location = new System.Drawing.Point(5, 31);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(101, 64);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Yeni";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 76);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupHesaplamalar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1548, 634);
            this.splitContainerControl1.SplitterPosition = 239;
            this.splitContainerControl1.TabIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRezerveMasa);
            this.panelControl1.Controls.Add(this.bntBosMasa);
            this.panelControl1.Controls.Add(this.btnDoluMasa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 183);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1548, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRezerveMasa
            // 
            this.btnRezerveMasa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnRezerveMasa.Appearance.Options.UseBackColor = true;
            this.btnRezerveMasa.Location = new System.Drawing.Point(250, 0);
            this.btnRezerveMasa.Name = "btnRezerveMasa";
            this.btnRezerveMasa.Size = new System.Drawing.Size(119, 56);
            this.btnRezerveMasa.TabIndex = 0;
            this.btnRezerveMasa.Text = "Rezerve Masa";
            // 
            // bntBosMasa
            // 
            this.bntBosMasa.Appearance.BackColor = System.Drawing.Color.Green;
            this.bntBosMasa.Appearance.Options.UseBackColor = true;
            this.bntBosMasa.Location = new System.Drawing.Point(125, 0);
            this.bntBosMasa.Name = "bntBosMasa";
            this.bntBosMasa.Size = new System.Drawing.Size(119, 56);
            this.bntBosMasa.TabIndex = 0;
            this.bntBosMasa.Text = "Boş Masa";
            // 
            // btnDoluMasa
            // 
            this.btnDoluMasa.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDoluMasa.Appearance.Options.UseBackColor = true;
            this.btnDoluMasa.Location = new System.Drawing.Point(0, 0);
            this.btnDoluMasa.Name = "btnDoluMasa";
            this.btnDoluMasa.Size = new System.Drawing.Size(119, 56);
            this.btnDoluMasa.TabIndex = 0;
            this.btnDoluMasa.Text = "Dolu Masa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1548, 177);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1548, 264);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupHesaplamalar
            // 
            this.groupHesaplamalar.Controls.Add(this.calcIndirimliToplam);
            this.groupHesaplamalar.Controls.Add(this.calcIndirimOrani);
            this.groupHesaplamalar.Controls.Add(this.calcKalan);
            this.groupHesaplamalar.Controls.Add(this.CalcToplam);
            this.groupHesaplamalar.Controls.Add(this.labelControl7);
            this.groupHesaplamalar.Controls.Add(this.calcIndirimToplamı);
            this.groupHesaplamalar.Controls.Add(this.labelControl5);
            this.groupHesaplamalar.Controls.Add(this.labelControl6);
            this.groupHesaplamalar.Controls.Add(this.calcOdenen);
            this.groupHesaplamalar.Controls.Add(this.labelControl4);
            this.groupHesaplamalar.Controls.Add(this.labelControl3);
            this.groupHesaplamalar.Controls.Add(this.labelControl2);
            this.groupHesaplamalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupHesaplamalar.Location = new System.Drawing.Point(0, 264);
            this.groupHesaplamalar.Name = "groupHesaplamalar";
            this.groupHesaplamalar.Size = new System.Drawing.Size(1548, 119);
            this.groupHesaplamalar.TabIndex = 0;
            this.groupHesaplamalar.Text = "Hesaplamalar";
            // 
            // calcIndirimliToplam
            // 
            this.calcIndirimliToplam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calcIndirimliToplam.Location = new System.Drawing.Point(1328, 79);
            this.calcIndirimliToplam.Name = "calcIndirimliToplam";
            this.calcIndirimliToplam.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.calcIndirimliToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcIndirimliToplam.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcIndirimliToplam.Properties.Appearance.Options.UseBackColor = true;
            this.calcIndirimliToplam.Properties.Appearance.Options.UseFont = true;
            this.calcIndirimliToplam.Properties.Appearance.Options.UseForeColor = true;
            this.calcIndirimliToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcIndirimliToplam.Properties.MaskSettings.Set("mask", "c");
            this.calcIndirimliToplam.Properties.NullText = "₺0,00";
            this.calcIndirimliToplam.Properties.UseMaskAsDisplayFormat = true;
            this.calcIndirimliToplam.Size = new System.Drawing.Size(205, 34);
            this.calcIndirimliToplam.TabIndex = 1;
            // 
            // calcIndirimOrani
            // 
            this.calcIndirimOrani.Location = new System.Drawing.Point(766, 79);
            this.calcIndirimOrani.Name = "calcIndirimOrani";
            this.calcIndirimOrani.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.calcIndirimOrani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcIndirimOrani.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcIndirimOrani.Properties.Appearance.Options.UseBackColor = true;
            this.calcIndirimOrani.Properties.Appearance.Options.UseFont = true;
            this.calcIndirimOrani.Properties.Appearance.Options.UseForeColor = true;
            this.calcIndirimOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcIndirimOrani.Properties.MaskSettings.Set("mask", "c");
            this.calcIndirimOrani.Properties.NullText = "%0,00";
            this.calcIndirimOrani.Properties.UseMaskAsDisplayFormat = true;
            this.calcIndirimOrani.Size = new System.Drawing.Size(205, 34);
            this.calcIndirimOrani.TabIndex = 1;
            // 
            // calcKalan
            // 
            this.calcKalan.Location = new System.Drawing.Point(136, 79);
            this.calcKalan.Name = "calcKalan";
            this.calcKalan.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.calcKalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcKalan.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcKalan.Properties.Appearance.Options.UseBackColor = true;
            this.calcKalan.Properties.Appearance.Options.UseFont = true;
            this.calcKalan.Properties.Appearance.Options.UseForeColor = true;
            this.calcKalan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcKalan.Properties.MaskSettings.Set("mask", "c");
            this.calcKalan.Properties.NullText = "₺0,00";
            this.calcKalan.Properties.UseMaskAsDisplayFormat = true;
            this.calcKalan.Size = new System.Drawing.Size(205, 34);
            this.calcKalan.TabIndex = 1;
            // 
            // CalcToplam
            // 
            this.CalcToplam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CalcToplam.Location = new System.Drawing.Point(1328, 39);
            this.CalcToplam.Name = "CalcToplam";
            this.CalcToplam.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.CalcToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalcToplam.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.CalcToplam.Properties.Appearance.Options.UseBackColor = true;
            this.CalcToplam.Properties.Appearance.Options.UseFont = true;
            this.CalcToplam.Properties.Appearance.Options.UseForeColor = true;
            this.CalcToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CalcToplam.Properties.MaskSettings.Set("mask", "c");
            this.CalcToplam.Properties.NullText = "₺0,00";
            this.CalcToplam.Properties.UseMaskAsDisplayFormat = true;
            this.CalcToplam.Size = new System.Drawing.Size(205, 34);
            this.CalcToplam.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(1204, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(118, 35);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "İndirimli Toplam : ";
            // 
            // calcIndirimToplamı
            // 
            this.calcIndirimToplamı.Location = new System.Drawing.Point(766, 39);
            this.calcIndirimToplamı.Name = "calcIndirimToplamı";
            this.calcIndirimToplamı.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.calcIndirimToplamı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcIndirimToplamı.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcIndirimToplamı.Properties.Appearance.Options.UseBackColor = true;
            this.calcIndirimToplamı.Properties.Appearance.Options.UseFont = true;
            this.calcIndirimToplamı.Properties.Appearance.Options.UseForeColor = true;
            this.calcIndirimToplamı.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcIndirimToplamı.Properties.MaskSettings.Set("mask", "c");
            this.calcIndirimToplamı.Properties.NullText = "₺0,00";
            this.calcIndirimToplamı.Properties.UseMaskAsDisplayFormat = true;
            this.calcIndirimToplamı.Size = new System.Drawing.Size(205, 34);
            this.calcIndirimToplamı.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(642, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(118, 35);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "İndirim Oranı(%) : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(1204, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 35);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Toplam : ";
            // 
            // calcOdenen
            // 
            this.calcOdenen.Location = new System.Drawing.Point(136, 39);
            this.calcOdenen.Name = "calcOdenen";
            this.calcOdenen.Properties.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.calcOdenen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcOdenen.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcOdenen.Properties.Appearance.Options.UseBackColor = true;
            this.calcOdenen.Properties.Appearance.Options.UseFont = true;
            this.calcOdenen.Properties.Appearance.Options.UseForeColor = true;
            this.calcOdenen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOdenen.Properties.MaskSettings.Set("mask", "c");
            this.calcOdenen.Properties.NullText = "₺0,00";
            this.calcOdenen.Properties.UseMaskAsDisplayFormat = true;
            this.calcOdenen.Size = new System.Drawing.Size(205, 34);
            this.calcOdenen.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(642, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 35);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İndirim Toplamı : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 35);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kalan : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 35);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ödenen : ";
            // 
            // frmMasaSiparisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 810);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupIslemler);
            this.Name = "frmMasaSiparisleri";
            this.Text = "frmMasaDurumlari";
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHesaplamalar)).EndInit();
            this.groupHesaplamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimliToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKalan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcIndirimToplamı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton txtDurumDegisitr;
        private DevExpress.XtraEditors.SimpleButton txtRezerveDegistir;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupHesaplamalar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRezerveMasa;
        private DevExpress.XtraEditors.SimpleButton bntBosMasa;
        private DevExpress.XtraEditors.SimpleButton btnDoluMasa;
        private DevExpress.XtraEditors.CalcEdit calcOdenen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcKalan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit calcIndirimliToplam;
        private DevExpress.XtraEditors.CalcEdit calcIndirimOrani;
        private DevExpress.XtraEditors.CalcEdit CalcToplam;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit calcIndirimToplamı;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}