using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class SumOfDigits
    {
        public static void findsumofdigit(int number)
        {
            int sum = 0,r=0;
            while (number > 0)
            {
                r = number % 10;
                sum = sum + r;
                number = number / 10;
            }
            Console.WriteLine("Sum is = {0}",sum);
            
        }
    }
}
