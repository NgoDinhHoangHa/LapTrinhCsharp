using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class People
    {
        public string fullName {get; set; }
        public string Old { get; set; }
        public string Job { get; set; }
        public string ID { get; set; }
        public void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap cac cuoc cong dan: ");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            Old = Console.ReadLine();
            Console.WriteLine("Nhap nghe nghiep: ");
            Job = Console.ReadLine();
        }
        public  void Display()
        {
            Console.WriteLine("Ten: {0}, Can cuoc: {1}, Tuoi: {2}, Nghe nghiep: {3}", fullName, ID, Old, Job);
        }
}
}
