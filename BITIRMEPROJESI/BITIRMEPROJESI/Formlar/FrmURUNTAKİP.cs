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
    public partial class FrmURUNTAKİP : Form
    {
        public FrmURUNTAKİP()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr = new BITIRMEPROJEEntities2();
        private void FrmURUNTAKİP_Load(object sender, EventArgs e)
        {
            var deger = from x in dr.TBLURUNTAKIP
                        select new
                        {
                            x.TAKIPID,
                            x.SERINO,
                            x.TARIH,
                            x.ACIKLAMA
                            //x.AÇIKLAMA
                        };
            gridControl1.DataSource = deger.ToList();
        }
    }
}
