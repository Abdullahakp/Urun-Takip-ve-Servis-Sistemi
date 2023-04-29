using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis.Entity;

namespace TeknikServis
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* var deger = dr.TBLURUNTAKIP.ToList();
            Repeater1.DataSource = deger;
            Repeater1.DataBind*/
        }
        BITIRMEPROJEEntities1 dr = new BITIRMEPROJEEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var deger = dr.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);
            Repeater1.DataSource = deger.ToList();
            Repeater1.DataBind();
        }
    }
}