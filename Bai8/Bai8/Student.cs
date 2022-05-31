using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Student
    {
        private String name { get; set;}
        private int age { get; set; }
        private String school { get; set; }

        public Student(String name, int age, String school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }
    }
}
