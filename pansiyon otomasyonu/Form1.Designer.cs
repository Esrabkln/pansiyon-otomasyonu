
namespace pansiyon_otomasyonu
{
    partial class frmYeniMusteri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtOdaNumarası = new System.Windows.Forms.TextBox();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOda109 = new System.Windows.Forms.Button();
            this.btnOda108 = new System.Windows.Forms.Button();
            this.btnOda107 = new System.Windows.Forms.Button();
            this.btnOda106 = new System.Windows.Forms.Button();
            this.btnOda105 = new System.Windows.Forms.Button();
            this.btnOda104 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.btnDoluOda = new System.Windows.Forms.Button();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMusteriİd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tc Kimlik No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Oda Numarası:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Çıkış Tarihi:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(102, 57);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 20);
            this.txtAdi.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(102, 83);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtSoyadi.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(102, 161);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(102, 187);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 20);
            this.txtTc.TabIndex = 3;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Location = new System.Drawing.Point(102, 135);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(200, 20);
            this.MskTxtTelefon.TabIndex = 4;
            // 
            // txtOdaNumarası
            // 
            this.txtOdaNumarası.Enabled = false;
            this.txtOdaNumarası.Location = new System.Drawing.Point(102, 213);
            this.txtOdaNumarası.Name = "txtOdaNumarası";
            this.txtOdaNumarası.Size = new System.Drawing.Size(200, 20);
            this.txtOdaNumarası.TabIndex = 3;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(102, 271);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpGirisTarihi.TabIndex = 5;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(102, 298);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpCikisTarihi.TabIndex = 6;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMusteriİd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOdaNumarası);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 442);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgiler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(102, 354);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "0";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(102, 107);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 21);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telefon:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(102, 239);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(200, 20);
            this.txtUcret.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ücret:";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOda109);
            this.groupBox2.Controls.Add(this.btnOda108);
            this.groupBox2.Controls.Add(this.btnOda107);
            this.groupBox2.Controls.Add(this.btnOda106);
            this.groupBox2.Controls.Add(this.btnOda105);
            this.groupBox2.Controls.Add(this.btnOda104);
            this.groupBox2.Controls.Add(this.btnOda103);
            this.groupBox2.Controls.Add(this.btnOda102);
            this.groupBox2.Controls.Add(this.btnOda101);
            this.groupBox2.Location = new System.Drawing.Point(356, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 411);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnOda109
            // 
            this.btnOda109.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda109.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda109.Location = new System.Drawing.Point(228, 262);
            this.btnOda109.Name = "btnOda109";
            this.btnOda109.Size = new System.Drawing.Size(58, 58);
            this.btnOda109.TabIndex = 9;
            this.btnOda109.Text = "109";
            this.btnOda109.UseVisualStyleBackColor = false;
            this.btnOda109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btnOda108
            // 
            this.btnOda108.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda108.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda108.Location = new System.Drawing.Point(135, 265);
            this.btnOda108.Name = "btnOda108";
            this.btnOda108.Size = new System.Drawing.Size(58, 55);
            this.btnOda108.TabIndex = 8;
            this.btnOda108.Text = "108";
            this.btnOda108.UseVisualStyleBackColor = false;
            this.btnOda108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btnOda107
            // 
            this.btnOda107.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda107.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda107.Location = new System.Drawing.Point(43, 266);
            this.btnOda107.Name = "btnOda107";
            this.btnOda107.Size = new System.Drawing.Size(58, 54);
            this.btnOda107.TabIndex = 7;
            this.btnOda107.Text = "107";
            this.btnOda107.UseVisualStyleBackColor = false;
            this.btnOda107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btnOda106
            // 
            this.btnOda106.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda106.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda106.Location = new System.Drawing.Point(228, 177);
            this.btnOda106.Name = "btnOda106";
            this.btnOda106.Size = new System.Drawing.Size(58, 57);
            this.btnOda106.TabIndex = 6;
            this.btnOda106.Text = "106";
            this.btnOda106.UseVisualStyleBackColor = false;
            this.btnOda106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btnOda105
            // 
            this.btnOda105.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda105.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda105.Location = new System.Drawing.Point(135, 177);
            this.btnOda105.Name = "btnOda105";
            this.btnOda105.Size = new System.Drawing.Size(58, 57);
            this.btnOda105.TabIndex = 5;
            this.btnOda105.Text = "105";
            this.btnOda105.UseVisualStyleBackColor = false;
            this.btnOda105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btnOda104
            // 
            this.btnOda104.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda104.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda104.Location = new System.Drawing.Point(43, 177);
            this.btnOda104.Name = "btnOda104";
            this.btnOda104.Size = new System.Drawing.Size(58, 57);
            this.btnOda104.TabIndex = 4;
            this.btnOda104.Text = "104";
            this.btnOda104.UseVisualStyleBackColor = false;
            this.btnOda104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda103.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda103.Location = new System.Drawing.Point(228, 76);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(58, 53);
            this.btnOda103.TabIndex = 3;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            this.btnOda103.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda102.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda102.Location = new System.Drawing.Point(135, 76);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(58, 53);
            this.btnOda102.TabIndex = 1;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            this.btnOda102.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOda101.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOda101.Location = new System.Drawing.Point(43, 76);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(58, 53);
            this.btnOda101.TabIndex = 0;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.BackColor = System.Drawing.Color.Red;
            this.btnDoluOda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoluOda.Location = new System.Drawing.Point(517, 450);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(75, 33);
            this.btnDoluOda.TabIndex = 10;
            this.btnDoluOda.Text = "DOLU";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            this.btnDoluOda.Click += new System.EventHandler(this.btnDoluOda_Click);
            // 
            // btnBosOda
            // 
            this.btnBosOda.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBosOda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBosOda.Location = new System.Drawing.Point(598, 450);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(75, 33);
            this.btnBosOda.TabIndex = 11;
            this.btnBosOda.Text = "BOŞ";
            this.btnBosOda.UseVisualStyleBackColor = false;
            this.btnBosOda.Click += new System.EventHandler(this.btnBosOda_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Müştei İD:";
            // 
            // txtMusteriİd
            // 
            this.txtMusteriİd.Location = new System.Drawing.Point(102, 32);
            this.txtMusteriİd.Name = "txtMusteriİd";
            this.txtMusteriİd.Size = new System.Drawing.Size(200, 20);
            this.txtMusteriİd.TabIndex = 12;
            // 
            // frmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 498);
            this.Controls.Add(this.btnBosOda);
            this.Controls.Add(this.btnDoluOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox txtOdaNumarası;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda104;
        private System.Windows.Forms.Button btnOda105;
        private System.Windows.Forms.Button btnOda106;
        private System.Windows.Forms.Button btnOda107;
        private System.Windows.Forms.Button btnOda108;
        private System.Windows.Forms.Button btnOda109;
        private System.Windows.Forms.Button btnDoluOda;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMusteriİd;
        private System.Windows.Forms.Label label12;
    }
}

