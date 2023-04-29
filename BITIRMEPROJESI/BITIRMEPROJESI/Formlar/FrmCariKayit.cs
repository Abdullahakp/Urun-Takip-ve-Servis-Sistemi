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
    public partial class FrmCariKayit : Form
    {
        public FrmCariKayit()
        {
            InitializeComponent();
        }
        int secilen;
        BITIRMEPROJEEntities2 dr = new BITIRMEPROJEEntities2();
        private void FrmCariKayit_Load(object sender, EventArgs e)
        {
            lookIL.Properties.DataSource = (from x in dr.iller
                                            select new
                                            {
                                                x.id,
                                                x.sehir
                                            }).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = Txtad.Text;
            t.SOYAD = Txtsoyad.Text;
            t.TELEFON = Txttelefon.Text;
            t.MAIL = Txtmail.Text;
            t.IL = lookIL.EditValue.ToString();
            t.ILCE = lookUpEdit1.EditValue.ToString();
            t.BANKA = Txtbanka.Text;
            t.VERGIDAIRE = Txtvergida.Text;
            t.VERGINO = Txtno.Text;
            t.STATU = Txtstatü.Text;
            t.ADRES = TxtAdres.Text;
            dr.TBLCARI.Add(t);
            dr.SaveChanges();
            MessageBox.Show("Cari Kaydı Yapıldı", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookIL_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookIL.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from x in dr.ilceler
                                                 select new
                                                 {
                                                     x.id,
                                                     x.ilce,
                                                     x.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();
        }
    }
}
