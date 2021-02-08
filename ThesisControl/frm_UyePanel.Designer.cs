namespace ThesisControl
{
    partial class frm_UyePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UyePanel));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DosyaSec = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sonSayfa = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_ilkSayfa = new System.Windows.Forms.Button();
            this.txt_sayfaNo = new System.Windows.Forms.TextBox();
            this.btn_git = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "İncelemek İstediğiniz\r\nPdf Dosyasını Seçin";
            // 
            // btn_DosyaSec
            // 
            this.btn_DosyaSec.BackgroundImage = global::ThesisControl.Properties.Resources.istockphoto_1058719724_1024x1024;
            this.btn_DosyaSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DosyaSec.Location = new System.Drawing.Point(296, 317);
            this.btn_DosyaSec.Name = "btn_DosyaSec";
            this.btn_DosyaSec.Size = new System.Drawing.Size(100, 70);
            this.btn_DosyaSec.TabIndex = 1;
            this.btn_DosyaSec.UseVisualStyleBackColor = true;
            this.btn_DosyaSec.Click += new System.EventHandler(this.btn_DosyaSec_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(426, 134);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(377, 451);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(1222, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 692);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 612);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(537, 164);
            this.listBox1.TabIndex = 5;
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(7, 571);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(310, 26);
            this.txt_Ara.TabIndex = 6;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(323, 566);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(221, 40);
            this.btn_Ara.TabIndex = 8;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kelime Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Word dosyası için buraya TIKLAYINIZ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_sonSayfa
            // 
            this.btn_sonSayfa.Location = new System.Drawing.Point(1164, 901);
            this.btn_sonSayfa.Name = "btn_sonSayfa";
            this.btn_sonSayfa.Size = new System.Drawing.Size(43, 39);
            this.btn_sonSayfa.TabIndex = 13;
            this.btn_sonSayfa.Text = ">>";
            this.btn_sonSayfa.UseVisualStyleBackColor = true;
            this.btn_sonSayfa.Click += new System.EventHandler(this.btn_sonSayfa_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Location = new System.Drawing.Point(1115, 901);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(43, 39);
            this.btn_sonraki.TabIndex = 14;
            this.btn_sonraki.Text = ">";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.Location = new System.Drawing.Point(1066, 901);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(43, 39);
            this.btn_onceki.TabIndex = 15;
            this.btn_onceki.Text = "<";
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_ilkSayfa
            // 
            this.btn_ilkSayfa.Location = new System.Drawing.Point(1017, 901);
            this.btn_ilkSayfa.Name = "btn_ilkSayfa";
            this.btn_ilkSayfa.Size = new System.Drawing.Size(43, 39);
            this.btn_ilkSayfa.TabIndex = 16;
            this.btn_ilkSayfa.Text = "<<";
            this.btn_ilkSayfa.UseVisualStyleBackColor = true;
            this.btn_ilkSayfa.Click += new System.EventHandler(this.btn_ilkSayfa_Click);
            // 
            // txt_sayfaNo
            // 
            this.txt_sayfaNo.Location = new System.Drawing.Point(862, 907);
            this.txt_sayfaNo.Name = "txt_sayfaNo";
            this.txt_sayfaNo.Size = new System.Drawing.Size(100, 26);
            this.txt_sayfaNo.TabIndex = 17;
            // 
            // btn_git
            // 
            this.btn_git.Location = new System.Drawing.Point(968, 902);
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(43, 39);
            this.btn_git.TabIndex = 18;
            this.btn_git.Text = "Git";
            this.btn_git.UseVisualStyleBackColor = true;
            this.btn_git.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(612, 910);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gitmek İstediğiniz Sayfa:";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::ThesisControl.Properties.Resources._5570435_stock_vector_red_grunge_power_logo;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1866, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(57, 55);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_UyePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThesisControl.Properties.Resources._97130877_la_caída_de_líneas_de_fondo_verde_matriz_geométrica_matriz;
            this.ClientSize = new System.Drawing.Size(1924, 986);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_git);
            this.Controls.Add(this.txt_sayfaNo);
            this.Controls.Add(this.btn_ilkSayfa);
            this.Controls.Add(this.btn_onceki);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_sonSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btn_DosyaSec);
            this.Controls.Add(this.label1);
            this.Name = "frm_UyePanel";
            this.Text = "Thesis Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DosyaSec;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sonSayfa;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_ilkSayfa;
        private System.Windows.Forms.TextBox txt_sayfaNo;
        private System.Windows.Forms.Button btn_git;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
    }
}