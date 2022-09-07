using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Practice
{
    public class EvenOdd
    {
        public static void Evenodd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else {
                Console.WriteLine("Given Number is Odd");
            }
        }
    }
}
