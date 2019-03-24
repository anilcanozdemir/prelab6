using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagementVisualApplication
{
    public partial class StaffManagementApplication : Form
    {
        List<employee> employees=new List<employee>();
        int employeecount=0;
        public StaffManagementApplication()
        {
            InitializeComponent();

        }


        private void rbtnMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMarried.Checked)
            {
                grpbxFamily.Visible = true;
            }
            else
            {
                grpbxFamily.Visible = false;
            }
        }

        private void chckbxlittle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxlittle.Checked)
            {
                txtlittle.Visible = true;

            }
            else
            {
                txtlittle.Visible = false;
            }
        }

        private void chckmiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxmiddle.Checked)
            {
                txtmiddle.Visible = true;
            }
            else
            {
                txtmiddle.Visible = false;
            }

        }

        private void chckbxolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxolder.Checked)
            {
                txtolder.Visible = true;
            }
            else
            {
                txtolder.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnMarried.Checked = false;
            rbtnSingle.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtSurname.Text != "" && txtAddress.Text != "" && txtSalary.Text != "" && cmbcity.SelectedItem != null && cmbeducation.SelectedItem != null && cmbmanagement.SelectedItem != null)
            {

                employee yeni = new employee();
                yeni._isim = txtname.Text;
                yeni._soyisim = txtSurname.Text;
                yeni._adres = txtAddress.Text;
                yeni._maas = Convert.ToInt32(txtSalary.Text);
                if (txtExperince.Text != "")
                    yeni._tecrube = Convert.ToInt32(txtExperince.Text);
                yeni._sehir = cmbcity.SelectedIndex;
                yeni._ogrenim_seviyesi = cmbeducation.SelectedIndex;
                yeni._yoneticilik_gorevi = cmbmanagement.SelectedIndex;
                yeni._belge_ingilizce = chckEnglish.Checked;
                yeni._okul_ingilizce = chckenglishscholl.Checked;
                if (txtlanguage.Text != "")
                    yeni._yabanci_dil_sayisi = Convert.ToInt32(txtlanguage.Text);
                yeni._evli_mi = rbtnMarried.Checked;
                yeni._esi_calismiyomu = chckbxunemployedspouse.Checked;
                if (chckbxlittle.Checked)
                {
                    yeni._kucuk_cocuk = Convert.ToInt32(txtlittle.Text);
                }
                if (chckbxmiddle.Checked)
                {
                    yeni._ortanca_cocuk = Convert.ToInt32(txtmiddle.Text);
                }
                if (chckbxolder.Checked)
                {
                    yeni._buyuk_cocuk = Convert.ToInt32(txtolder.Text);
                }
                employeecount++;
                yeni._id = employeecount;
                lstbxStaffs.Items.Add(yeni._id + " " + yeni._isim + " " + yeni._soyisim);
                employees.Add(yeni);
                
                lblbmo.Text = yeni.bmo().ToString();
                


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbxStaffs.SelectedIndex != -1)
            {
                employees.RemoveAt(lstbxStaffs.SelectedIndex);
                lstbxStaffs.Items.RemoveAt(lstbxStaffs.SelectedIndex);
                


               


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mydesen = lstbxStaffs.SelectedItem.ToString();
            string[] ParcalanmisDesen = mydesen.Split(' ');
            foreach (employee S in employees)
            {
                if (S._id == Convert.ToInt32(ParcalanmisDesen[0]))
                {
                   
                    S._isim = txtname.Text;
                    S._soyisim = txtSurname.Text;
                    S._adres = txtAddress.Text;
                    S._maas = Convert.ToInt32(txtSalary.Text);
                    if (txtExperince.Text != "")
                        S._tecrube = Convert.ToInt32(txtExperince.Text);
                    S._sehir = cmbcity.SelectedIndex;
                    S._ogrenim_seviyesi = cmbeducation.SelectedIndex;
                    S._yoneticilik_gorevi = cmbmanagement.SelectedIndex;
                    S._belge_ingilizce = chckEnglish.Checked;
                    S._okul_ingilizce = chckenglishscholl.Checked;
                    if (txtlanguage.Text != "")
                        S._yabanci_dil_sayisi = Convert.ToInt32(txtlanguage.Text);
                    S._evli_mi = rbtnMarried.Checked;
                    S._esi_calismiyomu = chckbxunemployedspouse.Checked;
                    if (chckbxlittle.Checked)
                    {
                        S._kucuk_cocuk = Convert.ToInt32(txtlittle.Text);
                    }
                    if (chckbxmiddle.Checked)
                    {
                        S._ortanca_cocuk = Convert.ToInt32(txtmiddle.Text);
                    }
                    if (chckbxolder.Checked)
                    {
                        S._buyuk_cocuk = Convert.ToInt32(txtolder.Text);
                    }
                    string guncel = "";
                    guncel += S._id + " " + S._isim + " " + S._soyisim;

                    lstbxStaffs.Items.Insert(S._id - 1, guncel);
                    lstbxStaffs.Items.RemoveAt(S._id);
                    
                }
            }
        }

        private void lstbxStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxStaffs.SelectedItem != null)
            {
                string mydesen = lstbxStaffs.SelectedItem.ToString();
                string[] ParcalanmisDesen = mydesen.Split(' ');
                foreach (employee S in employees)
                {
                    if (S._id == Convert.ToInt32(ParcalanmisDesen[0]))
                    {
                        txtname.Text = S._isim;
                        txtSurname.Text = S._soyisim;
                        txtAddress.Text = S._adres;
                        txtExperince.Text = S._tecrube.ToString();
                        txtlanguage.Text = S._yabanci_dil_sayisi.ToString();
                        txtlittle.Text = S._kucuk_cocuk.ToString();
                        txtmiddle.Text = S._ortanca_cocuk.ToString();
                        txtSalary.Text = S._maas.ToString();
                        txtolder.Text = S._buyuk_cocuk.ToString();
                        cmbcity.SelectedIndex = S._sehir;
                        cmbeducation.SelectedIndex = S._ogrenim_seviyesi;
                        cmbmanagement.SelectedIndex = S._yoneticilik_gorevi;
                        if (S._okul_ingilizce == true)
                            chckenglishscholl.Checked = true;
                        if (S._belge_ingilizce == true)
                            chckEnglish.Checked = true;
                        if (S._evli_mi == true)
                            rbtnMarried.Checked = true;
                        if (S._evli_mi == false)
                            rbtnSingle.Checked = true;
                        if (S._esi_calismiyomu == true)
                            chckbxunemployedspouse.Checked = true;
                        if (S._kucuk_cocuk > 0)
                            chckbxlittle.Checked = true;
                        if (S._kucuk_cocuk == 0)
                            chckbxlittle.Checked = false;
                        if (S._ortanca_cocuk > 0)
                            chckbxmiddle.Checked = true;
                        if (S._ortanca_cocuk == 0)
                            chckbxlittle.Checked = false;
                        if (S._buyuk_cocuk > 0)
                            chckbxolder.Checked = true;
                        if (S._buyuk_cocuk == 0)
                            chckbxlittle.Checked = false;
                        lblbmo.Text = S.bmo().ToString();
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
