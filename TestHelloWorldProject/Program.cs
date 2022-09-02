using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelloWorldProject.Basic_Programs;

namespace TestHelloWorldProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Dog dog1 = new Dog();
            dog1.color = "brown";
            dog1.name = "Tommy";
            dog1.breed = "Labour";

            dog1.dogdetails();
            Console.WriteLine(dog1.name);
            dog1.walk();


            //Console.WriteLine("Fibonacci Series: ");
            //Console.WriteLine("Enter any Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //FibonacciSeries.FindSeries(6);
            //Console.WriteLine("Prime Number: ");
            //PrimeNumber.prime(5);
            //Console.WriteLine("Enter Number to make Reverse: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //ReverseNumber.Reverse(number);

            //Console.WriteLine("Enter Number to check Palindrome: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Palindrome.PalindromeNumber(number);

            //Console.WriteLine("Enter Number to see Sum of Digits: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //SumOfDigits.findsumofdigit(number);
            ReverseWord.ReadInput();
            Console.ReadLine();

        }
    }
}
