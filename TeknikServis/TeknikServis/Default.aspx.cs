using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis.Entity;
namespace TeknikServis
{
    public partial class Default : System.Web.UI.Page
    {
        BITIRMEPROJEEntities1 dr = new BITIRMEPROJEEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dr.TBLURUN.ToList();
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM fr = new TBLILETISIM();
            fr.ADSOYAD = TextBox1.Text;
            fr.MAIL=TextBox2.Text;
            fr.KONU = TextBox3.Text;
            fr.MESAJ = TextBox4.Text;
            dr.TBLILETISIM.Add(fr);
            dr.SaveChanges();
        }
    }
}