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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2(); 
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text=gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtkategori.Text=gridView1.GetFocusedRowCellValue("AD").ToString();
        }
        void liste()
        {
            var deger = from t in db.TBLKATEGORI
                        select new
                        {
                            t.ID,
                            t.AD
                        };
            gridControl1.DataSource= deger.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            liste();
        }

       /* private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Silindi", "Bilgi Mesajjı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }*/

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int di = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(di);
            deger.AD = Txtkategori.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            liste();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        /* private void simpleButton1_Click(object sender, EventArgs e)
         {
             TBLKATEGORI t = new TBLKATEGORI();
             t.AD = Txtkategori.Text;
             db.TBLKATEGORI.Add(t);
             db.SaveChanges();
             MessageBox.Show("Ürün Kaydı Gerçekleştirildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }*/
    }
}
