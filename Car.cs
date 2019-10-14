using System;

namespace cars
{
    class Car
    {
        private int _MilesDriven = 0;
        public Car(int startingMiles) 
        {
            _MilesDriven = startingMiles;
        }
        public int TotalMiles
        {
            get {
                return _MilesDriven;
            }
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Description {
            get{
                return $"Get a {Year} {Make} {Model}";
            }
        }

        public int Drive(int miles)
        {
            _MilesDriven += miles;
            return _MilesDriven;
        }

        public void Accelerate()
        {
            Console.WriteLine($"The {Make} {Model} goes Vroom");
        }

        public int GetAge()
        {
            DateTime date = DateTime.Now;
            int currentYear = date.Year;
            return currentYear - Year;
        } 
    }
}