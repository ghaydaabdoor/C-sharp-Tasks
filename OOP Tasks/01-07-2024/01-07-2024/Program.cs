using System;

namespace _01_07_2024
{
    // Task 1
    public class Car
    {
        public string make;
        public int year;
        public string type;
        public double price;
        public int model;
        public int paletteNum;
        public string color;

        public Car(string carMake, int carYear, string carType, double carPrice, int carModel, int carPaletteNum, string carColor)
        {
            make = carMake;
            year = carYear;
            type = carType;
            price = carPrice;
            model = carModel;
            paletteNum = carPaletteNum;
            color = carColor;
        }

        public void Start()
        {
            Console.WriteLine("The engine is started");
        }

        public void Stop()
        {
            Console.WriteLine("The engine is stopped");
        }

        public string DisplayCarInfo()
        {
            return $"This type of car which is made in {make}, in {year} of type {type} has a price of {price} JOD, model of {model} palette number of {paletteNum} and color of {color}";
        }
    }

    public class BMW : Car
    {
        public BMW(string carMake, int carYear, string carType, double carPrice, int carModel, int carPaletteNum, string carColor)
            : base(carMake, carYear, carType, carPrice, carModel, carPaletteNum, carColor)
        {
        }

        // Additional BMW-specific properties or methods can go here
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmwCar = new BMW("Germany", 2023, "BMW", 50000, 3, 12345, "Black");
            bmwCar.Start();
            Console.WriteLine(bmwCar.DisplayCarInfo());
            bmwCar.Stop();
        }
    }
}
