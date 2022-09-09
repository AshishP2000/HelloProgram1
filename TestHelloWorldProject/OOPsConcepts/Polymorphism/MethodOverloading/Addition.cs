using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Polymorphism.MethodOverloading
{
    public class Addition
    {
        public static void Add(int a,int b)
        {
            int c = 0;
            c = a + b;
            Console.WriteLine("Addition = {0}", c);
        }
        public static void Add(int a, int b,int c)
        {
            int z = 0;
            z = a + b + c;
            Console.WriteLine("Addition = {0}",z);
        }
        public static void Add(float a, int b)
        {
            float z = 0;
            z = a + b;
            Console.WriteLine("Addition = {0}", z);
        }
    }
}
