﻿namespace Proje2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAnaForm = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDepartmanListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonelListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonelİstatistik = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGorevListesi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGorevTanimla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGorevDetay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem22 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem23 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAktifCagrilar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPasifCagrilar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAnaForm,
            this.BtnDepartmanListesi,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.BtnPersonelListesi,
            this.barButtonItem7,
            this.BtnPersonelİstatistik,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.BtnGorevListesi,
            this.BtnGorevTanimla,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.BtnGorevDetay,
            this.barButtonItem17,
            this.barButtonItem18,
            this.barButtonItem19,
            this.barButtonItem20,
            this.barButtonItem21,
            this.barButtonItem22,
            this.barButtonItem23,
            this.barButtonItem24,
            this.BtnAktifCagrilar,
            this.BtnPasifCagrilar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 28;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage5,
            this.ribbonPage8});
            this.ribbonControl1.Size = new System.Drawing.Size(1200, 183);
            // 
            // BtnAnaForm
            // 
            this.BtnAnaForm.Caption = "Ana Sayfa";
            this.BtnAnaForm.Id = 1;
            this.BtnAnaForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaForm.ImageOptions.Image")));
            this.BtnAnaForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnaForm.ImageOptions.LargeImage")));
            this.BtnAnaForm.Name = "BtnAnaForm";
            this.BtnAnaForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaForm_ItemClick);
            // 
            // BtnDepartmanListesi
            // 
            this.BtnDepartmanListesi.Caption = "Departman Listesi";
            this.BtnDepartmanListesi.Id = 2;
            this.BtnDepartmanListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanListesi.ImageOptions.Image")));
            this.BtnDepartmanListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanListesi.ImageOptions.LargeImage")));
            this.BtnDepartmanListesi.Name = "BtnDepartmanListesi";
            this.BtnDepartmanListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDepartmanListesi_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Yeni Departman";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Departman İstatistikleri";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Departman Raporları";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // BtnPersonelListesi
            // 
            this.BtnPersonelListesi.Caption = "Personel Listesi";
            this.BtnPersonelListesi.Id = 6;
            this.BtnPersonelListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.ImageOptions.Image")));
            this.BtnPersonelListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.ImageOptions.LargeImage")));
            this.BtnPersonelListesi.Name = "BtnPersonelListesi";
            this.BtnPersonelListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonelListesi_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Yeni Personel Ekle";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // BtnPersonelİstatistik
            // 
            this.BtnPersonelİstatistik.Caption = "Personel İstatistikleri";
            this.BtnPersonelİstatistik.Id = 8;
            this.BtnPersonelİstatistik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelİstatistik.ImageOptions.Image")));
            this.BtnPersonelİstatistik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelİstatistik.ImageOptions.LargeImage")));
            this.BtnPersonelİstatistik.Name = "BtnPersonelİstatistik";
            this.BtnPersonelİstatistik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonelİstatistik_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Firma Listesi";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Yeni Firma Ekle";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Firma İstatistikleri";
            this.barButtonItem10.Id = 11;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // BtnGorevListesi
            // 
            this.BtnGorevListesi.Caption = "Görev Listesi";
            this.BtnGorevListesi.Id = 12;
            this.BtnGorevListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevListesi.ImageOptions.Image")));
            this.BtnGorevListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGorevListesi.ImageOptions.LargeImage")));
            this.BtnGorevListesi.Name = "BtnGorevListesi";
            this.BtnGorevListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGorevListesi_ItemClick);
            // 
            // BtnGorevTanimla
            // 
            this.BtnGorevTanimla.Caption = "Yeni Görev Tanımla";
            this.BtnGorevTanimla.Id = 13;
            this.BtnGorevTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimla.ImageOptions.Image")));
            this.BtnGorevTanimla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGorevTanimla.ImageOptions.LargeImage")));
            this.BtnGorevTanimla.Name = "BtnGorevTanimla";
            this.BtnGorevTanimla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGorevTanimla_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Aktif Görevler";
            this.barButtonItem13.Id = 14;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Tamamlanan Görevler";
            this.barButtonItem14.Id = 15;
            this.barButtonItem14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.Image")));
            this.barButtonItem14.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.LargeImage")));
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Görev İstatistikleri";
            this.barButtonItem15.Id = 16;
            this.barButtonItem15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.Image")));
            this.barButtonItem15.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.LargeImage")));
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // BtnGorevDetay
            // 
            this.BtnGorevDetay.Caption = "Görev Detayları";
            this.BtnGorevDetay.Id = 17;
            this.BtnGorevDetay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGorevDetay.ImageOptions.Image")));
            this.BtnGorevDetay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGorevDetay.ImageOptions.LargeImage")));
            this.BtnGorevDetay.Name = "BtnGorevDetay";
            this.BtnGorevDetay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGorevDetay_ItemClick);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Hesap Makinesi";
            this.barButtonItem17.Id = 18;
            this.barButtonItem17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.ImageOptions.Image")));
            this.barButtonItem17.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.ImageOptions.LargeImage")));
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Youtube";
            this.barButtonItem18.Id = 19;
            this.barButtonItem18.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.ImageOptions.Image")));
            this.barButtonItem18.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.ImageOptions.LargeImage")));
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Haberler";
            this.barButtonItem19.Id = 20;
            this.barButtonItem19.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem19.ImageOptions.Image")));
            this.barButtonItem19.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem19.ImageOptions.LargeImage")));
            this.barButtonItem19.Name = "barButtonItem19";
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Kurlar";
            this.barButtonItem20.Id = 21;
            this.barButtonItem20.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem20.ImageOptions.Image")));
            this.barButtonItem20.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem20.ImageOptions.LargeImage")));
            this.barButtonItem20.Name = "barButtonItem20";
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Haritalar";
            this.barButtonItem21.Id = 22;
            this.barButtonItem21.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.ImageOptions.Image")));
            this.barButtonItem21.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.ImageOptions.LargeImage")));
            this.barButtonItem21.Name = "barButtonItem21";
            // 
            // barButtonItem22
            // 
            this.barButtonItem22.Caption = "Şifre İşlemleri";
            this.barButtonItem22.Id = 23;
            this.barButtonItem22.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.ImageOptions.Image")));
            this.barButtonItem22.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.ImageOptions.LargeImage")));
            this.barButtonItem22.Name = "barButtonItem22";
            // 
            // barButtonItem23
            // 
            this.barButtonItem23.Caption = "Yetkilendirmeler";
            this.barButtonItem23.Id = 24;
            this.barButtonItem23.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem23.ImageOptions.Image")));
            this.barButtonItem23.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem23.ImageOptions.LargeImage")));
            this.barButtonItem23.Name = "barButtonItem23";
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Caption = "Rapor Sihirbazı";
            this.barButtonItem24.Id = 25;
            this.barButtonItem24.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem24.ImageOptions.Image")));
            this.barButtonItem24.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem24.ImageOptions.LargeImage")));
            this.barButtonItem24.Name = "barButtonItem24";
            // 
            // BtnAktifCagrilar
            // 
            this.BtnAktifCagrilar.Caption = "Aktif Çağrılar";
            this.BtnAktifCagrilar.Id = 26;
            this.BtnAktifCagrilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAktifCagrilar.ImageOptions.Image")));
            this.BtnAktifCagrilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAktifCagrilar.ImageOptions.LargeImage")));
            this.BtnAktifCagrilar.Name = "BtnAktifCagrilar";
            this.BtnAktifCagrilar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktifCagrilar_ItemClick);
            // 
            // BtnPasifCagrilar
            // 
            this.BtnPasifCagrilar.Caption = "Pasif Çağrılar";
            this.BtnPasifCagrilar.Id = 27;
            this.BtnPasifCagrilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasifCagrilar.ImageOptions.Image")));
            this.BtnPasifCagrilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPasifCagrilar.ImageOptions.LargeImage")));
            this.BtnPasifCagrilar.Name = "BtnPasifCagrilar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnaForm);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Departmanlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDepartmanListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Personeller";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnPersonelListesi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnPersonelİstatistik);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup10});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Görevler";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.BtnGorevListesi);
            this.ribbonPageGroup8.ItemLinks.Add(this.BtnGorevTanimla);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.BtnGorevDetay);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup14});
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "Çağrılar";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.BtnAktifCagrilar);
            this.ribbonPageGroup14.ItemLinks.Add(this.BtnPasifCagrilar);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAnaForm;
        private DevExpress.XtraBars.BarButtonItem BtnDepartmanListesi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnPersonelListesi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem BtnPersonelİstatistik;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem BtnGorevListesi;
        private DevExpress.XtraBars.BarButtonItem BtnGorevTanimla;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem BtnGorevDetay;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.BarButtonItem barButtonItem20;
        private DevExpress.XtraBars.BarButtonItem barButtonItem21;
        private DevExpress.XtraBars.BarButtonItem barButtonItem22;
        private DevExpress.XtraBars.BarButtonItem barButtonItem23;
        private DevExpress.XtraBars.BarButtonItem barButtonItem24;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnAktifCagrilar;
        private DevExpress.XtraBars.BarButtonItem BtnPasifCagrilar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
    }
}

