using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Newtonsoft.Json;


namespace StaffManagementVisualApplication
{
    public partial class FormAddUpdate : Form
    {
        private employee staff;
        public FormAddUpdate()
        {
            InitializeComponent();
        }


        



     public void Kaydet()
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
                if (yeni._id == 0)
                {
                    employee.Counter++;
                    yeni._id = employee.Counter;
                }
                if (picbxfoto.ImageLocation != "")
                {
                    yeni.Photo = picbxfoto.ImageLocation;
                }
                yeni.Bmoo = yeni.bmo();
                staff = yeni;
                
               
            }
           
        }
        internal employee Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        
            Kaydet();
            this.Hide();
            
        }

        private void rbtnEvli_CheckedChanged(object sender, EventArgs e)
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

        private void chckbxkucuk_CheckedChanged(object sender, EventArgs e)
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

        private void chckbxortanca_CheckedChanged(object sender, EventArgs e)
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

        private void chckbxbuyuk_CheckedChanged(object sender, EventArgs e)
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

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttecrube_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkucuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtortanca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbuyuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        private void txtlanguage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormAddUpdate_Load(object sender, EventArgs e)
        {
            if (staff != null)
            {
                txtisim.Text = staff._isim;
                txtsoyisim.Text = staff._soyisim;
                txtadres.Text = staff._adres;
                txttecrube.Text = staff._tecrube.ToString();
                txtlanguage.Text = staff._yabanci_dil_sayisi.ToString();
                txtkucuk.Text = staff._kucuk_cocuk.ToString();
                txtortanca.Text = staff._ortanca_cocuk.ToString();
                txtmaas.Text = staff._maas.ToString();
                txtbuyuk.Text = staff._buyuk_cocuk.ToString();
                cmbsehir.SelectedIndex = staff._sehir;
                cmbegitim.SelectedIndex = staff._ogrenim_seviyesi;
                cmbyoneticilik.SelectedIndex = staff._yoneticilik_gorevi;
                if (staff._okul_ingilizce == true)
                    chckingilizceokul.Checked = true;
                if (staff._okul_ingilizce == false)
                    chckingilizceokul.Checked = false;
                if (staff._belge_ingilizce == true)
                    chckingilizce.Checked = true;
                if (staff._belge_ingilizce == false)
                    chckingilizce.Checked = false;
                if (staff._evli_mi == true)
                    rbtnEvli.Checked = true;
                if (staff._evli_mi == false)
                    rbtnBekar.Checked = true;
                if (staff._esi_calismiyomu == true)
                    chckbxesicalismiyor.Checked = true;
                if (staff._esi_calismiyomu == false)
                    chckbxesicalismiyor.Checked = false;
                if (staff._kucuk_cocuk > 0)
                    chckbxkucuk.Checked = true;
                if (staff._kucuk_cocuk == 0)
                    chckbxkucuk.Checked = false;
                if (staff._ortanca_cocuk > 0)
                    chckbxortanca.Checked = true;
                if (staff._ortanca_cocuk == 0)
                    chckbxortanca.Checked = false;
                if (staff._buyuk_cocuk > 0)
                    chckbxbuyuk.Checked = true;
                if (staff._buyuk_cocuk == 0)
                    chckbxbuyuk.Checked = false;
                if(staff.Photo!="")
                {
                    picbxfoto.ImageLocation = staff.Photo;
                }
                lblbmo.Text = "BMO: " + staff.bmo().ToString();
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfoto = new OpenFileDialog();
            openfoto.Filter = "Png|*.png|Jpeg|*.jpeg|Jpg|*.jpg";
            string yol = "";
            if(openfoto.ShowDialog()==DialogResult.OK)
            {
                yol = openfoto.FileName;

            }
            picbxfoto.ImageLocation = yol;
            

        }
    }
}
