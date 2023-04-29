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
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        int secilen;
        BITIRMEPROJEEntities2 db=new BITIRMEPROJEEntities2();
        void liste()
        {
           var deger =from x in db.TBLCARI
                             select  new
                             {
                                x.ID,
                                x.AD,
                                x.SOYAD,
                                x.TELEFON,
                                x.IL,
                                x.ILCE,
                                x.MAIL,
                                x.BANKA,
                                x.STATU,
                                x.ADRES
                                
                             };
            gridControl1.DataSource= deger.ToList();
            lookIL.Properties.DataSource = (from x in db.iller
                                            select new
                                            {
                                                x.id,
                                                x.sehir
                                            }).ToList();
        }
        private void FrmCariler_Load(object sender, EventArgs e)
        {
            liste();
            labelControl13.Text = db.TBLCARI.Count().ToString();
            labelControl15.Text = db.TBLCARI.Count(x => x.DURUM == true).ToString();
            labelControl15.Text = db.TBLCARI.Select(x=>x.IL).Distinct().Count().ToString();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lookIL_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookIL.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from x in db.ilceler
                                            select new
                                            {
                                                x.id,
                                                x.ilce,
                                                x.sehir
                                            }).Where(z=>z.sehir==secilen).ToList();
        }
    }
}
