using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.eat();
            cat.makeSound();
            cat.run();
            Bird bird = new Bird();
            bird.eat();
            bird.makeSound();
            bird.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Thuc an");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo chay ntn?");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an gi?");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo keu the nao?");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay ntn?");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an gi?");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chim hot ntn?");
        }
    }
}