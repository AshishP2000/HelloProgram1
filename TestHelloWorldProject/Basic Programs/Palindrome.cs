using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class Palindrome
    {
        public static void PalindromeNumber(int number)
        {
            int r = 0, reverse = 0;
            int temp = number;
            while (number > 0)
            {
                r = number % 10;
                reverse = (reverse * 10) + r;
                //Console.Write(r);
                number = number / 10;
            }
            //Console.WriteLine();
            if (temp == reverse)
            {
                Console.WriteLine("This is Palindrome Number!...");
            }
            else 
            {
                Console.WriteLine("This is not Palindrome Number!...");
            }
        }
    }
}
