using System;
using System.Collections.Generic;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Console.WriteLine("Nhap so luong hoc sinh");
            int n = int.Parse(Console.ReadLine());
            List<Student> student = new List<Student>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu {0}", i + 1);
                Student st = new Student();
                st.Input();
                student.Add(st);
            }
            Console.WriteLine("*************************");
            for(int i =0; i< student.Count; i++)
            {
                student[i].DisPlay();
            }
            Console.WriteLine("*************************");
            List<Student> s = school.getStudent20YearOld();
            Console.WriteLine(school.getStudent20YearOld().Count);
            for (int i =0; i < s.Count; i++)
            {
                Console.WriteLine("ll[lp[" );
                s[i].DisPlay();
            }
            Console.WriteLine("*************************");
            long sg = school.countStudent23YearOldInDN();
            Console.WriteLine("" + sg);
            Console.ReadKey();
        }
    }
}
