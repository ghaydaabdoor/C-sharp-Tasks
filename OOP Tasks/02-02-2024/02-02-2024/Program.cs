using System;
using System.Xml.Linq;

namespace _02_02_2024
{
    //1.	Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
    // 2.	Create function name DisplayInfo take two parameters	(make, year)
    // 3.	Create function name DisplayInfo take one parameters	(make)
    // 4.	This class contain function name (Display) that print statement (Welcome Car)
    // 5.	create  a BMW Class  inherit from Car Class 
    //         a. This class contain function name (Display) that print statement (welcome BMW)
    //         b. create object from  BMW then call the function Display
    // 6.   repeat  step 4 , 5 with Overriding Concept.
    class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Model { get; set; }
        public int PalleteNum { get; set; }
        public string Color { get; set; }

        public void DisplayInfo(string make, int year)
        {
            string DisInfo = $"Cars Info: Made in {make} in {year}";
            Console.WriteLine(DisInfo);
        }

        public void DisplayInfo(string make)
        {
            string DisInfo = $"Cars Info: Made in {make}";
            Console.WriteLine(DisInfo);
        }

        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }
    }

    class BMW : Car
    {
        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
        }
    }

    // End of task 1



    // 1.	Define an Interface
    //     o Create an interface named ISound that includes a method void MakeSound();.
    // 2.	Define an Abstract Class
    //         o	Create an abstract class named Animal that includes:
    //                - A property string Name { get; set; }.
    //                - A constructor that takes a string name parameter and sets the Name property
    //                - An abstract method void Eat();.
    //                - A concrete method void Sleep() that prints out the animal's name followed by "is sleeping.".
    // 3.	Implement Concrete Classes
    //         o	Create two classes, Dog and Cat, that:
    //                - Inherit from Animal
    //                - Implement the ISound interface.
    //                - Provide specific implementations for the Eat method that print out the animal's name followed by what it is eating.
    //                - Provide specific implementations for the MakeSound method that print out the animal's name followed by the sound it makes (e.g., "Woof!" for dogs and "Meow!" for cats).
    // 3.	Create a Program to Test Your Classes
    //         o	In the Main method, create instances of Dog and Cat.
    //         o	Call the Eat, Sleep, and MakeSound methods on each instance.


    interface ISound
    {
        void MakeSound();
    }

    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine($"{Name} are sleeping");
        }
    }

    class Dog : Animal, ISound
    {
        public Dog(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} eat meat");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} sound is Woof!");
        }
    }

    class Cat : Animal, ISound
    {
        public Cat(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Eat fish");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} sound is Meow!");
        }

    }

    // End of Task 2



    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DisplayInfo("Japan");
            car.DisplayInfo("Germany", 2020);


            //BMW bmw = new BMW();
            //bmw.Display();

            Car bmw = new BMW();
            bmw.Display();


            Console.WriteLine("--------------------------------------------------------------");
            Dog dog = new Dog("Dogs");
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();
            Console.WriteLine("--------------------------------------------------------------");

            Cat cat = new Cat("Cats");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
        }

    }
}
