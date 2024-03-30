namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaRezervasyonu
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
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtIslem = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(625, 76);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "Masa Durumları";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(12, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(139, 28);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Tarih : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(12, 116);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(139, 219);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "İşlem : ";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnOnayla);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 393);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(625, 100);
            this.groupIslemler.TabIndex = 27;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.clearheaderandfooter;
            this.btnKapat.Location = new System.Drawing.Point(512, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(101, 64);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.ImageOptions.SvgImage = global::CafeOtomasyonu.WinForms.Properties.Resources.bo_validation;
            this.btnOnayla.Location = new System.Drawing.Point(12, 31);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(135, 64);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(156, 82);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(450, 28);
            this.dateEdit1.TabIndex = 26;
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(156, 116);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(450, 219);
            this.txtIslem.TabIndex = 25;
            // 
            // frmMasaRezervasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 493);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.txtIslem);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmMasaRezervasyonu";
            this.Text = "Rezervasyon";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtIslem;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
    }
}