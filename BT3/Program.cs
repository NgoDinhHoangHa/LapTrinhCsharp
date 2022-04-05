using System;
using System.Collections;

namespace BT3
{
    class Program
    {
        struct SinhVien213
        {
            public string maSV213;
            public string tenSV213;
            public string lop213;
            public string sdt213;
            public int diemToan213;
            public int diemLy213;
            public int diemHoa213;
        }
        enum SinhVienNam213
        {
            NAM_1 = 1,
            NAM_2 = 2,
            NAM_3 = 3,
            NAM_4 = 4
        }

        static void NhapThongTinSinhVien(out SinhVien213 sv)
        {
            Console.Write("Ma sinh vien: ");
            sv.maSV213 = Console.ReadLine();
            Console.Write("Ten sinh vien: ");
            sv.tenSV213 = Console.ReadLine();
            Console.Write("Lop: ");
            sv.lop213 = Console.ReadLine();
            Console.Write("So dien thoai: ");
            sv.sdt213 = Console.ReadLine();
        math_again:
            Console.Write("Diem toan: ");
            if (int.TryParse(Console.ReadLine(), out sv.diemToan213) == false || (sv.diemToan213 > 10 || sv.diemToan213 < 0))
                goto math_again;
            physics_again:
            Console.Write("Diem ly: ");
            if (int.TryParse(Console.ReadLine(), out sv.diemLy213) == false || (sv.diemLy213 > 10 || sv.diemLy213 < 0))
                goto physics_again;
            chemistry_again:
            Console.Write("Diem hoa: ");
            if (int.TryParse(Console.ReadLine(), out sv.diemHoa213) == false || (sv.diemHoa213 > 10 || sv.diemHoa213 < 0))
                goto chemistry_again;
        }

        static void XuatThongTinSinhVien(SinhVien213 sv)
        {
            Console.WriteLine("Ma sinh vien: " + sv.maSV213);
            Console.WriteLine("Ten sinh vien: " + sv.tenSV213);
            Console.WriteLine("Lop: " + sv.lop213);
            Console.WriteLine("So dien thoai: " + sv.sdt213);
            Console.WriteLine("Diem toan: " + sv.diemToan213);
            Console.WriteLine("Diem ly: " + sv.diemLy213);
            Console.WriteLine("Diem hoa: " + sv.diemHoa213);
            Console.WriteLine("----------------------------------------------");
        }

        static void TimSinhVien(ArrayList dsSV213, string tenSinhVien213)
        {
            foreach (SinhVien213 sv213 in dsSV213)
            {
                if (sv213.tenSV213.Equals(tenSinhVien213) == true)
                {
                    XuatThongTinSinhVien(sv213);
                    float dtb213 = (sv213.diemHoa213 + sv213.diemLy213 + sv213.diemToan213) / 3;
                    Console.WriteLine("Diem trung binh: " + dtb213);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayList dsSinhVien213 = new ArrayList();
            while (true)
            {
                SinhVien213 s213;
                NhapThongTinSinhVien(out s213);
                dsSinhVien213.Add(s213);
                Console.Write("Tiep tuc? y/n: ");
                if (Console.ReadLine().Equals("y") == false)
                    break;
            }
            foreach (SinhVien213 sinhVien213 in dsSinhVien213)
            {
                XuatThongTinSinhVien(sinhVien213);
            }
            Console.Write("Nhap ten sinh vien can tim: ");
            TimSinhVien(dsSinhVien213, Console.ReadLine());
        }
    }
}
