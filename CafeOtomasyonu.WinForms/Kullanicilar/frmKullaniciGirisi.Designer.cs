namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    partial class frmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnParolamiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirişyap = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.hyperKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(695, 59);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnParolamiUnuttum);
            this.groupControl1.Controls.Add(this.btnGirişyap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(260, 251);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(435, 100);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.clearheaderandfooter;
            this.btnKapat.Location = new System.Drawing.Point(322, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(101, 64);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.info_32x321;
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(138, 31);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(127, 64);
            this.btnParolamiUnuttum.TabIndex = 0;
            this.btnParolamiUnuttum.Text = "Parolamı\r\nUnuttum";
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnGirişyap
            // 
            this.btnGirişyap.ImageOptions.Image = global::CafeOtomasyonu.WinForms.Properties.Resources.apply_32x32;
            this.btnGirişyap.Location = new System.Drawing.Point(5, 31);
            this.btnGirişyap.Name = "btnGirişyap";
            this.btnGirişyap.Size = new System.Drawing.Size(127, 64);
            this.btnGirişyap.TabIndex = 0;
            this.btnGirişyap.Text = "Giriş Yap";
            this.btnGirişyap.Click += new System.EventHandler(this.btnGirişyap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(266, 146);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.ContextImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.bo_user;
            this.txtSifre.Properties.NullText = "Kullanıcı Şifrenizi Giriniz";
            this.txtSifre.Properties.NullValuePrompt = "Kullanıcı Şifrenizi Giriniz";
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(403, 44);
            this.txtSifre.TabIndex = 19;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(266, 82);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.ContextImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.bo_employee;
            this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(403, 44);
            this.txtKullaniciAdi.TabIndex = 19;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 59);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(260, 292);
            this.pictureEdit1.TabIndex = 17;
            // 
            // hyperKaydol
            // 
            this.hyperKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperKaydol.Appearance.Options.UseFont = true;
            this.hyperKaydol.Location = new System.Drawing.Point(620, 196);
            this.hyperKaydol.Name = "hyperKaydol";
            this.hyperKaydol.Size = new System.Drawing.Size(49, 21);
            this.hyperKaydol.TabIndex = 20;
            this.hyperKaydol.Text = "Kaydol";
            this.hyperKaydol.Click += new System.EventHandler(this.hyperKaydol_Click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(266, 198);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(126, 25);
            this.checkBeniHatirla.TabIndex = 21;
            // 
            // frmKullaniciGirisi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 351);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.hyperKaydol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciGirisi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGirişyap;
        private DevExpress.XtraEditors.SimpleButton btnParolamiUnuttum;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperKaydol;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
    }
}