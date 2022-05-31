using System;
using System.Collections.Generic;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap so ho gia dinh: ");
            int n = Int32.Parse(Console.ReadLine());
            List<BienLai> bl = new List<BienLai>();
            for(int i = 0; i < n; i++)
            {
                BienLai b = new BienLai();
                b.nhapThongTin();
                bl.Add(b);
            }
            for(int i=0;i< bl.Count;i++)
            {
                Console.WriteLine("Ho gia dinh thu: " + i+1);
                bl[i].hienThongTin();
            }
}
}
}
