using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnTap
{
    class KhuPho
    {
        public List<HoGiaDinh> hoGiaDinhs213;
        public KhuPho()
        {
            this.hoGiaDinhs213 = new List<HoGiaDinh>();
        }
        public List<HoGiaDinh> getHoGiaDinh()
        {
            return hoGiaDinhs213;
        }

        public void sethoGiaDinh(List<HoGiaDinh> hoGiaDinhs213)
        {
            this.hoGiaDinhs213 = hoGiaDinhs213;
        }

        public void addHoGiaDinh(HoGiaDinh hoGiaDinh213)
        {
            this.hoGiaDinhs213.Add(hoGiaDinh213);
        }
    }
}
