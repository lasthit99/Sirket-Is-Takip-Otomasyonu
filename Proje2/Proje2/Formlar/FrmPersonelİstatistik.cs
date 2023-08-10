using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje2.Entity;

namespace Proje2.Formlar
{
    public partial class FrmPersonelİstatistik : Form
    {
        public FrmPersonelİstatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmPersonelİstatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            LblAktifis.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            LblPasifis.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            LblSonGorev.Text = db.TblGorevler.OrderByDescending(x=>x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblSonGörevDetay.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            //Distinct ile her bir iş yalnız 1 kere çalışacak.
            LblSehirSayisi.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            LblSektor.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            LblBugunAcilanGorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            //En fazla görev alan personel ayın personeli olur.
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending
                (z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblAyinPersoneli.Text = db.TblPersonel.Where(x => x.ID == d1).Select(y => y.Ad + " " +  y.Soyad).FirstOrDefault().ToString();
            LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel.Where
            (t=>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
        }

        private void labelControl20_Click(object sender, EventArgs e)
        {
            //Ayın departmanındaki 0.
        }

        private void LblSonGörevDetay_Click(object sender, EventArgs e)
        {

        }
    }
}
