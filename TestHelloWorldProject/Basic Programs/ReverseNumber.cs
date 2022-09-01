using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class ReverseNumber
    {
        public static void Reverse(int number)
        {
            int r = 0, reverse=0;
            
            while (number > 0)
            {
                r = number % 10;
                reverse = (reverse * 10) + r;
                //Console.Write(r);
                number = number / 10;
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Number: {0}",reverse);
        }
    }
}
