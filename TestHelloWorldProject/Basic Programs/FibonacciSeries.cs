using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.Basic_Programs
{
    public class FibonacciSeries
    {
        public static void FindSeries(int n)
        {
            int first = 0;
            int second = 1;
            int third = 0;
            Console.Write("{0} {1}", first, second);
            for (int i=2;i<n;i++)
            {
                third = first + second;
                Console.Write(" {0}",third);
                first = second;
                second = third;
            }
            
            //Console.WriteLine("{0}",third);
           
            



        }
    }
}
