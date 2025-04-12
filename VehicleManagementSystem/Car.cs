using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    public class Car: Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car (string brand, string model, int year, int numberOfDoors) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string StartEngine()
        {
            return "Car engine started.";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors is {NumberOfDoors}");
        }
    }
}
