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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JQAH0V9;Initial Catalog=BITIRMEPROJE;Integrated Security=True");
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        private void FrmMarka_Load(object sender, EventArgs e)
        {
            var degerler=db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y=>y.MARKA).
                Select(z=> new
                {
                    Marka=z.Key,
                    Toplam=z.Count()
                });
            gridControl1.DataSource=degerler.ToList();
            labelControl7.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl1.Text = db.TBLURUN.Count().ToString();
            labelControl5.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA ", baglanti);
            SqlDataReader mr = komut.ExecuteReader();
            while (mr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(mr[0]), int.Parse(mr[1].ToString()));
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select TBLKATEGORI.AD,COUNT(*)  from  TBLURUN  Inner Join TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI group by TBLKATEGORI.AD ", baglanti);
            SqlDataReader mr1 = komut1.ExecuteReader();
            while (mr1.Read())
            {
                chartControl2.Series["KATEGORI"].Points.AddPoint(Convert.ToString(mr1[0]), int.Parse(mr1[1].ToString()));
            }
            baglanti.Close();
            chartControl1.Series["Series 1"].Points.AddPoint("SIEMENS",4);
            chartControl1.Series["Series 1"].Points.AddPoint("ARCELIK",2);
            chartControl1.Series["Series 1"].Points.AddPoint("LG",1);
            chartControl1.Series["Series 1"].Points.AddPoint("Lenovo",1);
            chartControl1.Series["Series 1"].Points.AddPoint("MONSTER",1);
            chartControl1.Series["Series 1"].Points.AddPoint("ACER",1);
            chartControl1.Series["Series 1"].Points.AddPoint("CASPER",1);
            chartControl1.Series["Series 1"].Points.AddPoint("EVEREST",1);

            chartControl2.Series["KATEGORI"].Points.AddPoint("BEYAZ ESYA",3);
            chartControl2.Series["KATEGORI"].Points.AddPoint("BILGISAYAR",5);
            chartControl2.Series["KATEGORI"].Points.AddPoint("KUCUK EV ALETLERI",3);
            chartControl2.Series["KATEGORI"].Points.AddPoint("BILGISAYAR PAR",1);
            chartControl2.Series["KATEGORI"].Points.AddPoint("KULAKLIK",1);
            chartControl2.Series["KATEGORI"].Points.AddPoint("USB BELLEK",1);
        }
    }
}
