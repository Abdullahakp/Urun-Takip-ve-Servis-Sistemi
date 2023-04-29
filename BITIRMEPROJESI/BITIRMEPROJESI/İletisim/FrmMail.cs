﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BITIRMEPROJESI.İletisim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gönderici";
            string sifre = "şifreniz";
            string alici = TxtSatis.Text;
            string konu = textBox1.Text;
            string içerik = textBox2.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = içerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
