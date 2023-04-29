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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        void liste()
        {
            var deger = from x in dr.TBLFATURABILGI
                        select new
                        {
                            x.ID,
                            x.SERI,
                            x.SIRANO,
                            x.TARIH,
                            x.SAAT,
                            x.VERGIDAIRE,
                            CARI = x.TBLCARI.AD,
                            PERSONEL = x.TBLPERSONEL.AD
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            liste();
            Lookcari.Properties.DataSource = (from c in dr.TBLCARI
                                                  select new
                                                  {
                                                      c.ID,
                                                      AD = c.AD +" "+ c.SOYAD
                                                  }).ToList();
            Lookpersonel.Properties.DataSource = (from c in dr.TBLPERSONEL
                                                  select new
                                                  {
                                                      c.ID,
                                                      AD = c.AD + " " + c.SOYAD
                                                  }).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI df=new TBLFATURABILGI();
            //df.ID =int.Parse( TxtId.Text);
            df.SERI=Txtseri.Text;
            df.SIRANO=Txtsira.Text;
            df.TARIH = Convert.ToDateTime(txttarih.Text);
            df.SAAT = Txtsaat.Text;
            df.VERGIDAIRE=Txtvergi.Text;
            df.CARI=int.Parse(Lookcari.EditValue.ToString());
            df.PERSONEL=short.Parse(Lookpersonel.EditValue.ToString());
            dr.TBLFATURABILGI.Add(df);
            dr.SaveChanges();
            MessageBox.Show("Fatura Girişi Yapılmıştır","Bilgi Mesajı");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void FrmFaturaListesi_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
