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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Txtfaturaıd.Text);

            var degerler = (from u in dr.TBLFATURADETAY.Where(x => x.FATURAID == id && x.TBLFATURABILGI.SERI == Txtseri.Text && x.TBLFATURABILGI.SIRANO == Txtsira.Text)

                            select new

                            {

                                SERİ = u.TBLFATURABILGI.SERI,

                                SIRA = u.TBLFATURABILGI.SIRANO,

                                u.FATURADETAYID,

                                u.URUN,

                                u.ADET,

                                u.FIYAT,

                                u.TUTAR,

                                u.FATURAID,

                            }).ToList();

            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmFaturaKalemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
