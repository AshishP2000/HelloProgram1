using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.color = "brown";
            dog1.name = "Tommy";
            dog1.breed = "Labour";

            Console.WriteLine(dog1.color);
            dog1.dogdetails();

        }
    }
}
