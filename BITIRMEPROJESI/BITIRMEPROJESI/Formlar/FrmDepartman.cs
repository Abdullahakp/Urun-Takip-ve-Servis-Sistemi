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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
         
       BITIRMEPROJEEntities2 DB=new BITIRMEPROJEEntities2();
       void liste()
        {
            var deger = from x in DB.TBLDEPARTMAN
                        select new
                        {
                            x.ID,
                            x.AD
                            //x.AÇIKLAMA
                        };
            gridControl1.DataSource = deger.ToList();
                
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            liste();
            labelControl13.Text=DB.TBLDEPARTMAN.Count().ToString();
            labelControl15.Text=DB.TBLPERSONEL.Count().ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            TBLDEPARTMAN dr=new TBLDEPARTMAN();
            if (Txtad.Text.Length <= 50 && Txtad.Text != "" )
            {

                dr.AD = Txtad.Text;
                //dr.AÇIKLAMA = rickaciklama.Text;
                DB.TBLDEPARTMAN.Add(dr);
                DB.SaveChanges();
                MessageBox.Show("Kayıt Yapıldı", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtID.Text);
            var deger=DB.TBLDEPARTMAN.Find(id);
            DB.TBLDEPARTMAN.Remove(deger);
            DB.SaveChanges();
            MessageBox.Show("Departman Silindi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtID.Text);
            var deger = DB.TBLDEPARTMAN.Find(a);
            deger.AD=Txtad.Text;
            DB.SaveChanges();
            MessageBox.Show("Departman Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

  
    }
