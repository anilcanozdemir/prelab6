using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementVisualApplication
{
    class employee
    {
        private static int counter=0;
        private int sehir;
        private int id;
        private string isim;
        private string soyisim;
        private string adres;
        private int maas=0;
        private double bmoo = 0;
        private bool belge_ingilizce = false;
        private bool okul_ingilizce = false;
        private int yabanci_dil_sayisi=0;
        private int tecrube=0;
        private bool evli_mi=false;
        private bool esi_calismiyomu = false;
        private int kucuk_cocuk = 0;
        private int buyuk_cocuk =0;
        private int ortanca_cocuk = 0;
        private int ogrenim_seviyesi=0;
        private int yoneticlik_gorevi=0;

       
        

        public int _sehir
        {
            get
            {
                return sehir;
            }
            set
            {
                sehir = value;
            }
        }
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

        public int _id
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

        public string _adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
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
        public bool _evli_mi
        {
            get
            {
                return evli_mi;
            }
            set
            {
                evli_mi = value;
            }
        }
        public bool _esi_calismiyomu
        {
            get
            {
                return esi_calismiyomu;
            }
            set
            {
                esi_calismiyomu = value;
            }
        }
        public int _kucuk_cocuk
        {
            get
            {
                return kucuk_cocuk;
            }
            set
            {
                kucuk_cocuk = value;
            }
        }

        public int _ortanca_cocuk
        {
            get
            {
                return ortanca_cocuk;
            }
            set
            {
                ortanca_cocuk = value;
            }
        }

        public int _buyuk_cocuk
        {
            get
            {
                return buyuk_cocuk;
            }
            set
            {
                buyuk_cocuk = value;
            }
        }

        public int _ogrenim_seviyesi
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
        public int _yoneticilik_gorevi
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

        public static int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }

        public double Bmoo
        {
            get
            {
                return bmoo;
            }

            set
            {
                this.bmoo = value;
            }
        }

        public double belge_ingilizce_katsayi()
        {
            double katsayi=0;
            if (belge_ingilizce == true)
            {
                katsayi += 0.2;
            }
            if (okul_ingilizce == true)
            {
                katsayi +=0.2;
            }
            if (_yabanci_dil_sayisi>0)
            {
                katsayi += _yabanci_dil_sayisi * 0.05;
            }
            return katsayi;

        }
        public double yonetici_katsayi()
        {
            double katsayi=0.0;
           switch (_yoneticilik_gorevi){
                case 0:
                    katsayi = 0; break;
                case 1:
                    katsayi += 0.5; break;
                case 2:
                    katsayi += 0.75;break;
                case 3:
                    katsayi +=0.85;break;
                case 4:
                    katsayi +=1; break;
                case 5:
                    katsayi += 0.40; break;
                case 6:
                    katsayi += 0.60; break;
                default:
                    katsayi = 0.0; break;
            }
            return katsayi;
        }

        public double deneyim_katsayi()
        {
            double katsayi = 0.0;
            if(_tecrube>=2 && _tecrube <= 4)
            {
                katsayi += 0.6;
            }
            else if (_tecrube >= 5 && _tecrube <= 9)
            {
                katsayi += 1;
            }
            else if (_tecrube >= 10 && _tecrube <= 14)
            {
                katsayi += 1.20;
            }
            else if (_tecrube >= 15 && _tecrube <= 20)
            {
                katsayi += 1.35;
            }
            else if (_tecrube >20)
            {
                katsayi += 1.50;
            }

            return katsayi;
        }
        public double ogrenim_katsayi()
        {
            double katsayi = 0.0;
            switch (_ogrenim_seviyesi)
            {
                case 0:
                    katsayi += 0;break;
                case 1:
                    katsayi += 0.10;break;
                case 2:
                    katsayi += 0.30; break;
                case 3:
                    katsayi += 0.35; break;
                case 4:
                    katsayi += 0.05; break;
                case 5:
                    katsayi += 0.15; break;

            }


            return katsayi;
        }
        public double il_katsayi()
        {
            double katsayi = 0.0;
            if (_sehir == 33)
            {
                katsayi += 0.15;
            }
            else if(_sehir==34 || _sehir == 5){
                katsayi += 0.10;
            }
            else if(_sehir == 40 || _sehir == 53 || _sehir == 80 || _sehir == 13 ||_sehir==76 || _sehir == 21 || _sehir == 38 || _sehir == 58 )
            {
                katsayi += 0.05;
            }
            else if (_sehir == 60 || _sehir == 51 || _sehir == 27 || _sehir == 52 || _sehir == 7 || _sehir == 28 || _sehir == 15 || _sehir == 25 || _sehir == 10 || _sehir == 8 || _sehir == 19 || _sehir == 47 || _sehir == 0 || _sehir == 32 || _sehir == 9 || _sehir == 16 || _sehir == 6 || _sehir == 31 || _sehir == 14)
            {
                katsayi += 0.03;
            }


            return katsayi;
        }
        public double aile_katsayi()
        {
            double katsayi = 0.0;
            if (_evli_mi)
            {
                if (_esi_calismiyomu==true)
                {
                    katsayi += 0.20;
                }
                if (_buyuk_cocuk >= 2)
                {
                    katsayi += 0.8;
                }
                else if (_buyuk_cocuk >= 1 && ortanca_cocuk > 0)
                {
                    katsayi += 0.7;
                }
                else if (_ortanca_cocuk >= 2)
                {
                    katsayi += 0.6;
                }
                else if (_ortanca_cocuk >= 1 && kucuk_cocuk > 0)
                {
                    katsayi += 0.5;
                }
                else if (_kucuk_cocuk >=2)
                {
                    katsayi += 0.4; 
                }
                else if (_kucuk_cocuk == 1 )
                {
                    katsayi += 0.2;
                }
                else if (_buyuk_cocuk == 1)
                {
                    katsayi += 0.4;
                }
                else if (_ortanca_cocuk == 1)
                {
                    katsayi += 0.3;
                }
                else if (_buyuk_cocuk >= 1 && kucuk_cocuk > 0)
                {
                    katsayi += 0.6;
                }
            }



            return katsayi;
            
        }
       public double bmo()
        {
            double sonhal = 0;
            sonhal += 1+this.aile_katsayi() + this.belge_ingilizce_katsayi() +this.deneyim_katsayi() + this.il_katsayi() + this.ogrenim_katsayi() + this.yonetici_katsayi();
            sonhal *= 4500;

            
            return sonhal;
        }





    }
}
