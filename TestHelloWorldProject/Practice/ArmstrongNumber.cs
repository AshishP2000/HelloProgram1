using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Practice
{
    public class ArmstrongNumber
    {
        public static void Arm(int number)
        {
            int r = 0,sum=0,temp=number;
            while (number > 0)
            {
                r = number % 10;
                sum = sum + r * r * r;
                number = number / 10;
            }
            //Console.WriteLine(sum);
            if (sum == temp)
            {
                Console.WriteLine("{0} is Armstrong Number", temp);
            }
            else {
                Console.WriteLine("{0} is not Armstrong Number", temp);
            }

        }
    }
}
