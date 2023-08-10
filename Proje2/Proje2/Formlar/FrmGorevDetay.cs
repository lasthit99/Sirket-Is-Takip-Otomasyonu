using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje2.Entity;

namespace Proje2.Formlar
{
    public partial class FrmGorevDetay : Form
    {
        public FrmGorevDetay()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmGorevDetay_Load(object sender, EventArgs e)
        {
            db.TblGorevDetaylar.Load();
            bindingSource1.DataSource = db.TblGorevDetaylar.Local;
    
        }
        //ContextMenuStrip Sağ tuş menüsü hazırlayan araç.

        //F4 özellikleri açar.

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üzerinde aktif olarak çalıştığımız satırı siler.
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
