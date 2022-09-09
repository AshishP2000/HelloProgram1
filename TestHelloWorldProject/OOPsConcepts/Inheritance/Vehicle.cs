using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject.OOPsConcepts.Inheritance
{
    public class Vehicle
    {
        public string color;
        public double price;

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started");
        }
        public void VehicleDetails(string color,double price)
        {
            Console.WriteLine("Color: {0} Price: {1}",color,price);
        }
    }
}
