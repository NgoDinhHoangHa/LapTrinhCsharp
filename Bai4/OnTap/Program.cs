using System;
using System.Collections.Generic;

namespace OnTap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            KhuPho khuPho213 = new KhuPho();
            Console.WriteLine("Nhap so ho dan: ");
            int n213 = int.Parse(Console.ReadLine());
            int soNguoi213 =0;
            List<People> people213 = null;
            for (int i = 0; i< n213; i++)
            {
                Console.WriteLine("Nhap dia chi: ");
                String adr213 = Console.ReadLine();
                people213 = new List<People>();
                Console.WriteLine("Nhap so nguoi trong gia dinh: ");
                soNguoi213 = int.Parse(Console.ReadLine());
                for( int j213 = 0; j213 < soNguoi213; j213++)
                {
                    People p = new People();
                    p.Input();
                    people213.Add(p);
                }
                khuPho213.addHoGiaDinh(new HoGiaDinh(people213, adr213));
            }
            for(int i213 =0; i213<n213; i213++)
            {
                for (int j213 = 0; j213 < khuPho213.hoGiaDinhs213.Count;j213++)
                {
                    for(int k213 =0; k213 < soNguoi213; k213++)
                    {
                        people213[k213].Display();
                    }
                }
            }
            Console.ReadKey();
        }       
}
}
