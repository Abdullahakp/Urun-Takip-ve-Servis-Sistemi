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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        void liste()
        {
            var lis = from listeler in dr.TBLFATURADETAY
                      select new
                      {
                          listeler.FATURADETAYID,
                          listeler.URUN,
                          listeler.ADET,
                          listeler.FIYAT,
                          listeler.TUTAR,
                          listeler.FATURAID,
                      };
            gridControl1.DataSource = lis.ToList();
        }
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY fr = new TBLFATURADETAY();
            fr.URUN = Txtürün.Text;
            fr.ADET = short.Parse(Txtadet.Text);
            fr.FIYAT=decimal.Parse(txtfiyat.Text);
            fr.TUTAR=decimal.Parse(Txttutar.Text);
            fr.FATURAID = int.Parse(Txtfaturaıd.Text);
            dr.TBLFATURADETAY.Add(fr);
            dr.SaveChanges();
            MessageBox.Show("Fatura Kalem Girişiniz Tamamlanmıştır","Fatura Kalem Girişi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse (gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
