using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Practice
{
    public class ArithmeticOperations
    {
        public static void Arithmetic(int num1,int num2)
        {
            Console.WriteLine("Enter Given Number to get Arithmetic Operations");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Modulus");
            int n = Convert.ToInt32(Console.ReadLine());
            double Ans;
            switch (n)
            {
                case 1:
                    Ans = num1 + num2;
                    Console.WriteLine("Addition: {0}",Ans);
                    break;
                case 2:
                    Ans = num1 - num2;
                    Console.WriteLine("Substraction: {0}", Ans);
                    break;
                case 3:
                    Ans = num1 * num2;
                    Console.WriteLine("Multiplication: {0}", Ans);
                    break;
                case 4:
                    Ans = num1 / num2;
                    Console.WriteLine("Division: {0}", Ans);
                    break;
                case 5:
                    Ans = num1 % num2;
                    Console.WriteLine("Modulus: {0}", Ans);
                    break;
                default:
                    Console.WriteLine("Enter Only Given Number");
                    break;
            }
        }
    }
}
