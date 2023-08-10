using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar frm = new Formlar.FrmDepartmanlar();
            //frm.Show(); //Dersem direk açılır mdi'in içinde açılsın istiyoruz.
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelİstatistik frm3 = new Formlar.FrmPersonelİstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Görevler listesine bir kez daha tıklayınca yeni sekme açmasını kontrol ediyoruz.
            //isDisposed ise formu kapattıysak tekrar açmayı sağlıyor.
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }

        }

        private void BtnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr = new Formlar.FrmGorevDetay();
            fr.Show();
        }

        Formlar.FrmAnaForm frm5;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.FrmAnaForm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Formlar.FrmAktifCagrilar fr;
        private void BtnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
