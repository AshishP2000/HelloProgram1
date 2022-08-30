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
            Console.WriteLine("Dogname = {0} DogBreed = {1} DogColor = {2}", name, breed, color);
        }
    }
}
