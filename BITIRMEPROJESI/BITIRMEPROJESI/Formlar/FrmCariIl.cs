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
    public partial class FrmCariIl : Form
    {
        public FrmCariIl()
        {
            InitializeComponent();
        }
        BITIRMEPROJEEntities2 DB=new BITIRMEPROJEEntities2();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JQAH0V9;Initial Catalog=BITIRMEPROJE;Integrated Security=True");
        private void chartControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCariIl_Load(object sender, EventArgs e)
        {
            /*chartControl1.Series["Series 1"].Points.AddPoint("Gaziantep",14);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul",10);
            chartControl1.Series["Series 1"].Points.AddPoint("Ankara",8);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir",12);*/

            gridControl1.DataSource = DB.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new {IL=z.Key,TOPLAM=z.Count()}).ToList();

            baglanti.Open();
            SqlCommand komut=new SqlCommand("select IL,Count(*) From TBLCARI group by IL",baglanti);
            SqlDataReader mr=komut.ExecuteReader();
            while(mr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(mr[0]),int.Parse(mr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
