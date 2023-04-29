using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITIRMEPROJESI.İletisim
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        void liste()
        {
            var deger = from i in dr.TBLCARI
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
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
