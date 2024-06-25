using System;

namespace first_lecture_25_jun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Excercise 1");
            Console.WriteLine("Write something!");
            string stringFromUser= Console.ReadLine();
            Console.WriteLine("You wrote: "+stringFromUser);
            Console.WriteLine("_______________");


            // Exercise 2
            Console.WriteLine("Excercise 2");
            double num1 = 15.55;
            string str1 = "This is my first task";
            char char1 = 'A';
            bool bool1 = false;
            int int1 = 45;
            const double pi = 3.14;
            Console.WriteLine(num1);
            Console.WriteLine(str1);
            Console.WriteLine(char1);
            Console.WriteLine(bool1);
            Console.WriteLine(int1);
            Console.WriteLine(pi);
            Console.WriteLine("_______________");

            // Exercise 3
            Console.WriteLine("Exercise 3");
            string[] cars = { "BMW", "TOYOTA", "MERCEDES", "FORD", "KIA" };
            Console.WriteLine("Number of cars is: " + cars.Length);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("_______________");


            // Exercise 4
            Console.WriteLine("Exercise 4");
            Console.Write("Enter your first name: ");
            string firstName= Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surName= Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int yearOfBirth= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstName + " " + surName + " " + yearOfBirth);
            Console.WriteLine("_______________");


            // Exercise 5
            Console.WriteLine("Exercise 5");
            int[] arrayNew = new int[10];
            Console.WriteLine("Input 10 elements in the array :");
            for (int i = 0; i < 10; i++) {
                Console.Write("element - " + i + " : ");
                arrayNew[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in the array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arrayNew[i] + " ");
            }
            Console.WriteLine("_______________");

            // Exercise 6
            Console.WriteLine("Input 4 elements in the array to find their summation :");
            int[] arr = new int [4];
            int sum = 0;
            for (int i = 0; i < 4; i++) {
                Console.Write("index - " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is :" + sum);







        }
    }
}
