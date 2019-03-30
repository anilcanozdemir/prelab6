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
    public partial class FormAddUpdate : Form
    {
        private employee yeni;
        public FormAddUpdate()
        {
            InitializeComponent();
        }

        internal employee Yeni
        {
            get
            {
                return yeni;
            }

            set
            {
                yeni = value;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
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
            }
            if (yeni._id ==null) {
                employee.Counter++;
                yeni._id = employee.Counter;
            }
            
        }
    }
}
