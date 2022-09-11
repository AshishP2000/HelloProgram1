using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelloWorldProject.Basic_Programs;
using TestHelloWorldProject.OOPsConcepts.Abstraction;
using TestHelloWorldProject.OOPsConcepts.Encapsulation;
using TestHelloWorldProject.OOPsConcepts.Inheritance;
using TestHelloWorldProject.OOPsConcepts.Polymorphism.MethodOverloading;
using TestHelloWorldProject.OOPsConcepts.Polymorphism.MethodOverriding;
using TestHelloWorldProject.Practice;

namespace TestHelloWorldProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number that you want to do Operation: ");
            /*Console.WriteLine("1.Object And Class.\n2.Fibonacci Series.\n3.Prime number.\n4.Reverse Number." +
                "\n5.Palindrome Number.\n6.Sum Of Digits.\n7.Reverse Word.\n8.Inheritance." +
                "\n9.Armstrong Number.\n10.Swap Number.\n11.Arithmetic Operations.\n12.Even Odd.\n13.Maximum and Minimum.");
            Console.WriteLine();
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Dog dog1 = new Dog();
                    dog1.color = "brown";
                    dog1.name = "Tommy";
                    dog1.breed = "German Shepherd";

                    Dog dog2 = new Dog();
                    dog2.color = "White";
                    dog2.name = "Sheru";
                    dog2.breed = "BullDog";

                    Console.WriteLine("\n1st Dog Info :");
                    dog1.dogdetails();
                    Console.WriteLine("\n2nd Dog Info :");
                    dog2.dogdetails();
                    //Console.WriteLine("Dog name: {0}",dog1.name);
                    Console.WriteLine();
                    dog1.walk();
                    dog2.walk();
                    break;
                case 2:
                    Console.WriteLine("Fibonacci Series: ");
                    Console.WriteLine("Enter any Number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.FindSeries(n);
                    break;
                case 3:
                    Console.WriteLine("Enter Number to Check if it is Prime Or Not: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.prime(n1);
                    break;
                case 4:
                    Console.WriteLine("Enter Number to make Reverse: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.Reverse(number);
                    break;
                case 5:
                    Console.WriteLine("Enter Number to check Palindrome: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Palindrome.PalindromeNumber(number1);
                    break;
                case 6:
                    Console.WriteLine("Enter Number to see Sum of Digits: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    SumOfDigits.findsumofdigit(number2);
                    break;
                case 7:
                    ReverseWord.ReadInput();
                    break;

                case 8:
                    Car car = new Car();
                    car.color = "Silver";
                    car.price = 1707000;
                    car.VehicleDetails(car.color,car.price);
                    break;
                case 9:
                    Console.WriteLine("Enter Number to check Armstrong Number: ");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    ArmstrongNumber.Arm(number3);
                    break;
                case 10:
                    Console.WriteLine("Enter Numbers to swap numbers: ");
                    int number4 = Convert.ToInt32(Console.ReadLine());
                    int number5 = Convert.ToInt32(Console.ReadLine());
                    SwapNumber.Swap(number4,number5);
                    break;
                case 11:
                    Console.WriteLine("Enter Numbers to do Arithmetic Operations: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    ArithmeticOperations.Arithmetic(num1,num2);
                    break;
                case 12:
                    Console.WriteLine("Enter Numbers to check Even or Odd: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    EvenOdd.Evenodd(num3);
                    break;
                case 13:
                    Console.WriteLine("Enter Numbers to check Maximum and Minimum: ");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    MaxMin.Maxmin(num4,num5,num6);
                    break;
                default:
                    Console.WriteLine("Enter Given number");
                    break;
            }*/
            Console.WriteLine("1.Inheritance\n2.Polymorphism\n3.Method Overriding\n4.Abstraction\n5.Encapsulation");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:  
                    Car car = new Car();
                    car.color = "Silver";
                    car.price = 1707000;
                    car.VehicleDetails(car.color,car.price);
                    break;
                case 2:
                    int a = 1,b=3,c=4;
                    float z = 45.5f;
                    Addition.Add(a,b);
                    Addition.Add(a,b,c);
                    Addition.Add(z,b);
                    break;
                case 3:
                    Cat cat = new Cat();
                    cat.AnimalDetails();
                    cat.AnimalSound();
                    break;
                case 4:
                    Square square = new Square();
                    Console.WriteLine("Enter Side of the Sqaure");
                    double side = Convert.ToInt32(Console.ReadLine());
                    square.AreaDetails();
                    square.Area(side);
                    break;
                case 5:
                    Student student = new Student();
                    //student.amount = 5000;
                    //Console.WriteLine("Before Credit: " + student.amount);
                    Console.WriteLine("Enter Amount to Credit:");
                    student.money = Convert.ToDouble(Console.ReadLine());
                    student.name = "Ashish";
                    Console.WriteLine("Account Holder Name: "+student.name);
                    student.Credit(student.money);
                    //Console.WriteLine("After Credit: " + student.amount);
                    //student.Credit(student.amount);
                    
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;

            }
            Console.ReadLine();
        }
    }
}
