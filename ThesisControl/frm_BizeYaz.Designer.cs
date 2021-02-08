namespace ThesisControl
{
    partial class frm_BizeYaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_konu = new System.Windows.Forms.ComboBox();
            this.combo_kime = new System.Windows.Forms.ComboBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_icerik = new System.Windows.Forms.RichTextBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "İçerik: ";
            // 
            // combo_konu
            // 
            this.combo_konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_konu.FormattingEnabled = true;
            this.combo_konu.Items.AddRange(new object[] {
            "Öneri",
            "Şikayet",
            "Teşekkür"});
            this.combo_konu.Location = new System.Drawing.Point(149, 110);
            this.combo_konu.Name = "combo_konu";
            this.combo_konu.Size = new System.Drawing.Size(621, 33);
            this.combo_konu.TabIndex = 5;
            // 
            // combo_kime
            // 
            this.combo_kime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_kime.FormattingEnabled = true;
            this.combo_kime.Items.AddRange(new object[] {
            "ThesisControllApp@gmail.com"});
            this.combo_kime.Location = new System.Drawing.Point(149, 149);
            this.combo_kime.Name = "combo_kime";
            this.combo_kime.Size = new System.Drawing.Size(621, 33);
            this.combo_kime.TabIndex = 6;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(149, 188);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(621, 30);
            this.txt_mail.TabIndex = 7;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(148, 224);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '♥';
            this.txt_sifre.Size = new System.Drawing.Size(621, 30);
            this.txt_sifre.TabIndex = 8;
            // 
            // txt_icerik
            // 
            this.txt_icerik.Location = new System.Drawing.Point(149, 259);
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.Size = new System.Drawing.Size(621, 174);
            this.txt_icerik.TabIndex = 9;
            this.txt_icerik.Text = "";
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(70, 439);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(700, 65);
            this.btn_Gonder.TabIndex = 10;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(57, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(713, 78);
            this.label6.TabIndex = 11;
            this.label6.Text = "E - Posta Gönderimi";
            // 
            // frm_BizeYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(813, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.txt_icerik);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.combo_kime);
            this.Controls.Add(this.combo_konu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_BizeYaz";
            this.Text = "Bize Yaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_konu;
        private System.Windows.Forms.ComboBox combo_kime;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.RichTextBox txt_icerik;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.Label label6;
    }
}