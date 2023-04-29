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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLAR.Where(x=>x.DURUM==false).ToList();
            gridControl2.DataSource=db.TBLNOTLAR.Where(y=>y.DURUM==true).ToList();
        }

       /* private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text=gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtbaslik.Text=gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            Txticerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            
        }*/

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int id=int.Parse(TxtID.Text);
                var deger = db.TBLNOTLAR.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu  Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

       /* private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }*/

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
