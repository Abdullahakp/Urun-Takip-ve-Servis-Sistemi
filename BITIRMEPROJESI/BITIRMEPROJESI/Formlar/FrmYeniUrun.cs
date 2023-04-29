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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            Lookkategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLURUN t=new TBLURUN();
            t.AD = TxtURUN.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlis.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatis.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(Lookkategori.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Gerçekleştirildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtURUN_Click(object sender, EventArgs e)
        {
            TxtURUN.Text = "";
            TxtURUN.Focus();
        }
    }
}
