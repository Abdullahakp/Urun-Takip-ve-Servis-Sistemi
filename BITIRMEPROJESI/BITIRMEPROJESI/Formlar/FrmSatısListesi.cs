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
    public partial class FrmSatısListesi : Form
    {
        public FrmSatısListesi()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        void liste()
        {
            var degerler = from x in db.TBLURUNHAREKET
                           select new
                           {
                               x.HAREKETID,
                               URUN=x.TBLURUN.AD,
                               MUSTERI=x.TBLCARI.AD+x.TBLCARI.SOYAD,
                               PERSONEL=x.TBLPERSONEL.AD+ x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO                           
                           };
            gridControl1.DataSource= degerler.ToList();
        }
        private void FrmSatısListesi_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
