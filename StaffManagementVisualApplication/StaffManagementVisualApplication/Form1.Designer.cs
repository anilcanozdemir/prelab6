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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstviewİsci = new System.Windows.Forms.ListView();
            this.btnYükle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.prgrsbrsürec = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstviewİsci
            // 
            this.lstviewİsci.CheckBoxes = true;
            this.lstviewİsci.FullRowSelect = true;
            this.lstviewİsci.GridLines = true;
            this.lstviewİsci.Location = new System.Drawing.Point(12, 12);
            this.lstviewİsci.Name = "lstviewİsci";
            this.lstviewİsci.Size = new System.Drawing.Size(769, 316);
            this.lstviewİsci.TabIndex = 1;
            this.lstviewİsci.UseCompatibleStateImageBehavior = false;
            this.lstviewİsci.View = System.Windows.Forms.View.Details;
            this.lstviewİsci.DoubleClick += new System.EventHandler(this.lstviewİsci_DoubleClick);
            // 
            // btnYükle
            // 
            this.btnYükle.Location = new System.Drawing.Point(12, 334);
            this.btnYükle.Name = "btnYükle";
            this.btnYükle.Size = new System.Drawing.Size(75, 23);
            this.btnYükle.TabIndex = 2;
            this.btnYükle.Text = "Yükle";
            this.btnYükle.UseVisualStyleBackColor = true;
            this.btnYükle.Click += new System.EventHandler(this.btnYükle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(93, 334);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(256, 335);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // prgrsbrsürec
            // 
            this.prgrsbrsürec.Location = new System.Drawing.Point(12, 364);
            this.prgrsbrsürec.Name = "prgrsbrsürec";
            this.prgrsbrsürec.Size = new System.Drawing.Size(400, 20);
            this.prgrsbrsürec.TabIndex = 6;
            // 
            // YonetimBirimiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 496);
            this.Controls.Add(this.prgrsbrsürec);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYükle);
            this.Controls.Add(this.lstviewİsci);
            this.Controls.Add(this.btnAdd);
            this.Name = "YonetimBirimiApplication";
            this.Text = "YonetimBirimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YonetimBirimiApplication_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstviewİsci;
        private System.Windows.Forms.Button btnYükle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ProgressBar prgrsbrsürec;
    }
}

