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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 dr=new BITIRMEPROJEEntities2();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in dr.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.MARKA,
                                           x.STOK
                                       }).Where(y => y.STOK < 50).ToList();
            gridControl4.DataSource= (from x in dr.TBLCARI
                                      select new
                                      {
                                          x.AD,
                                          x.SOYAD,
                                          x.IL
                                      }).ToList();
            gridControl2.DataSource = dr.urunkategori().ToList();

            DateTime bugün = DateTime.Today;
            var deger = (from x in dr.TBLNOTLAR.OrderBy(y => y.TARIH)
                         where (x.TARIH == bugün)
                         select new { x.TARIH, x.ICERIK });
            gridControl3.DataSource = deger.ToList();

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5, konu6, ad6, konu7, ad7, konu8, ad8, konu9, ad9, konu10, ad10;
            konu1 = dr.TBLILETISIM.First(x => x.ID==1).KONU;
            ad1 = dr.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            label1.Text = konu1 + "---" + ad1;
            konu2 = dr.TBLILETISIM.First(x => x.ID == 2).KONU;
            ad2 = dr.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            label2.Text = konu2 + "---" + ad2;
            konu3 = dr.TBLILETISIM.First(x => x.ID == 3).KONU;
            ad3 = dr.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            label4.Text = konu3 + "---" + ad3;
            konu4 = dr.TBLILETISIM.First(x => x.ID == 4).KONU;
            ad4 = dr.TBLILETISIM.First(x => x.ID == 4).ADSOYAD;
            label3.Text = konu4 + "---" + ad4;
            konu5 = dr.TBLILETISIM.First(x => x.ID ==5).KONU;
            ad5 = dr.TBLILETISIM.First(x => x.ID == 5).ADSOYAD;
            label9.Text = konu5 + "---" + ad5;
            konu6 = dr.TBLILETISIM.First(x => x.ID ==6).KONU;
            ad6 = dr.TBLILETISIM.First(x => x.ID == 6).ADSOYAD;
            label8.Text = konu6 + "---" + ad6;
            konu7 = dr.TBLILETISIM.First(x => x.ID ==7).KONU;
            ad7 = dr.TBLILETISIM.First(x => x.ID == 7).ADSOYAD;
            label6.Text = konu7 + "---" + ad7;
            konu8 = dr.TBLILETISIM.First(x => x.ID == 8).KONU;
            ad8 = dr.TBLILETISIM.First(x => x.ID == 8).ADSOYAD;
            label5.Text = konu8 + "---" + ad8;
            konu9 = dr.TBLILETISIM.First(x => x.ID ==9).KONU;
            ad9 = dr.TBLILETISIM.First(x => x.ID == 9).ADSOYAD;
            label11.Text = konu9 + "---" + ad9;
            konu10 = dr.TBLILETISIM.First(x => x.ID == 10).KONU;
            ad10 = dr.TBLILETISIM.First(x => x.ID == 10).ADSOYAD;
            label10.Text = konu10 + "---" + ad10;

        }

       
    }
}
