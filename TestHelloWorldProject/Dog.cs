using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject
{
    public class Dog
    {
        public string name;
        public string color;
        public string breed;

        public void walk()
        {
            Console.WriteLine("{0} can walk", name);
        }

        public void dogdetails()
        {
            Console.WriteLine("Dog name = {0}\t Dog Breed = {1}\t Dog Color = {2}", name, breed, color);
        }
    }
}
