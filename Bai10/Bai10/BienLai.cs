using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class BienLai
    {
        private KhachHang kh;
        private int chiSoCu;
        private int chiSoMoi;
        private double tienTra;
        public BienLai()
        {

        }
        public BienLai(KhachHang kh, int chiSoCu, int chiSoMoi, double tienTra)
        {
            this.kh = kh;
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
            this.tienTra = tienTra;
        }
        //---------------------
        public void nhapThongTin()
        {
            this.kh = new KhachHang();
            this.kh.nhapThongTin();
            Console.WriteLine("Nhap chi so cu: ");
            chiSoCu = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chi so moi: ");
            chiSoMoi = Int32.Parse(Console.ReadLine());
            this.tienTra = (double)(this.chiSoMoi - this.chiSoCu) * 5;
        }
        //--------------------
        public void hienThongTin()
        {
            this.kh.hienThongTin();
            Console.WriteLine("Chi so cu: " + chiSoCu);
            Console.WriteLine("Chi so moi: " + chiSoMoi);
            Console.WriteLine("So tien phai tra: " + tienTra);
        }
    }
}
