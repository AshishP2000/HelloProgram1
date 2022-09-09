using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Polymorphism.MethodOverriding
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal Can make Sound");
        }
        public void AnimalDetails()
        {
            Console.WriteLine("Animal Details");
        }
    }
}
