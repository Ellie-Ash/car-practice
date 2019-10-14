using System;
using System.Collections.Generic;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(100000);
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.Year = 1968;
            car1.Price = 1000.50;

            Car car2 = new Car(90000)
            {
                Make = "Mazda",
                Model = "B2500",
                Year = 1997,
                Price = 115.50
            };

            Car car3 = new Car(170)
            {
                Make = "Nissan",
                Model = "GTR",
                Year = 2018,
                Price = 80000.00
            };

            List<Car> garage = new List<Car>();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);

            foreach (Car car in garage)
            {
                Console.WriteLine("-----");
                car.Accelerate();
                int age = car.GetAge();
                Console.WriteLine($"{age} years old");
                Console.WriteLine(car.Description);
                // Console.WriteLine(car.Drive(1000));
                // Console.WriteLine(car.Drive(234));
            }
    }
    }
}
