using System;

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
            int secondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The smaller integer is {Math.Min(firstInt, secondInt)}");
            Console.WriteLine("--------------------");

            // Exercise 2
            // Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            Console.WriteLine("Exercise 2");
            int num3 = 7;
            int num4 = -24;
            string sign3 = num3.ToString("+#;-#;0");
            string sign4 = num4.ToString("+#;-#;0");
            Console.WriteLine("the sign of 7 is " + sign3[0]);
            Console.WriteLine("the sign of -24 is " + sign4[0]);
            Console.WriteLine("--------------------");

            // Exercise 3
            // Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            Console.WriteLine("Exercise 3");
            Console.WriteLine("write three numbers to sort");
            int[] arr = new int[3];
            Console.Write($"Enter number 1: ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter number 2: ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter number 3: ");
            arr[2] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arr);
            Console.Write($"The ascending order is: {arr[2]}, {arr[1]}, {arr[0]}");
            Console.WriteLine("\n--------------------");

            // Exercise 4
            // Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter 5 numbers to find the max of them");
            int[] numbers = new int[5];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            numbers[4] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(numbers);
            int maxNumber = numbers[numbers.Length - 1];
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
            Console.Write("Input minutes: ");
            int mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{mins / 60} Hours, {mins % 60} Minutes");
            Console.WriteLine("--------------------");

            // Exercise 8
            // Create string of array that contains 5 element of different sentence with different length .
            // Print all elements with fixed length for each sentence.
            Console.WriteLine("Exercise 8");
            string[] sentences = { "Orange Academy", "location in Irbid", "6 months", "full stack development", "one month internsip" };
            Console.WriteLine($"{sentences[0]} ==> Length: {sentences[0].Length}");
            Console.WriteLine($"{sentences[1]} ==> Length: {sentences[1].Length}");
            Console.WriteLine($"{sentences[2]} ==> Length: {sentences[2].Length}");
            Console.WriteLine($"{sentences[3]} ==> Length: {sentences[3].Length}");
            Console.WriteLine($"{sentences[4]} ==> Length: {sentences[4].Length}");
        }
    }
}






