using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITIRMEPROJESI.Formlar
{
    public partial class FrmUrunİstatisliği : Form
    {
        public FrmUrunİstatisliği()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        private void FrmUrunİstatisliği_Load(object sender, EventArgs e)
        {
            labelControl2.Text =db.TBLURUN.Count().ToString();
            labelControl17.Text=db.TBLKATEGORI.Count().ToString();
            labelControl26.Text=db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                 orderby x.STOK descending
                                 select x.AD).FirstOrDefault();
            labelControl19.Text= (from x in db.TBLURUN
                                  orderby x.STOK ascending
                                  select x.AD).FirstOrDefault();
            labelControl27.Text = (from x in db.TBLURUN
                                   orderby x.KATEGORI descending
                                   select x.AD).FirstOrDefault();
            labelControl35.Text= (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.AD).FirstOrDefault();
            labelControl43.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD ).FirstOrDefault();
            labelControl29.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            labelControl37.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl9.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl11.Text=(from x in db.TBLURUN
                                 select x.MARKA).Distinct().Count().ToString();
            labelControl32.Text = db.TBLURUNKABUL.Count().ToString();
            
        }
    }
}
