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
            if(chckbxmiddle.Checked)
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
            if(chckbxolder.Checked)
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
            if (txtname.Text != "" && txtSurname.Text != "" && txtAddress.Text != "" && txtSalary.Text != "" && cmbcity.SelectedItem!= null && cmbeducation.SelectedItem!=null&&cmbmanagement.SelectedItem!=null)
            {
                
                employee yeni = new employee();
                yeni._isim = txtname.Text;
                yeni._soyisim = txtSurname.Text;
                yeni._adres = txtAddress.Text;
                yeni._maas = Convert.ToInt32(txtSalary.Text);
                if(txtExperince.Text!=null)
                yeni._tecrube = Convert.ToInt32(txtExperince.Text);
                yeni._sehir = cmbcity.SelectedIndex;
                yeni._ogrenim_seviyesi = cmbeducation.SelectedIndex;
                yeni._yoneticilik_gorevi = cmbmanagement.SelectedIndex;
                yeni._belge_ingilizce = chckEnglish.Checked;
                yeni._okul_ingilizce = chckenglishscholl.Checked;
                if(txtlanguage.Text!=null)
                yeni._yabanci_dil_sayisi = Convert.ToInt32(txtlanguage.Text);
                yeni._evli_mi = rbtnMarried.Checked;
                yeni._esi_calisiyomu = chckbxunemployedspouse.Checked;
                if(chckbxlittle.Checked)
                {
                    yeni._kucuk_cocuk = Convert.ToInt32(txtlittle.Text);
                }
                if (chckbxmiddle.Checked)
                {
                    yeni._kucuk_cocuk = Convert.ToInt32(txtmiddle.Text);
                }
                if (chckbxolder.Checked)
                {
                    yeni._kucuk_cocuk = Convert.ToInt32(txtolder.Text);
                }
                lstbxStaffs.Items.Add(yeni);
               

            }

        }
    }
}
