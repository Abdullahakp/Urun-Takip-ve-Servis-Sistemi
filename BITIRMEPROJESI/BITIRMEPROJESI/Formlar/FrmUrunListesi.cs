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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db = new BITIRMEPROJEEntities2();
        void liste()
        {
            var deger = from u in db.TBLURUN
                        select new
                        {
                            u.ID,
                            u.AD,
                            u.MARKA,
                            Kategori = u.TBLKATEGORI.AD,
                            u.ALISFIYAT,
                            u.SATISFIYAT,
                            u.STOK
                        };
               gridControl1.DataSource = deger.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            liste();
            Lookkategori.Properties.DataSource= (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t=new TBLURUN();
            t.AD = Txtürünad.Text;
            t.MARKA=Txtmarka.Text;
            t.ALISFIYAT = decimal.Parse(Txtalis.Text);
            t.SATISFIYAT=decimal.Parse(Txtsatis.Text);
            t.DURUM = false;
            t.STOK = short.Parse(Txtstok.Text);
            t.KATEGORI =byte.Parse( Lookkategori.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Gerçekleştirildi","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var dc = db.TBLURUN.ToList();
            gridControl1.DataSource=dc;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text=gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtürünad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            Txtmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            Txtalis.Text=gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            Txtsatis.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            Txtstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
           //Lookkategori.Text= gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Silindi","Bilgi Mesajjı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int di =int.Parse( TxtID.Text);
            var deger = db.TBLURUN.Find(di);
            deger.AD = Txtürünad.Text;
            deger.MARKA=Txtmarka.Text;
            deger.ALISFIYAT = decimal.Parse(Txtalis.Text);
            deger.SATISFIYAT=decimal.Parse(Txtsatis.Text);
            deger.STOK=short.Parse(Txtstok.Text);
            deger.KATEGORI = byte.Parse(Lookkategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Güncellendi","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }
    }
}
