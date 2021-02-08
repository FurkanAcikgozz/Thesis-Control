using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.IO;
using SautinSoft.Document;

namespace ThesisControl
{
    public partial class frm_UyePanelWord : Form
    {
        public frm_UyePanelWord()
        {
            InitializeComponent();
        }
        //dosya yolu açma
        OpenFileDialog dosya = new OpenFileDialog();

        //word içeriğini almak
        string wordOku(string adres)
        {
            //Microsoft.Office.Itertop.Word kullanarak word dosyasının içeriğini alıyoruz
            Microsoft.Office.Interop.Word.Application wordDoc = new Microsoft.Office.Interop.Word.Application();
            object dosya = adres;
            object missValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Document doc = wordDoc.Documents.Open(
              ref dosya, ref missValue, ref missValue,
              ref missValue, ref missValue, ref missValue,
              ref missValue, ref missValue, ref missValue,
              ref missValue, ref missValue, ref missValue,
              ref missValue, ref missValue, ref missValue);
            string icerik = doc.Content.Text;
            doc.Close(ref missValue, ref missValue, ref missValue);
            return icerik;
        }
        
        private void btn_Open_Click(object sender, EventArgs e)
        {
            
            //Yalnızca docx uzantısı ayarlamak
            dosya.Filter = "Word Dosyaları |*.docx";
            dosya.ShowDialog();

            //Boş değilse richtextbox a belirtilen adresteki docx yükle
            if (dosya.FileName != "")
            {
                wordOku(dosya.FileName);
                richTextBox2.Text += wordOku(dosya.FileName);
            }
        }

        private void btn_bilgiler_Click(object sender, EventArgs e)
        {
            
            // var değişkenine bulacağımız metini textboxtan alıyoruz
            var wordToFind = textBox1.Text.ToString();
            var sayac = 0;

            //Open doc file.
            // docx dosyası açıyoruz.
            var application = new Microsoft.Office.Interop.Word.Application();
            var document = application.Documents.Open(dosya.FileName);



            // Loop through all words in the document.
            //Belgedeki tüm sözcükleri dögü ile, textboxtan aldığımız kelime ile kontrol ediyoruz
            for (var i = 1; i <= document.Words.Count; i++)
                if (document.Words[i].Text.TrimEnd() == wordToFind)
                {

                    sayac++;
                }
           
            if (sayac>0)
            {
                MessageBox.Show("Kelime Bulundu...!" ,"Uyarı");
                richTextBox1.Text += "\nBulunan Kelime Sayısı = " + sayac;

            }
            else
            MessageBox.Show("Aranılan Kelime Bulunamadı...!","Uyarı");

            // Close word.
            //Word Kapat
            application.Quit(); 
        }

        private void btn_Bilgilerr_Click(object sender, EventArgs e)
        {

            DocumentCore dc = DocumentCore.Load(dosya.FileName);
            dc.CalculateStats();

            //SautinSoftun kendi parametrelerini kullanarak sayfa,paragraf,kelime,karakter,boşluk sayısı sonuçlarını richtextboxa atıyoruz
            richTextBox1.Text += ("\n\nSayfa Sayısı = " + dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Pages]);
            richTextBox1.Text += ("\n\nParagraf Sayısı = " + dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Paragraphs]);
            richTextBox1.Text += ("\n\nKelime Sayısı = " + dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Words]);
            richTextBox1.Text += ("\n\nKarekter Sayısı = " + dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Characters]);
            richTextBox1.Text += ("\n\nBoşluk Sayısı ve \nKarekter Sayısı Toplamı = " + dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.CharactersWithSpaces]);

            
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            try
            {
                //dosya yolunu stringin içine atıyoruz
                string loadPath = dosya.FileName;
                //documentcore oluşturuyoruz
                DocumentCore dc = DocumentCore.Load(dosya.FileName);
                dc.CalculateStats();
                
                //Değiştirmek istediğimiz kelime ve ya cümleyi alıyoruz(textboxtan aldım)
                Regex regex = new Regex(textBox2.Text.ToString(), RegexOptions.IgnoreCase);

                //Döngü ile değiştirmek istediğimiz birden fazla olan kelimeleri ayıklıyoruz
                foreach (ContentRange item in dc.Content.Find(regex).Reverse())
                {
                    //Textbox3 ten aldığımız yerine gelecek kelimeyi yerleştiriyoruz ve yazılan kelimenin arka plan rengini yazı tipini boyutunu ayarlıyoruz. İsteğe göre bunlar klavyeden giriş yapılabilr.
                    item.Replace(textBox3.Text.ToString(), new CharacterFormat() { BackgroundColor = SautinSoft.Document.Color.White, FontName = "Times New Roman", Size = 12.0 });
                }
                //Değiştirilen kelimeleri farklı kaydet işlemi yapıyoruz.
                //Alınan dosya yolu neresi ise farklı kaydedeceği yolda aynısı olacaktır. Dosya isminin sonuna .replaced.docx yazarak
                string savePath = Path.ChangeExtension(loadPath, ".replaced.docx");
                dc.Save(savePath, SaveOptions.DocxDefault);

                //Karşılaştırma yapabilmek için her iki word dosyasınıda bize açmasını sağlıyoruz.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(loadPath) { UseShellExecute = true });
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });
                MessageBox.Show("Değişiklik Başarıyla Tamamlandı...!","Uyarı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu...!", "Uyarı"+ex);
            }
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                //dosya yolunu stringin içine atıyoruz
                string loadPath = dosya.FileName;

                //documentcore oluşturuyoruz
                DocumentCore dc = DocumentCore.Load(dosya.FileName);
                dc.CalculateStats();

                //Silinecek kelimeyi textboxtan alıp String içerisine atıyoruz
                string textToDelete = textBox4.Text.ToString();
                //Döngü ile birden fazla silinmesi gerekleri siliyoruz ve her silme işleminden sonra sayac artırıyoruz.
                int countDel = 0;
                foreach (ContentRange cr in dc.Content.Find(textToDelete).Reverse())
                {
                    cr.Delete();
                    countDel++;
                }


                MessageBox.Show("Girilen Öğe = \"" + textToDelete + "\" Silindi " +"\nSilinen Öğe Sayısı = "+ countDel.ToString());
                //Değiştirilen kelimeleri farklı kaydet işlemi yapıyoruz.
                //Alınan dosya yolu neresi ise farklı kaydedeceği yolda aynısı olacaktır. Dosya isminin sonuna .replaced.docx yazarak
                string savePath = Path.ChangeExtension(loadPath, ".replaced.docx");
                dc.Save(savePath, SaveOptions.DocxDefault);

                //Karşılaştırma yapabilmek için her iki word dosyasınıda bize açmasını sağlıyoruz.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(loadPath) { UseShellExecute = true });
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });
                MessageBox.Show("Silme Başarıyla Tamamlandı...!", "Uyarı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu...!", "Uyarı" + ex);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //sayfayı kapat
            this.Close();
        }
    }
}
