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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi ürün;
        private void BTNurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ürün == null || gf.IsDisposed)
            {
                ürün= new Formlar.FrmUrunListesi();
                ürün.MdiParent = this;
                ürün.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmKategori kat;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kat == null || gf.IsDisposed)
            {
                kat = new Formlar.FrmKategori();
                kat.MdiParent = this;
                kat.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmUrunİstatisliği ürünlis;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ürünlis == null || gf.IsDisposed)
            {
                ürünlis= new Formlar.FrmUrunİstatisliği();
                ürünlis.MdiParent = this;
                ürünlis.Show();
            }
        }
        Formlar.FrmMarka mar;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mar == null || gf.IsDisposed)
            {
                mar = new Formlar.FrmMarka();
                mar.MdiParent = this;
                mar.Show();
            }
        }
        Formlar.FrmCariler cari;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cari == null || gf.IsDisposed)
            {
                cari = new Formlar.FrmCariler();
                cari.MdiParent = this;
                cari.Show();
            }
        }
        Formlar.FrmCariIl cariil;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cariil == null || gf.IsDisposed)
            {
                cariil= new Formlar.FrmCariIl();
                cariil.MdiParent = this;
                cariil.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariKayit gs=new Formlar.FrmCariKayit();
            gs.Show();
        }
        Formlar.FrmDepartman dep;
        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dep == null || gf.IsDisposed)
            {
                dep= new Formlar.FrmDepartman();
                dep.MdiParent = this;
                dep.Show();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman gs = new Formlar.FrmYeniDepartman();
            gs.Show();
        }
        Formlar.FrmPersoneller per;
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (per == null || gf.IsDisposed)
            {
                per= new Formlar.FrmPersoneller();
                per.MdiParent = this;
                per.Show();
            }
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar kür;
        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kür == null || gf.IsDisposed)
            {
                kür = new Formlar.FrmKurlar();
                kür.MdiParent = this;
                kür.Show();
            }
        }
        Formlar.FrmNotlar nt;
        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nt == null || gf.IsDisposed)
            {
                nt = new Formlar.FrmNotlar();
                nt.MdiParent = this;
                nt.Show();
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmArizaliürünlis al;
        private void BtnArizaliürün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (al == null || gf.IsDisposed)
            {
                al= new Formlar.FrmArizaliürünlis();
                al.MdiParent = this;
                al.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYenisatisislemi td = new Formlar.FrmYenisatisislemi();
            //td.MdiParent = this;
            td.Show();
        }
        Formlar.FrmSatısListesi st;
        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (st == null || gf.IsDisposed)
            {
                st = new Formlar.FrmSatısListesi();
                st.MdiParent = this;
                st.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi td = new Formlar.FrmArizaliUrunKaydi();
            //td.MdiParent = this;
            td.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetaylari td = new Formlar.FrmArizaDetaylari();
            //td.MdiParent = this;
            td.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmQrKod td = new Formlar.FrmQrKod();
            //td.MdiParent = this;
            td.Show();
        }
        Formlar.FrmFaturaListesi fr;
        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || gf.IsDisposed)
            {
                fr = new Formlar.FrmFaturaListesi();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Formlar.FrmFaturaKalem rd;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rd == null || gf.IsDisposed)
            {
                rd = new Formlar.FrmFaturaKalem();
                rd.MdiParent = this;
                rd.Show();
            }
        }
       
        private void Pasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri gf=new   Formlar.FrmFaturaKalemleri();
            gf.MdiParent= this;
            gf.Show();
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmrRaporlar dr = new Formlar.FrmrRaporlar();
            dr.Show();
        }
        Formlar.FrmAnaSayfa gf;
        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gf == null || gf.IsDisposed)
            {
                gf = new Formlar.FrmAnaSayfa();
                gf.MdiParent = this;
                gf.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (gf == null || gf.IsDisposed)
            {
                gf = new Formlar.FrmAnaSayfa();
                gf.MdiParent = this;
                gf.Show();
            }
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriSil dr = new Formlar.FrmKategoriSil();
            dr.Show();
        }
        Formlar.FrmURUNTAKİP kl;
        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kl == null || gf.IsDisposed)
            {
                kl = new Formlar.FrmURUNTAKİP();
                kl.MdiParent = this;
                kl.Show();
            }
        }
        İletisim.FrmRehber reh;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reh == null || gf.IsDisposed)
            {
                reh = new İletisim.FrmRehber();
                reh.MdiParent = this;
                reh.Show();
            }
        }
        İletisim.FrmGelenMesaj gel;
        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gel == null || gf.IsDisposed)
            {
                gel = new İletisim.FrmGelenMesaj();
                gel.MdiParent = this;
                gel.Show();
            }
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İletisim.FrmMail nr=new İletisim.FrmMail();
            nr.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("metin");
        }
    }
}
