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
    public partial class FrmYenisatisislemi : Form
    {
        public FrmYenisatisislemi()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t=new TBLURUNHAREKET();
            t.URUN = int.Parse(lookIL.EditValue.ToString());
            t.MUSTERI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.TARIH = DateTime.Parse(Txttarih.Text);
            t.ADET=short.Parse(Txtadet.Text);
            t.FIYAT = decimal.Parse(Txtsatis.Text);
            t.URUNSERINO=TxtSeri.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Tamamlandı","Bilgi Fişi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void FrmYenisatisislemi_Load(object sender, EventArgs e)
        {
            lookIL.Properties.DataSource = (from x in db.TBLURUN
                                            select new
                                            {
                                                x.ID,
                                                x.AD
                                            }).ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                            select new
                                            {
                                                x.ID,
                                                AD=x.AD+" "+x.SOYAD
                                            }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                            select new
                                            {
                                                x.ID,
                                                AD = x.AD + " " + x.SOYAD
                                            }).ToList();
        

    }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }

        
    
}
