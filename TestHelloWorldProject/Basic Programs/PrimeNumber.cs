using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class PrimeNumber
    {
        public static void prime(int m)
        {
            if (m == 1 && m == 2 && m == 3)
            {
                Console.WriteLine(m + "is prime");
            }
            else {
                for (int i = 4; i <= m; i++)
                {
                    if (m % i == 0)
                    {
                        Console.WriteLine(m + "is not prime");
                    }
                    else
                    {
                        Console.WriteLine(m + "is prime");
                    }
                }
            }
            
        }
    }
}
