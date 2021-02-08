using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ThesisControl
{
    public partial class frm_BizeYaz : Form
    {
        public frm_BizeYaz()
        {
            InitializeComponent();
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage eposta = new MailMessage();
                eposta.From = new MailAddress(txt_mail.Text.ToString());
                eposta.To.Add(combo_kime.Text.ToString());
                eposta.Subject = combo_konu.Text.ToString();
                eposta.Body = txt_icerik.Text.ToString();

                SmtpClient smtp = new SmtpClient();

                smtp.Credentials = new System.Net.NetworkCredential(txt_mail.Text.ToString(), txt_sifre.Text.ToString());
                smtp.Host = "smtp.gmail.com"; //gmail host adresi 
                smtp.EnableSsl = true;
                smtp.Port = 587;

                smtp.Send(eposta);
                MessageBox.Show("Mail Başarıyla Gönderildi...!","Bilgilendirme");
                txt_icerik.Text = "";
                txt_mail.Text = "";
                txt_sifre.Text = "";
                combo_kime.Text = "";
                combo_konu.Text = "";
            }
           catch (Exception hata)
            {

               MessageBox.Show("Hata Oluştu..."+"\n"+ hata.Message, "Bilgilendirme");
            }
           
        }
    }
}
