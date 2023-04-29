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
    public partial class FrmArizaDetaylari : Form
    {
        public FrmArizaDetaylari()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP tr=new TBLURUNTAKIP();
            tr.SERINO=textEdit1.Text;
            tr.TARIH  =DateTime.Parse(textEdit2.Text);
            tr.ACIKLAMA = richTextBox1.Text;
            dr.TBLURUNTAKIP.Add(tr);
            dr.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayı Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }
        public string a;    
        private void FrmArizaDetaylari_Load(object sender, EventArgs e)
        {
            textEdit1.Text = a;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
