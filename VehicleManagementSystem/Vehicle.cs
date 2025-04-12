using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle (string brand , string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public virtual string StartEngine()
        {
            return "Vehicle engine started.";
        }

        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"Brand is {Brand}, Model is {Model}, Year: {Year}");
        }
    }
}
