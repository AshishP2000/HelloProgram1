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
            int i,count=0;
            for (i = 1; i <= m; i++)
            {
                if (m % i == 0)
                {
                    count++;
                }
            }
            if (count == 2 || m==1)
            {
                Console.WriteLine("It is Prime Number!...");
            }
            else {
                Console.WriteLine("It is Not Prime Number!...");
            }
            
        }
    }
}
