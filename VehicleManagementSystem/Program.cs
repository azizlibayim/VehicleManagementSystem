// See https://aka.ms/new-console-template for more information
using VehicleManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car("Nissan", "Juke", 2020, 4));
        vehicles.Add(new Motorcycle("Harley Davidson", "Sportster", 2019, true));
        vehicles.Add(new Car("Honda", "Civic", 2022, 4));
        vehicles.Add(new Motorcycle("Yamaha", "MT07", 2021, false));
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.StartEngine());
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
