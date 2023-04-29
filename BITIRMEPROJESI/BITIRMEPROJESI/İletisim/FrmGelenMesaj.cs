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
    public partial class FrmGelenMesaj : Form
    {
        public FrmGelenMesaj()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr = new BITIRMEPROJEEntities2();
        void liste()
        {
            var deger = from i in dr.TBLILETISIM
                        select new
                        {
                            i.ID,
                            i.ADSOYAD,
                            i.KONU,
                            i.MAIL,
                            i.MESAJ
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmGelenMesaj_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
