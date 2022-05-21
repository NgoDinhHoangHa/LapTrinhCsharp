using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class School
    {
        private List<Student> students = new List<Student>();

        public School()
        {
        }

        public void add(Student student)
        {
           students.Add(student);
        }

        public List<Student> getStudent20YearOld()
        {
            List<Student> st = new List<Student>();
            for(int i = 0; i <students.Count;i++)
            {
                if (students[i].age > 20)
                {
                    st.Add(students[i]);
                }
            }
            for (int i = 0; i < st.Count; i++)
            {

                Console.WriteLine(st[i]);


            }
            return st;
        }

        public long countStudent23YearOldInDN()
        {
            int count = 0;
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].age > 23 && this.students[i].hometown.Equals("DN"))
                {
                    count++;
                }
            }
            return count;
            
        }
    }
}
