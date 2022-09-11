using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Abstraction
{
    public abstract class Shape
    {
        public abstract void Area(double side);

        public void AreaDetails()
        {
            Console.WriteLine("Are Details:");
        }
        
    }
}
