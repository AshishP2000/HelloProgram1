using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Encapsulation
{
    public class Student
    {
        private string StudentName;
        private double balance { get; set; }
        private double amount;

        public void Credit(double amount)
        {
            balance = 5000;
            if (amount > 0)
            {
                balance = amount + balance;
                Console.WriteLine("Actual Balance: {0}",balance);
            }

            else
            {
                //Console.WriteLine("Please Enter some Valid Number");
                Console.WriteLine("Actual Balance: {0}", balance);
            }
        }
        public string name
        {

            get 
            {
                return StudentName;
            }
            set 
            { 
                StudentName = value;
            }
        }
        public double money
        {
            get
            {
                return amount;
            }
            set 
            {
                if (value>0)
                    amount = value;
                else
                    Console.WriteLine("Enter valid amount!...");
            }
        }
    }
}
