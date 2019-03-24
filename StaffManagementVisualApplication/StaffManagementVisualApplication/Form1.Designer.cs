namespace StaffManagementVisualApplication
{
    partial class Form1
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
            this.lstbxStaffs = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblexp = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbleducation = new System.Windows.Forms.Label();
            this.txtExperince = new System.Windows.Forms.TextBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.cmbeducation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chckEnglish = new System.Windows.Forms.CheckBox();
            this.chckenglishscholl = new System.Windows.Forms.CheckBox();
            this.lblotherlanguage = new System.Windows.Forms.Label();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbxStaffs
            // 
            this.lstbxStaffs.FormattingEnabled = true;
            this.lstbxStaffs.Location = new System.Drawing.Point(12, 12);
            this.lstbxStaffs.Name = "lstbxStaffs";
            this.lstbxStaffs.Size = new System.Drawing.Size(270, 264);
            this.lstbxStaffs.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(434, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(596, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(434, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(434, 59);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(434, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(434, 111);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(378, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(346, 59);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(67, 13);
            this.lblsurname.TabIndex = 9;
            this.lblsurname.Text = "Family Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(368, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(377, 111);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(36, 13);
            this.lblsalary.TabIndex = 11;
            this.lblsalary.Text = "Salary";
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Location = new System.Drawing.Point(353, 137);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(60, 13);
            this.lblexp.TabIndex = 12;
            this.lblexp.Text = "Experience";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(377, 170);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 13);
            this.lblcity.TabIndex = 13;
            this.lblcity.Text = "City";
            // 
            // lbleducation
            // 
            this.lbleducation.AutoSize = true;
            this.lbleducation.Location = new System.Drawing.Point(359, 193);
            this.lbleducation.Name = "lbleducation";
            this.lbleducation.Size = new System.Drawing.Size(55, 13);
            this.lbleducation.TabIndex = 14;
            this.lbleducation.Text = "Education";
            // 
            // txtExperince
            // 
            this.txtExperince.Location = new System.Drawing.Point(434, 137);
            this.txtExperince.Name = "txtExperince";
            this.txtExperince.Size = new System.Drawing.Size(100, 20);
            this.txtExperince.TabIndex = 15;
            // 
            // cmbcity
            // 
            this.cmbcity.DropDownWidth = 100;
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
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
            this.cmbcity.Location = new System.Drawing.Point(434, 163);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(100, 21);
            this.cmbcity.TabIndex = 16;
            // 
            // cmbeducation
            // 
            this.cmbeducation.DropDownWidth = 100;
            this.cmbeducation.FormattingEnabled = true;
            this.cmbeducation.Items.AddRange(new object[] {
            "Meslek alanı ile ilgili yüksek lisans",
            "Meslek alanı ile ilgili doktora",
            "Meslek alanı ile ilgili doçentlik",
            "Meslek alanı ile ilgili olmayan yüksek lisans",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.cmbeducation.Location = new System.Drawing.Point(434, 193);
            this.cmbeducation.Name = "cmbeducation";
            this.cmbeducation.Size = new System.Drawing.Size(100, 21);
            this.cmbeducation.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yabancı Dil Bilgisi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chckEnglish
            // 
            this.chckEnglish.AutoSize = true;
            this.chckEnglish.Location = new System.Drawing.Point(382, 259);
            this.chckEnglish.Name = "chckEnglish";
            this.chckEnglish.Size = new System.Drawing.Size(152, 17);
            this.chckEnglish.TabIndex = 19;
            this.chckEnglish.Text = "Belgelenmiş İngilizce Bilgisi";
            this.chckEnglish.UseVisualStyleBackColor = true;
            // 
            // chckenglishscholl
            // 
            this.chckenglishscholl.AutoSize = true;
            this.chckenglishscholl.Location = new System.Drawing.Point(382, 282);
            this.chckenglishscholl.Name = "chckenglishscholl";
            this.chckenglishscholl.Size = new System.Drawing.Size(204, 17);
            this.chckenglishscholl.TabIndex = 20;
            this.chckenglishscholl.Text = "İngilizce Eğitim Veren Okul Mezuniyeti";
            this.chckenglishscholl.UseVisualStyleBackColor = true;
            // 
            // lblotherlanguage
            // 
            this.lblotherlanguage.AutoSize = true;
            this.lblotherlanguage.Location = new System.Drawing.Point(346, 305);
            this.lblotherlanguage.Name = "lblotherlanguage";
            this.lblotherlanguage.Size = new System.Drawing.Size(136, 13);
            this.lblotherlanguage.TabIndex = 21;
            this.lblotherlanguage.Text = "Diğer Belgelenmiş Dil Sayısı";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(515, 302);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(19, 20);
            this.txtlanguage.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 394);
            this.Controls.Add(this.txtlanguage);
            this.Controls.Add(this.lblotherlanguage);
            this.Controls.Add(this.chckenglishscholl);
            this.Controls.Add(this.chckEnglish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbeducation);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.txtExperince);
            this.Controls.Add(this.lbleducation);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblexp);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxStaffs);
            this.Name = "Form1";
            this.Text = "StaffManagementApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxStaffs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblexp;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbleducation;
        private System.Windows.Forms.TextBox txtExperince;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.ComboBox cmbeducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckEnglish;
        private System.Windows.Forms.CheckBox chckenglishscholl;
        private System.Windows.Forms.Label lblotherlanguage;
        private System.Windows.Forms.TextBox txtlanguage;
    }
}

