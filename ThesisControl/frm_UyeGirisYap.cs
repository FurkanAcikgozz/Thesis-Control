using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisControl
{
    public partial class frm_UyeGirisYap : Form
    {
        public frm_UyeGirisYap()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            //Kullanıcı adı ve şifre doğruysa üye panelini aç
            if (txt_kullaniciAdi.Text=="" && txt_Sifre.Text=="")
            {
                frm_UyePanel form = new frm_UyePanel();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre....!","Hata");
            }
            
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                MessageBox.Show("Başarıyla Kayıt Oluşturuldu...!", "Hoş Geldiniz");
            }
            else MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");

        }
    }
}
