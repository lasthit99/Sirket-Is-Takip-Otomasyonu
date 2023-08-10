using DevExpress.XtraEditors;
using Proje2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2.PersonelGorevFormlari
{
    public partial class FrmCagriDetayGiris : Form
    {
        public FrmCagriDetayGiris()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        public int id;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGiris_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagriID.Text);
            t.Saat = TxtSaat.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.Aciklama = TxtAciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi.");
        }
    }
}
