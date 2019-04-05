using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaffManagementVisualApplication
{
    class parttime :employee
    {
      

        
        public override double bmo()
        {
            double sonhal = 0;
            sonhal += 1 + this.aile_katsayi() + this.belge_ingilizce_katsayi() + this.deneyim_katsayi() + this.il_katsayi() + this.ogrenim_katsayi() + this.yonetici_katsayi();
            sonhal *= 4500;


            return sonhal/2;
        }
        


       

    }
}
