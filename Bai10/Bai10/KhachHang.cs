using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class KhachHang
    {
        private String hoTen;
        private int soNha;
        private String maCongTo;

        public KhachHang()
        {
        }
        public KhachHang(String hoTen, int soNha, String maCongTo)
        {
            this.hoTen = hoTen;
            this.soNha = soNha;
            this.maCongTo = maCongTo;
        }
        //-----------
        public void nhapThongTin()
        {
            Console.WriteLine("Nhap ho ten khach hang: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap so nha: ");
            soNha = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma cong to: ");
            maCongTo = Console.ReadLine();
        }
        public void hienThongTin()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("So nha: " + soNha);
            Console.WriteLine("So cong to: " + maCongTo);
        }
    }
}
