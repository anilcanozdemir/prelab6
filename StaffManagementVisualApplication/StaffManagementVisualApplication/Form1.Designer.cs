namespace StaffManagementVisualApplication
{
    partial class YonetimBirimiApplication
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
            this.lstbxGoster = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblDegistir = new System.Windows.Forms.Button();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblmaas = new System.Windows.Forms.Label();
            this.lblTecrube = new System.Windows.Forms.Label();
            this.lblsehir = new System.Windows.Forms.Label();
            this.lblegitim = new System.Windows.Forms.Label();
            this.txttecrube = new System.Windows.Forms.TextBox();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.cmbegitim = new System.Windows.Forms.ComboBox();
            this.lbldilbilgisi = new System.Windows.Forms.Label();
            this.chckingilizce = new System.Windows.Forms.CheckBox();
            this.chckingilizceokul = new System.Windows.Forms.CheckBox();
            this.lbldigerdil = new System.Windows.Forms.Label();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.cmbyoneticilik = new System.Windows.Forms.ComboBox();
            this.grpbxAile = new System.Windows.Forms.GroupBox();
            this.chckbxesicalismiyor = new System.Windows.Forms.CheckBox();
            this.txtbuyuk = new System.Windows.Forms.TextBox();
            this.txtortanca = new System.Windows.Forms.TextBox();
            this.txtkucuk = new System.Windows.Forms.TextBox();
            this.chckbxbuyuk = new System.Windows.Forms.CheckBox();
            this.chckbxortanca = new System.Windows.Forms.CheckBox();
            this.chckbxkucuk = new System.Windows.Forms.CheckBox();
            this.rbtnEvli = new System.Windows.Forms.RadioButton();
            this.rbtnBekar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbmo = new System.Windows.Forms.Label();
            this.grpbxAile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxGoster
            // 
            this.lstbxGoster.FormattingEnabled = true;
            this.lstbxGoster.Location = new System.Drawing.Point(12, 12);
            this.lstbxGoster.Name = "lstbxGoster";
            this.lstbxGoster.Size = new System.Drawing.Size(270, 264);
            this.lstbxGoster.TabIndex = 0;
            this.lstbxGoster.SelectedIndexChanged += new System.EventHandler(this.lstbxStaffs_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(434, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(515, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDegistir
            // 
            this.lblDegistir.Location = new System.Drawing.Point(596, 4);
            this.lblDegistir.Name = "lblDegistir";
            this.lblDegistir.Size = new System.Drawing.Size(75, 23);
            this.lblDegistir.TabIndex = 3;
            this.lblDegistir.Text = "Degistir";
            this.lblDegistir.UseVisualStyleBackColor = true;
            this.lblDegistir.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(434, 33);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 4;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(434, 59);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 5;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(434, 85);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 20);
            this.txtadres.TabIndex = 6;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(434, 111);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(100, 20);
            this.txtmaas.TabIndex = 7;
            this.txtmaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(378, 33);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(25, 13);
            this.lblisim.TabIndex = 8;
            this.lblisim.Text = "İsim";
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(361, 59);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(42, 13);
            this.lblsoyisim.TabIndex = 9;
            this.lblsoyisim.Text = "Soyisim";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(370, 88);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(370, 111);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(33, 13);
            this.lblmaas.TabIndex = 11;
            this.lblmaas.Text = "Maas";
            // 
            // lblTecrube
            // 
            this.lblTecrube.AutoSize = true;
            this.lblTecrube.Location = new System.Drawing.Point(356, 137);
            this.lblTecrube.Name = "lblTecrube";
            this.lblTecrube.Size = new System.Drawing.Size(47, 13);
            this.lblTecrube.TabIndex = 12;
            this.lblTecrube.Text = "Tecrube";
            // 
            // lblsehir
            // 
            this.lblsehir.AutoSize = true;
            this.lblsehir.Location = new System.Drawing.Point(373, 163);
            this.lblsehir.Name = "lblsehir";
            this.lblsehir.Size = new System.Drawing.Size(31, 13);
            this.lblsehir.TabIndex = 13;
            this.lblsehir.Text = "Sehir";
            // 
            // lblegitim
            // 
            this.lblegitim.AutoSize = true;
            this.lblegitim.Location = new System.Drawing.Point(368, 193);
            this.lblegitim.Name = "lblegitim";
            this.lblegitim.Size = new System.Drawing.Size(35, 13);
            this.lblegitim.TabIndex = 14;
            this.lblegitim.Text = "Egitim";
            // 
            // txttecrube
            // 
            this.txttecrube.Location = new System.Drawing.Point(434, 137);
            this.txttecrube.Name = "txttecrube";
            this.txttecrube.Size = new System.Drawing.Size(100, 20);
            this.txttecrube.TabIndex = 15;
            this.txttecrube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExperince_KeyPress);
            // 
            // cmbsehir
            // 
            this.cmbsehir.DropDownWidth = 100;
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon",
            "04 Ağrı",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.cmbsehir.Location = new System.Drawing.Point(434, 163);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(100, 21);
            this.cmbsehir.TabIndex = 16;
            // 
            // cmbegitim
            // 
            this.cmbegitim.DropDownWidth = 245;
            this.cmbegitim.FormattingEnabled = true;
            this.cmbegitim.Items.AddRange(new object[] {
            "Yok",
            "Meslek alanı ile ilgili yüksek lisans",
            "Meslek alanı ile ilgili doktora",
            "Meslek alanı ile ilgili doçentlik",
            "Meslek alanı ile ilgili olmayan yüksek lisans",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.cmbegitim.Location = new System.Drawing.Point(434, 193);
            this.cmbegitim.Name = "cmbegitim";
            this.cmbegitim.Size = new System.Drawing.Size(100, 21);
            this.cmbegitim.TabIndex = 17;
            // 
            // lbldilbilgisi
            // 
            this.lbldilbilgisi.AutoSize = true;
            this.lbldilbilgisi.Location = new System.Drawing.Point(324, 238);
            this.lbldilbilgisi.Name = "lbldilbilgisi";
            this.lbldilbilgisi.Size = new System.Drawing.Size(90, 13);
            this.lbldilbilgisi.TabIndex = 18;
            this.lbldilbilgisi.Text = "Yabancı Dil Bilgisi";
            this.lbldilbilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chckingilizce
            // 
            this.chckingilizce.AutoSize = true;
            this.chckingilizce.Location = new System.Drawing.Point(382, 259);
            this.chckingilizce.Name = "chckingilizce";
            this.chckingilizce.Size = new System.Drawing.Size(152, 17);
            this.chckingilizce.TabIndex = 19;
            this.chckingilizce.Text = "Belgelenmiş İngilizce Bilgisi";
            this.chckingilizce.UseVisualStyleBackColor = true;
            // 
            // chckingilizceokul
            // 
            this.chckingilizceokul.AutoSize = true;
            this.chckingilizceokul.Location = new System.Drawing.Point(382, 282);
            this.chckingilizceokul.Name = "chckingilizceokul";
            this.chckingilizceokul.Size = new System.Drawing.Size(204, 17);
            this.chckingilizceokul.TabIndex = 20;
            this.chckingilizceokul.Text = "İngilizce Eğitim Veren Okul Mezuniyeti";
            this.chckingilizceokul.UseVisualStyleBackColor = true;
            // 
            // lbldigerdil
            // 
            this.lbldigerdil.AutoSize = true;
            this.lbldigerdil.Location = new System.Drawing.Point(346, 305);
            this.lbldigerdil.Name = "lbldigerdil";
            this.lbldigerdil.Size = new System.Drawing.Size(136, 13);
            this.lbldigerdil.TabIndex = 21;
            this.lbldigerdil.Text = "Diğer Belgelenmiş Dil Sayısı";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(515, 302);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(19, 20);
            this.txtlanguage.TabIndex = 22;
            this.txtlanguage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlanguage_KeyPress);
            // 
            // cmbyoneticilik
            // 
            this.cmbyoneticilik.DropDownWidth = 300;
            this.cmbyoneticilik.FormattingEnabled = true;
            this.cmbyoneticilik.Items.AddRange(new object[] {
            "Yok",
            "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı",
            "Proje Yöneticisi",
            "Direktör/Projeler Yöneticisi",
            "CTO/Genel Müdür",
            "Bilgi İşlem Sorumlusu/Müdürü(0-5 personel)",
            "Bilgi İşlem Sorumlusu/Müdürü(5+personel)"});
            this.cmbyoneticilik.Location = new System.Drawing.Point(598, 33);
            this.cmbyoneticilik.Name = "cmbyoneticilik";
            this.cmbyoneticilik.Size = new System.Drawing.Size(99, 21);
            this.cmbyoneticilik.TabIndex = 23;
            // 
            // grpbxAile
            // 
            this.grpbxAile.Controls.Add(this.chckbxesicalismiyor);
            this.grpbxAile.Controls.Add(this.txtbuyuk);
            this.grpbxAile.Controls.Add(this.txtortanca);
            this.grpbxAile.Controls.Add(this.txtkucuk);
            this.grpbxAile.Controls.Add(this.chckbxbuyuk);
            this.grpbxAile.Controls.Add(this.chckbxortanca);
            this.grpbxAile.Controls.Add(this.chckbxkucuk);
            this.grpbxAile.Location = new System.Drawing.Point(540, 94);
            this.grpbxAile.Name = "grpbxAile";
            this.grpbxAile.Size = new System.Drawing.Size(285, 157);
            this.grpbxAile.TabIndex = 25;
            this.grpbxAile.TabStop = false;
            this.grpbxAile.Visible = false;
            // 
            // chckbxesicalismiyor
            // 
            this.chckbxesicalismiyor.AutoSize = true;
            this.chckbxesicalismiyor.Location = new System.Drawing.Point(6, 101);
            this.chckbxesicalismiyor.Name = "chckbxesicalismiyor";
            this.chckbxesicalismiyor.Size = new System.Drawing.Size(88, 17);
            this.chckbxesicalismiyor.TabIndex = 8;
            this.chckbxesicalismiyor.Text = "Eşi çalışmıyor";
            this.chckbxesicalismiyor.UseVisualStyleBackColor = true;
            // 
            // txtbuyuk
            // 
            this.txtbuyuk.Location = new System.Drawing.Point(163, 76);
            this.txtbuyuk.Name = "txtbuyuk";
            this.txtbuyuk.Size = new System.Drawing.Size(100, 20);
            this.txtbuyuk.TabIndex = 7;
            this.txtbuyuk.Visible = false;
            this.txtbuyuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtolder_KeyPress);
            // 
            // txtortanca
            // 
            this.txtortanca.Location = new System.Drawing.Point(163, 49);
            this.txtortanca.Name = "txtortanca";
            this.txtortanca.Size = new System.Drawing.Size(100, 20);
            this.txtortanca.TabIndex = 6;
            this.txtortanca.Visible = false;
            this.txtortanca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmiddle_KeyPress);
            // 
            // txtkucuk
            // 
            this.txtkucuk.Location = new System.Drawing.Point(163, 23);
            this.txtkucuk.Name = "txtkucuk";
            this.txtkucuk.Size = new System.Drawing.Size(100, 20);
            this.txtkucuk.TabIndex = 5;
            this.txtkucuk.Visible = false;
            this.txtkucuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlittle_KeyPress);
            // 
            // chckbxbuyuk
            // 
            this.chckbxbuyuk.AutoSize = true;
            this.chckbxbuyuk.Location = new System.Drawing.Point(6, 76);
            this.chckbxbuyuk.Name = "chckbxbuyuk";
            this.chckbxbuyuk.Size = new System.Drawing.Size(151, 17);
            this.chckbxbuyuk.TabIndex = 4;
            this.chckbxbuyuk.Text = "18 yaş üstü öğrenci çocuk";
            this.chckbxbuyuk.UseVisualStyleBackColor = true;
            this.chckbxbuyuk.CheckedChanged += new System.EventHandler(this.chckbxolder_CheckedChanged);
            // 
            // chckbxortanca
            // 
            this.chckbxortanca.AutoSize = true;
            this.chckbxortanca.Location = new System.Drawing.Point(6, 49);
            this.chckbxortanca.Name = "chckbxortanca";
            this.chckbxortanca.Size = new System.Drawing.Size(124, 17);
            this.chckbxortanca.TabIndex = 3;
            this.chckbxortanca.Text = "7-18 yaş arası çocuk";
            this.chckbxortanca.UseVisualStyleBackColor = true;
            this.chckbxortanca.CheckedChanged += new System.EventHandler(this.chckmiddle_CheckedChanged);
            // 
            // chckbxkucuk
            // 
            this.chckbxkucuk.AutoSize = true;
            this.chckbxkucuk.Location = new System.Drawing.Point(6, 20);
            this.chckbxkucuk.Name = "chckbxkucuk";
            this.chckbxkucuk.Size = new System.Drawing.Size(118, 17);
            this.chckbxkucuk.TabIndex = 2;
            this.chckbxkucuk.Text = "0-6 yaş arası çocuk";
            this.chckbxkucuk.UseVisualStyleBackColor = true;
            this.chckbxkucuk.CheckedChanged += new System.EventHandler(this.chckbxlittle_CheckedChanged);
            // 
            // rbtnEvli
            // 
            this.rbtnEvli.AutoSize = true;
            this.rbtnEvli.Location = new System.Drawing.Point(562, 71);
            this.rbtnEvli.Name = "rbtnEvli";
            this.rbtnEvli.Size = new System.Drawing.Size(42, 17);
            this.rbtnEvli.TabIndex = 0;
            this.rbtnEvli.Text = "Evli";
            this.rbtnEvli.UseVisualStyleBackColor = true;
            this.rbtnEvli.CheckedChanged += new System.EventHandler(this.rbtnMarried_CheckedChanged);
            // 
            // rbtnBekar
            // 
            this.rbtnBekar.AutoSize = true;
            this.rbtnBekar.Checked = true;
            this.rbtnBekar.Location = new System.Drawing.Point(628, 71);
            this.rbtnBekar.Name = "rbtnBekar";
            this.rbtnBekar.Size = new System.Drawing.Size(53, 17);
            this.rbtnBekar.TabIndex = 1;
            this.rbtnBekar.TabStop = true;
            this.rbtnBekar.Text = "Bekar";
            this.rbtnBekar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Yöneticilik";
            // 
            // lblbmo
            // 
            this.lblbmo.AutoSize = true;
            this.lblbmo.Location = new System.Drawing.Point(192, 338);
            this.lblbmo.Name = "lblbmo";
            this.lblbmo.Size = new System.Drawing.Size(34, 13);
            this.lblbmo.TabIndex = 27;
            this.lblbmo.Text = "BMO:";
            // 
            // YonetimBirimiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 496);
            this.Controls.Add(this.lblbmo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpbxAile);
            this.Controls.Add(this.cmbyoneticilik);
            this.Controls.Add(this.rbtnEvli);
            this.Controls.Add(this.rbtnBekar);
            this.Controls.Add(this.txtlanguage);
            this.Controls.Add(this.lbldigerdil);
            this.Controls.Add(this.chckingilizceokul);
            this.Controls.Add(this.chckingilizce);
            this.Controls.Add(this.lbldilbilgisi);
            this.Controls.Add(this.cmbegitim);
            this.Controls.Add(this.cmbsehir);
            this.Controls.Add(this.txttecrube);
            this.Controls.Add(this.lblegitim);
            this.Controls.Add(this.lblsehir);
            this.Controls.Add(this.lblTecrube);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblsoyisim);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.lblDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstbxGoster);
            this.Name = "YonetimBirimiApplication";
            this.Text = "YonetimBirimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxAile.ResumeLayout(false);
            this.grpbxAile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxGoster;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button lblDegistir;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblmaas;
        private System.Windows.Forms.Label lblTecrube;
        private System.Windows.Forms.Label lblsehir;
        private System.Windows.Forms.Label lblegitim;
        private System.Windows.Forms.TextBox txttecrube;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.ComboBox cmbegitim;
        private System.Windows.Forms.Label lbldilbilgisi;
        private System.Windows.Forms.CheckBox chckingilizce;
        private System.Windows.Forms.CheckBox chckingilizceokul;
        private System.Windows.Forms.Label lbldigerdil;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.ComboBox cmbyoneticilik;
        private System.Windows.Forms.GroupBox grpbxAile;
        private System.Windows.Forms.TextBox txtbuyuk;
        private System.Windows.Forms.TextBox txtortanca;
        private System.Windows.Forms.TextBox txtkucuk;
        private System.Windows.Forms.CheckBox chckbxbuyuk;
        private System.Windows.Forms.CheckBox chckbxortanca;
        private System.Windows.Forms.CheckBox chckbxkucuk;
        private System.Windows.Forms.RadioButton rbtnEvli;
        private System.Windows.Forms.RadioButton rbtnBekar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckbxesicalismiyor;
        private System.Windows.Forms.Label lblbmo;
    }
}

