using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITIRMEPROJESI
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
        BITIRMEPROJEEntities2 br = new BITIRMEPROJEEntities2();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in br.TBLADMIN where x.KULLANICIAD == textEdit1.Text && x.SIFRE == textEdit2.Text select x;
            if(sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Şifre");
            }
        }
    }
}
