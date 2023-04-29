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
    public partial class FrmKategoriSil : Form
    {
        public FrmKategoriSil()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr = new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txtad.Text);
            var deger = dr.TBLKATEGORI.Find(id);
            dr.TBLKATEGORI.Remove(deger);
            dr.SaveChanges();
            MessageBox.Show("Ürün Kaydı Silindi", "Bilgi Mesajjı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
