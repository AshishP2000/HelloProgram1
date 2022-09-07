using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Practice
{
    public class SwapNumber
    {
        public static void Swap(int num1,int num2)
        {
            int num3;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("Number 1: {0}, Number 2: {1}", num1, num2);
            
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After Swapping");
            Console.WriteLine("Number 1: {0}, Number 2: {1}", num1,num2);
        }
    }
}
