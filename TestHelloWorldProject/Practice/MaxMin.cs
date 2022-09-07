using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Practice
{
    public class MaxMin
    {
        public static void Maxmin(int num1,int num2,int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1({0}) is greater than num2({1}) and num3({2})", num1, num2, num3);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2({0}) is greater than num1({1}) and num3({2})", num2, num1, num3);
            }
            else 
            {
                Console.WriteLine("num3({0}) is greater than num1({1}) and num2({2})", num3, num1, num2);
            }
        }
    }
}
