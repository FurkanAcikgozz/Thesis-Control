using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.parser;
using System.Text;
using System.Collections.Generic;

namespace ThesisControl
{
    public partial class frm_UyePanel : Form
    {
        public frm_UyePanel()
        {
            InitializeComponent();
        }


    
        //dosya yolu açma
        OpenFileDialog dosya = new OpenFileDialog();
        private void btn_DosyaSec_Click(object sender, EventArgs e)
        {
            //yalnızca pdf uzantısı
            dosya.Filter = "PDF Dosyaları |*.pdf";
            dosya.ShowDialog();
            //Boş değilse axAcroPDF1 e belirtilen adresteki pdf yükle
            if (dosya.FileName != "")
            {
                axAcroPDF1.LoadFile(dosya.FileName);
                
            }
            //pdfReader ile dosya adresini okutma
            PdfReader reader = new PdfReader(dosya.FileName);
            PdfReaderContentParser parser = new PdfReaderContentParser(reader);

            //Sayfa Sayısı
            int numberOfPages = reader.NumberOfPages;

            int a = reader.XrefSize;//Refarans Boyutu
            object g = reader.PdfVersion;//Version
            object h = reader.IsOpenedWithFullPermissions;// Tam İzinle Açıldı
            object jb = reader.FileLength;//dosya uzunluğu
            object je = reader.Appendable;//Eklenebilir





            MessageBox.Show("Pdf Başarıyla Getirildi...!");
            //itexsharptan aldığımız bilgileri richtextboxa ekliyoruz
            richTextBox1.Text = Convert.ToString("^^Bilgilendirme^^\n\n" + "Pdf Toplam Sayfa Sayısı = "
                + numberOfPages + "\n");
            richTextBox1.Text += Convert.ToString("\nDosya Uzunluğu = " + jb + " bayt"+ "\n" +
                "\nReferans Boyutu = " + a +" bayt"+ "\n" + "\nTam İzinle Mi Açıldı = " + 
                h+ "\n"+ "\nÜzerine Ekleme Yapılabilir Mi = " + je + "\n" + "\nVersiyon No = " + g);




        }



        private void btn_Ara_Click(object sender, EventArgs e)
        {
            //pdfReader ile dosya adresini okutma
            PdfReader reader = new PdfReader(dosya.FileName);
            PdfReaderContentParser parser = new PdfReaderContentParser(reader);

          
          
            int sayac = 0;
            List<int> pages = new List<int>();

            if (File.Exists(dosya.FileName))
            {
                //pdf dosyasını döngü ile okuyoruz
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                    StringBuilder text = new StringBuilder();
                    //aradığımız kelime textboxtaki kelime ile uyuşursa list pages içerisine atıyoruz
                    string currentPageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                    if (currentPageText.Contains(txt_Ara.Text))
                    {
                        sayac = sayac + 1;
                        pages.Add(page);
                        listBox1.Items.Add(page+". Sayfada Bulundu...!");
                    }
                  
                }
                //pdf dosyası kapat
                reader.Close();
                //listboxa sayfa numaralarını ekle ve richtexte kelime toplamını yazdır
                MessageBox.Show(Convert.ToString("Aradığınız Kelimenin Toplam Sayısı = " + sayac));
                listBox1.Items.Add("Aradığınız Kelimenin Toplam Sayısı = " + sayac);
                richTextBox1.Text += Convert.ToString("\n" + "\n" +"Aradığınız Kelimenin Toplam Sayısı = " + sayac);
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3 e tıklandığında word dosya işlemlerinne git
            this.Close();
            frm_UyePanelWord form = new frm_UyePanelWord();
            
            form.Show();
            
        }


        private void btn_git_Click(object sender, EventArgs e)
        {
            //klavyeden aldığımız sayfa numarasını axAcroPDF1 de göster
            try
            {
                int sayfaNo = Convert.ToInt16(txt_sayfaNo.Text.ToString());
                axAcroPDF1.setCurrentPage(sayfaNo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Girilen Sayfa Bulunamadı Tekrar Deneyin...!","Uyarı"+ex);
            }
            
        }

        private void btn_ilkSayfa_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında ilk sayfayı axAcroPDF1 de göster
            axAcroPDF1.gotoFirstPage();
        }

        private void btn_onceki_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında önceki sayfayı axAcroPDF1 de göster
            axAcroPDF1.gotoPreviousPage();
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında sonraki sayfayı axAcroPDF1 de göster
            axAcroPDF1.gotoNextPage();
        }

        private void btn_sonSayfa_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında son sayfayı axAcroPDF1 de göster
            axAcroPDF1.gotoLastPage();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Sayfayı Kapat
            this.Close();
        }
    }
}
