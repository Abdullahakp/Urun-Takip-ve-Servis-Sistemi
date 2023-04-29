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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        
        BITIRMEPROJEEntities2 db = new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL r=new TBLURUNKABUL();
            r.CARI = int.Parse(Lookkategori.EditValue.ToString());
            r.PERSONEL = short.Parse(lookUpEdit1.EditValue.ToString());
            r.GELISTARIH = DateTime.Parse(Txttarih.Text);
            r.URUNSERINO=Txtseri.Text;
            r.URUNDURUMDETAY ="Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(r);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Yapıldı","Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            Lookkategori.Properties.DataSource = (from x in db.TBLCARI
                                                  select new
                                                  {
                                                      x.ID,
                                                     AD= x.AD + " " + x.SOYAD
                                                  }).ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLPERSONEL
                                                  select new
                                                  {
                                                      x.ID,
                                                      AD = x.AD + " " + x.SOYAD
                                                  }).ToList();
        }

        private void Lookkategori_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Txttarih_Click(object sender, EventArgs e)
        {
            Txttarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
