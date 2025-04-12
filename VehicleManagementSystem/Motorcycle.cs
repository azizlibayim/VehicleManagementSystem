using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string brand, string model, int year, bool hasSidecar):base (brand, model, year) 
        {
            HasSidecar = hasSidecar;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSidecar} ");
        }
    }
}
