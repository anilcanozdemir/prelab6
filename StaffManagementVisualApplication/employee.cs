using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementVisualApplication
{
    class employee
    {
        private string id;
        private string isim;
        private string soyisim;
        private int maas;
        private bool belge_ingilizce = false;
        private bool okul_ingilizce = false;
        private int yabanci_dil_sayisi;
        private int tecrube;
        private int cocuk_sayisi;
        private string ogrenim_seviyesi;
        private string yoneticlik_gorevi;

        public string _isim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }

        public string _id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string _soyisim
        {
            get
            {
                return soyisim;
            }
            set
            {
                soyisim = value;
            }
        }

        public int _maas
        {
            get
            {
                return maas;
            }
            set
            {
                maas = value;
            }
        }

        public int _yabanci_dil_sayisi
        {
            get
            {
                return yabanci_dil_sayisi;
            }
            set
            {
                yabanci_dil_sayisi = value;
            }
        }
        public int _tecrube
        {
            get
            {
                return tecrube;
            }
            set
            {
                tecrube = value;
            }
        }
        public int _cocuk_sayisi
        {
            get
            {
                return cocuk_sayisi;
            }
            set
            {
                cocuk_sayisi = value;
            }
        }
        public string _ogrenim_seviyesi
        {
            get
            {
                return ogrenim_seviyesi;
            }
            set
            {
                ogrenim_seviyesi = value;
            }
        }
        public string _yoneticilik_gorevi
        {
            get
            {
                return yoneticlik_gorevi;
            }
            set
            {
                yoneticlik_gorevi = value;
            }
        }

        public bool _belge_ingilizce
        {
            get
            {
                return belge_ingilizce;
            }
            set
            {
                belge_ingilizce = value;
            }
        }

        public bool _okul_ingilizce
        {
            get
            {
                return okul_ingilizce;
            }
            set
            {
                okul_ingilizce = value;
            }
        }

        public double belge_ingilizce_katsayi(employee kisi)
        {
            double katsayi=0;
            if (kisi.belge_ingilizce == true)
            {
                katsayi += 0.2;
            }
            if (kisi.okul_ingilizce == true)
            {
                katsayi +=0.2;
            }
            if (kisi._yabanci_dil_sayisi>0)
            {
                katsayi += kisi._yabanci_dil_sayisi * 0.05;
            }
            return katsayi;

        }
        public double yonetici_katsayi(employee kisi)
        {
            double katsayi=0;
            

            return katsayi;
        }






    }
}
