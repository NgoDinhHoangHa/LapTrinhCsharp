using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class HoGiaDinh 
    {
        public List<People> people;
        public String address;
        public HoGiaDinh(List<People> people, String address)
        {
            this.people = people;
            this.address = address;
        }
        public List<People> getPeople()
        {
            return people;
        }

        public void setPeople(List<People> people)
        {
            this.people = people;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }
        public  void Display()
        {
            Console.WriteLine("So ho dan: " + people);
            Console.WriteLine("Dia chi: " + address);
        }
    }
}
