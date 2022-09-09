using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Polymorphism.MethodOverriding
{
    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("It sounds like meow!..");
        }
    }
}
