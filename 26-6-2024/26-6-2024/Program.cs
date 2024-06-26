using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace _26_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write a C# program that accept two integers and display the smaller. 
            Console.WriteLine("Exercise 1");
            Console.Write("First Integer: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Integer: ");
            int secondInt= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The smaller integer is {Math.Min(firstInt,secondInt)}");
            Console.WriteLine("--------------------");

            // Exercise 2
            // Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            Console.WriteLine("Exercise 2");
            Console.Write("Enter a number to determine its sign: ");
            int num= Convert.ToInt32(Console.ReadLine());
            int signNumber=Math.Sign(num);
            if (signNumber == -1)
            {
                Console.WriteLine($"The sign is -");
            }
            else if (signNumber == 1)
            {
                Console.WriteLine($"The sign is +");
            }
            else if (signNumber == 0) {
                Console.WriteLine($"The number is zero");
            }
            Console.WriteLine("--------------------");

            // Exercise 3
            // Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            Console.WriteLine("Exercise 3");
            Console.WriteLine("write three numbers to sort");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.Write("The ascending order is: ");
            for (int i = 2; i >= 0; i--) {
                Console.Write($"{arr[i]} , ");
             }
            Console.WriteLine("\n--------------------");

            // Exercise 4
            // Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter 5 numbers to find the max of them");
            int [] numbers = new int[5];
            for (int i = 0; i < 5; i++) {
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);
            int maxNumber= numbers[numbers.Length-1];
            Console.WriteLine($"The max number is {maxNumber}");
            Console.WriteLine("--------------------");

            // Exercise 5
            // Write a C# program that converts kilometers per hour to miles per hour.  
            Console.WriteLine("Exercise 5");
            Console.Write("Input kilometers per hour: ");
            int kilometer = Convert.ToInt32(Console.ReadLine());
            double miles = kilometer * 0.62137119;
            Console.WriteLine($"equals to {miles} miles per hour");
            Console.WriteLine("--------------------");

            // Exercise 6
            // Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            // Input hours: 5
            // Input minutes: 37
            // Total: 337 minutes.

            Console.WriteLine("Exercise 6");
            Console.Write("Input hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int totalMinutes = hours * 60 + minutes;
            Console.WriteLine($"Total : {totalMinutes} minutes");
            Console.WriteLine("--------------------");

            // Exercise 7
            // Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            //	Input minutes: 546
            //	9 Hours, 6 Minutes
            Console.WriteLine("Exercise 7");
            Console.WriteLine("Input minutes: ");
            int mins= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{mins / 60} Hours, {mins % 60} Minutes");
            Console.WriteLine("--------------------");

            // Exercise 8
            // Create string of array that contains 5 element of different sentence with different length .
            // Print all elements with fixed length for each sentence.
            Console.WriteLine("Exercise 8");
            string[] sentences = { "Orange Academy", "location in Irbid", "6 months", "full stack development", "one month internsip" };
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine($"{sentences[i]} ==> Length: {sentences[i].Length}");
            }

        }
    }
}
