using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Abstraction
{
    public class Square : Shape
    {
        
        public override void Area(double side)
        {
            double area = side * side;
            Console.WriteLine("Area of Square is: {0}",area);
        }
    }
}
