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
    public partial class FrmYeniDepartman : Form    
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 DB=new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN dr=new TBLDEPARTMAN();

            if (Txtad.Text.Length <= 50 && Txtad.Text != "")
            {

                dr.AD = Txtad.Text;
                DB.TBLDEPARTMAN.Add(dr);
                DB.SaveChanges();
                MessageBox.Show("Kayıt Yapıldı", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
