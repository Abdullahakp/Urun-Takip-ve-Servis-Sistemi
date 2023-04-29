using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BITIRMEPROJESI.Formlar
{
    public partial class FrmArizaliürünlis : Form
    {
        public FrmArizaliürünlis()
        {
            InitializeComponent();
        }

        /*private void labelControl10_Click(object sender, EventArgs e)
        {

        }*/

        /*private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }*/
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0H9IOOS\\SQLEXPRESS;Initial Catalog=BITIRMEPROJE;Integrated Security=True");

        BITIRMEPROJEEntities2 db = new BITIRMEPROJEEntities2();
        void liste()
        {
            var degerler = from x in db.TBLURUNKABUL
                        select new
                        {
                            x.ISLEMID,
                            CARI = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                            PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                            x.GELISTARIH,
                            x.CIKISTARIHI,
                            x.URUNSERINO
                        };
            gridControl1.DataSource= degerler.ToList();
            labelControl3.Text=db.TBLURUNKABUL.Count(X=>X.URUNDURUM== true).ToString();
            labelControl1.Text = db.TBLURUNKABUL.Count(X => X.URUNDURUM == false).ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl5.Text=db.TBLURUNKABUL.Count(x=>x.URUNDURUMDETAY=="Parça Bekliyor").ToString();
            labelControl15.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl17.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Durumunda").ToString();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY ", baglanti);
            SqlDataReader mr = komut.ExecuteReader();
            while (mr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(mr[0]), int.Parse(mr[1].ToString()));
            }
            baglanti.Close();

        }
        private void FrmArizaliürünlis_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylari fr = new FrmArizaDetaylari();
            fr.a = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.Show();
        }
    }
}
