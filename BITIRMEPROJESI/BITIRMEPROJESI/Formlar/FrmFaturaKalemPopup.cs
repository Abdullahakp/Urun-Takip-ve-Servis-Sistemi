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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        BITIRMEPROJEEntities2 dr = new BITIRMEPROJEEntities2();
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dr.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = dr.TBLFATURABILGI.Where(x=>x.ID==id).ToList();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya2.xls";
            gridControl1.ExportToXls(path);
        }
    }
}
