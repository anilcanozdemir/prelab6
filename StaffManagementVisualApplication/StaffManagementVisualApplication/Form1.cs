using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StaffManagementVisualApplication
{
    public partial class YonetimBirimiApplication : Form
    {
        List<employee> employees = new List<employee>();
        int employeecount = 0;
        public YonetimBirimiApplication()
        {
            InitializeComponent();

        }


        private void rbtnMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEvli.Checked)
            {
                grpbxAile.Visible = true;
            }
            else
            {
                grpbxAile.Visible = false;
            }
        }

        private void chckbxlittle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxkucuk.Checked)
            {
                txtkucuk.Visible = true;

            }
            else
            {
                txtkucuk.Visible = false;
            }
        }

        private void chckmiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxortanca.Checked)
            {
                txtortanca.Visible = true;
            }
            else
            {
                txtortanca.Visible = false;
            }

        }

        private void chckbxolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxbuyuk.Checked)
            {
                txtbuyuk.Visible = true;
            }
            else
            {
                txtbuyuk.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\mcali\Documents\prelab6\StaffManagementVisualApplication\StaffManagementVisualApplication\staff.csv", Encoding.GetEncoding("iso-8859-9"), false))
            {
                while (!reader.EndOfStream)
                {
                    string mydesen = reader.ReadLine();
                    string[] Parcalanmisdesen = mydesen.Split(',');
                    employee yeni = new employee();

                    yeni._id = Convert.ToInt32(Parcalanmisdesen[0]);
                    yeni._isim = Parcalanmisdesen[1];
                    yeni._soyisim = Parcalanmisdesen[2];
                    yeni._adres = Parcalanmisdesen[3];
                    yeni._maas = Convert.ToInt32(Parcalanmisdesen[4]);
                    yeni._tecrube = Convert.ToInt32(Parcalanmisdesen[5]);
                    yeni._sehir = Convert.ToInt32(Parcalanmisdesen[6]);
                    yeni._ogrenim_seviyesi = Convert.ToInt32(Parcalanmisdesen[7]);
                    yeni._belge_ingilizce = Convert.ToBoolean(Parcalanmisdesen[8]);
                    yeni._okul_ingilizce = Convert.ToBoolean(Parcalanmisdesen[9]);
                    yeni._yabanci_dil_sayisi = Convert.ToInt32(Parcalanmisdesen[10]);
                    yeni._yoneticilik_gorevi = Convert.ToInt32(Parcalanmisdesen[11]);
                    yeni._evli_mi = Convert.ToBoolean(Parcalanmisdesen[12]);
                    yeni._kucuk_cocuk = Convert.ToInt32(Parcalanmisdesen[13]);
                    yeni._ortanca_cocuk = Convert.ToInt32(Parcalanmisdesen[14]);
                    yeni._buyuk_cocuk = Convert.ToInt32(Parcalanmisdesen[15]);
                    yeni._esi_calismiyomu = Convert.ToBoolean(Parcalanmisdesen[16]);

                    employees.Add(yeni);
                    lstbxGoster.Items.Add(yeni._id + " " + yeni._isim + " " + yeni._soyisim);
                    employeecount = yeni._id;
                }
            }
        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtisim.Text != "" && txtsoyisim.Text != "" && txtadres.Text != "" && txtmaas.Text != "" && cmbsehir.SelectedItem != null && cmbegitim.SelectedItem != null && cmbyoneticilik.SelectedItem != null)
            {

                employee yeni = new employee();
                yeni._isim = txtisim.Text;
                yeni._soyisim = txtsoyisim.Text;
                yeni._adres = txtadres.Text;
                yeni._maas = Convert.ToInt32(txtmaas.Text);
                if (txttecrube.Text != "")
                    yeni._tecrube = Convert.ToInt32(txttecrube.Text);
                yeni._sehir = cmbsehir.SelectedIndex;
                yeni._ogrenim_seviyesi = cmbegitim.SelectedIndex;
                yeni._yoneticilik_gorevi = cmbyoneticilik.SelectedIndex;
                yeni._belge_ingilizce = chckingilizce.Checked;
                yeni._okul_ingilizce = chckingilizceokul.Checked;
                if (txtlanguage.Text != "")
                    yeni._yabanci_dil_sayisi = Convert.ToInt32(txtlanguage.Text);
                yeni._evli_mi = rbtnEvli.Checked;
                yeni._esi_calismiyomu = chckbxesicalismiyor.Checked;
                if (chckbxkucuk.Checked)
                {
                    yeni._kucuk_cocuk = Convert.ToInt32(txtkucuk.Text);
                }
                if (chckbxortanca.Checked)
                {
                    yeni._ortanca_cocuk = Convert.ToInt32(txtortanca.Text);
                }
                if (chckbxbuyuk.Checked)
                {
                    yeni._buyuk_cocuk = Convert.ToInt32(txtbuyuk.Text);
                }
                employeecount++;
                yeni._id = employeecount;
                lstbxGoster.Items.Add(yeni._id + " " + yeni._isim + " " + yeni._soyisim);
                employees.Add(yeni);

                lblbmo.Text = "BMO: " + yeni.bmo().ToString();



            }
            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\mcali\Documents\prelab6\StaffManagementVisualApplication\StaffManagementVisualApplication\staff.csv");
            foreach (employee S in employees)
            {
                myOutputStream.WriteLine(S._id + "," + S._isim + "," + S._soyisim + "," + S._adres + "," + S._maas + "," + S._tecrube + "," + S._sehir + "," + S._ogrenim_seviyesi + "," + S._belge_ingilizce + "," + S._okul_ingilizce + "," + S._yabanci_dil_sayisi + "," + S._yoneticilik_gorevi + "," + S._evli_mi + "," + S._kucuk_cocuk + "," + S._ortanca_cocuk + "," + S._buyuk_cocuk + "," + S._esi_calismiyomu);
            }
            myOutputStream.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbxGoster.SelectedIndex != -1)
            {
                employees.RemoveAt(lstbxGoster.SelectedIndex);
                lstbxGoster.Items.RemoveAt(lstbxGoster.SelectedIndex);






            }
            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\mcali\Documents\prelab6\StaffManagementVisualApplication\StaffManagementVisualApplication\staff.csv");
            foreach (employee S in employees)
            {
                myOutputStream.WriteLine(S._id + "," + S._isim + "," + S._soyisim + "," + S._adres + "," + S._maas + "," + S._tecrube + "," + S._sehir + "," + S._ogrenim_seviyesi + "," + S._belge_ingilizce + "," + S._okul_ingilizce + "," + S._yabanci_dil_sayisi + "," + S._yoneticilik_gorevi + "," + S._evli_mi + "," + S._kucuk_cocuk + "," + S._ortanca_cocuk + "," + S._buyuk_cocuk + "," + S._esi_calismiyomu);
            }
            myOutputStream.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstbxGoster.SelectedItem != null)
            {
                string mydesen = lstbxGoster.SelectedItem.ToString();
                string[] ParcalanmisDesen = mydesen.Split(' ');
                foreach (employee S in employees)
                {
                    if (S._id == Convert.ToInt32(ParcalanmisDesen[0]))
                    {

                        S._isim = txtisim.Text;
                        S._soyisim = txtsoyisim.Text;
                        S._adres = txtadres.Text;
                        S._maas = Convert.ToInt32(txtmaas.Text);
                        if (txttecrube.Text != "")
                            S._tecrube = Convert.ToInt32(txttecrube.Text);
                        S._sehir = cmbsehir.SelectedIndex;
                        S._ogrenim_seviyesi = cmbegitim.SelectedIndex;
                        S._yoneticilik_gorevi = cmbyoneticilik.SelectedIndex;
                        S._belge_ingilizce = chckingilizce.Checked;
                        S._okul_ingilizce = chckingilizceokul.Checked;
                        if (txtlanguage.Text != "")
                            S._yabanci_dil_sayisi = Convert.ToInt32(txtlanguage.Text);
                        S._evli_mi = rbtnEvli.Checked;
                        S._esi_calismiyomu = chckbxesicalismiyor.Checked;
                        if (chckbxkucuk.Checked)
                        {
                            S._kucuk_cocuk = Convert.ToInt32(txtkucuk.Text);
                        }

                        if (rbtnBekar.Checked)
                        {
                            S._kucuk_cocuk = 0;
                            chckbxkucuk.Checked = false;
                            txtkucuk.Text = "";
                            txtbuyuk.Text = "";
                            txtortanca.Text = "";
                            S._ortanca_cocuk = 0;
                            chckbxortanca.Checked = false;
                            S._buyuk_cocuk = 0;
                            chckbxkucuk.Checked = false;
                            chckbxesicalismiyor.Checked = false;
                        }

                        
                        if (chckbxortanca.Checked)
                        {
                            S._ortanca_cocuk = Convert.ToInt32(txtortanca.Text);
                        }
                        
                        if (chckbxbuyuk.Checked)
                        {
                            S._buyuk_cocuk = Convert.ToInt32(txtbuyuk.Text);
                        }
                        
                        string guncel = "";
                        guncel += S._id + " " + S._isim + " " + S._soyisim;

                        lstbxGoster.Items.Insert(S._id - 1, guncel);
                        lstbxGoster.Items.RemoveAt(S._id);
                        lblbmo.Text = "BMO: " + S.bmo().ToString();

                    }
                }
            }
            StreamWriter myOutputStream = new StreamWriter(@"C:\Users\mcali\Documents\prelab6\StaffManagementVisualApplication\StaffManagementVisualApplication\staff.csv");
            foreach (employee S in employees)
            {
                myOutputStream.WriteLine(S._id + "," + S._isim + "," + S._soyisim + "," + S._adres + "," + S._maas + "," + S._tecrube + "," + S._sehir + "," + S._ogrenim_seviyesi + "," + S._belge_ingilizce + "," + S._okul_ingilizce + "," + S._yabanci_dil_sayisi + "," + S._yoneticilik_gorevi + "," + S._evli_mi + "," + S._kucuk_cocuk + "," + S._ortanca_cocuk + "," + S._buyuk_cocuk + "," + S._esi_calismiyomu);
            }
            myOutputStream.Close();
        }

        private void lstbxStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxGoster.SelectedItem != null)
            {
                string mydesen = lstbxGoster.SelectedItem.ToString();
                string[] ParcalanmisDesen = mydesen.Split(' ');
                foreach (employee S in employees)
                {
                    if (S._id == Convert.ToInt32(ParcalanmisDesen[0]))
                    {
                        txtisim.Text = S._isim;
                        txtsoyisim.Text = S._soyisim;
                        txtadres.Text = S._adres;
                        txttecrube.Text = S._tecrube.ToString();
                        txtlanguage.Text = S._yabanci_dil_sayisi.ToString();
                        txtkucuk.Text = S._kucuk_cocuk.ToString();
                        txtortanca.Text = S._ortanca_cocuk.ToString();
                        txtmaas.Text = S._maas.ToString();
                        txtbuyuk.Text = S._buyuk_cocuk.ToString();
                        cmbsehir.SelectedIndex = S._sehir;
                        cmbegitim.SelectedIndex = S._ogrenim_seviyesi;
                        cmbyoneticilik.SelectedIndex = S._yoneticilik_gorevi;
                        if (S._okul_ingilizce == true)
                            chckingilizceokul.Checked = true;
                        if (S._okul_ingilizce == false)
                            chckingilizceokul.Checked = false;
                        if (S._belge_ingilizce == true)
                            chckingilizce.Checked = true;
                        if (S._belge_ingilizce == false)
                            chckingilizce.Checked = false;
                        if (S._evli_mi == true)
                            rbtnEvli.Checked = true;
                        if (S._evli_mi == false)
                            rbtnBekar.Checked = true;
                        if (S._esi_calismiyomu == true)
                            chckbxesicalismiyor.Checked = true;
                        if (S._esi_calismiyomu == false)
                            chckbxesicalismiyor.Checked = false;
                        if (S._kucuk_cocuk > 0)
                            chckbxkucuk.Checked = true;
                        if (S._kucuk_cocuk == 0)
                            chckbxkucuk.Checked = false;
                        if (S._ortanca_cocuk > 0)
                            chckbxortanca.Checked = true;
                        if (S._ortanca_cocuk == 0)
                            chckbxkucuk.Checked = false;
                        if (S._buyuk_cocuk > 0)
                            chckbxbuyuk.Checked = true;
                        if (S._buyuk_cocuk == 0)
                            chckbxbuyuk.Checked = false;
                        lblbmo.Text ="BMO: "+ S.bmo().ToString();
                    }
                }
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtExperince_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtlittle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmiddle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtlanguage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
