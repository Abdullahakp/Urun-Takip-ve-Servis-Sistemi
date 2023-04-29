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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        void liste()
        {
            var deger = from i in db.TBLPERSONEL
                        select new
                        {
                            i.ID,
                            i.AD,
                            i.SOYAD,
                            i.MAIL,
                            i.TELEFON
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            liste();

            lookIL.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                            select new
                                            {
                                                x.ID,
                                                x.AD
                                            }).ToList();

            string ad, soyad;
            //1.personel
            ad = db.TBLPERSONEL.First(x => x.ID==1).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl27.Text = ad+ " "+soyad;
            labelControl25.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl15.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            //2.Personel
            ad = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl13.Text = ad + " " + soyad;
            labelControl21.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl23.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;

            //3.Personel
            ad = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl31.Text = ad + " " + soyad;
            labelControl29.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl19.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;

            //4.Personel
            ad = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl35.Text = ad + " " + soyad;
            labelControl33.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;

            //5.Personel
            ad = db.TBLPERSONEL.First(x => x.ID == 5).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 5).SOYAD;
            labelControl12.Text = ad + " " + soyad;
            labelControl8.Text = db.TBLPERSONEL.First(x => x.ID == 5).TBLDEPARTMAN.AD;
            labelControl4.Text = db.TBLPERSONEL.First(x => x.ID == 5).MAIL;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = Txtcariad.Text;
            t.SOYAD = textBox4.Text;
            t.MAIL = TxtMAIL.Text;
            t.TELEFON =maskedTextBox1.Text;
            t.DEPARTMAN = byte.Parse(lookIL.EditValue.ToString());
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Kaydı Gerçekleştirildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Kaydı Silindi", "Bilgi Mesajjı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int di = int.Parse(TxtID.Text);
            var deger = db.TBLPERSONEL.Find(di);
            deger.AD = Txtcariad.Text;
            deger.SOYAD = textBox4.Text;
            deger.MAIL = TxtMAIL.Text;
            deger.TELEFON = maskedTextBox1.Text;
            deger.DEPARTMAN = byte.Parse(lookIL.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
