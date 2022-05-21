using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Student
    {
        public String name { get; set; }
        public int age { get; set; }
        public String hometown { get; set; }
        public string classStudent { get; set; }

        public Student(String name, int age, String hometown, string classStudent)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.classStudent = classStudent;
        }

        public Student()
        {
        }

        public void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap que quan: ");
            hometown = Console.ReadLine();
            Console.WriteLine("Nhap lop: ");
            classStudent = Console.ReadLine();
        }
        public void DisPlay()
        {
            Console.WriteLine("Ho ten: " +name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Que quan: " + hometown);
            Console.WriteLine("Lop: " + classStudent);
        }
    }
}
