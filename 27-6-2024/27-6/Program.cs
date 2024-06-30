using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _27_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Correct the syntax error:

            /*•	string[] ARR = [1, 7  9  45,]
            ====> We cannot write integer-type data inside a string-defined array, in addition the last element of array is empty.
            corrected syntax:  string[] ARR = { "1", "7", "9", "45" };*/

            /* int arr2 = ["Str" "alex","moh" 
            ====> Array is of type int, while the elements are of type strings,
            we have to define array elements with {} not with [],
            and to so separate them by commas ",",
            finally we have to write [] after array type i.e string[] to define that this is array
            corrected syntax: string[] arr2 = { "Str", "alex", "moh" };*/



            /* string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            ====> We have to use "" not '' to define elements of string-Array,
            add[] after string,
            write elements inside {} not [],
            separate elements by commas,
            corrected syntax is: string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            */

            /* Task 2
            What the index of "Banana","Tomato" ?
            String[] fruits = ["Tomato", "Banana", "Watermelon"] */
            Console.WriteLine("Task 2");
            Console.WriteLine("-----");
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine($"index of Banana is: {Array.IndexOf(fruits, "Banana")}");
            Console.WriteLine($"index of Tomato is: {Array.IndexOf(fruits, "Tomato")}");
            Console.WriteLine("--------------------------------------------------------------------");


            /* Task 3
             Create an multiple arrays that represents your:
            Favorite Food(5 item)
            Favorite Sport(3 item)
            Favorite Movie(4 item)
            Then, print each array using foreach, and Loop Through an Array */
            string[] favFood = { "Mansaf", "Pizza", "Burger", "Kabsah", "Pasta" };
            string[] favSports = { "Tennis", "Running", "Aerobics" };
            string[] favMovies = { "The Shawshank redemption", "A beautiful mind", "Pride and Prejudice" };

            // Using foreach
            Console.WriteLine("Task 3 - Using Foreach");
            Console.WriteLine("-----");
            Console.Write("Favorite Food are: ");
            foreach (string food in favFood)
            {
                Console.Write($"({food}) ");
            }
            Console.WriteLine();


            Console.Write("Favorite sports are: ");
            foreach (string sports in favSports)
            {
                Console.Write($"({sports}) ");
            }
            Console.WriteLine();


            Console.Write("Favortite movies are: ");
            foreach (string movie in favMovies)
            {
                Console.Write($"({movie}) ");
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------");

            // Using loop through array
            Console.WriteLine("Task 3 - Using Loop through array");
            Console.WriteLine("-----");
            Console.Write("Favorite Food are: ");
            for (int i = 0; i < favFood.Length; i++)
            {
                Console.Write($"({favFood[i]}) ");
            }
            Console.WriteLine();
            Console.Write("Favorite Sports are: ");
            for (int i = 0; i < favSports.Length; i++)
            {
                Console.Write($"({favSports[i]}) ");
            }
            Console.WriteLine();
            Console.Write("Favorite Movies are: ");
            for (int i = 0; i < favMovies.Length; i++)
            {
                Console.Write($"({favMovies[i]}) ");
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------");

            /* Task 4 
            Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            Expected Output:
            Input three numbers separated by comma: 5,10,15
            The sum of three numbers: 30.
             */
            Console.WriteLine("Task 4");
            Console.WriteLine("-----");
            Console.Write("Input three numbers separated by comma ");
            string[] inputNumbers = Console.ReadLine().Split(',');
            int sum = 0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                sum += Convert.ToInt32(inputNumbers[i]);
            }
            Console.Write($"Sum is: {sum} ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            /* Task 5 
            Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            Test Data
            The odd numbers are1 3 5 7 9 11 13 15 17 19……
            The Sum of odd Numbers is: …...
            */
            Console.WriteLine("Task 5");
            Console.WriteLine("-----");
            int[] numto100 = new int[50];
            numto100[0] = 1;
            int summation = 1;
            for (int i = 1; i < 50; i++)
            {
                numto100[i] = numto100[i - 1] + 2;
                summation += numto100[i];
            }
            foreach (int num11 in numto100)
            {
                Console.Write($"{num11} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Summation of odd number from 1 to 100 is: {summation}");
            Console.WriteLine("--------------------------------------------------------------------");

            /* Task 6 
            Write a code to produce the following output:
            *
            **
            ***
            ****
            *****
            ******
            ******* */
            Console.WriteLine("Task 6");
            Console.WriteLine("-----");

            for (int i = 1; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');

                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");

            /* Task 7 
            Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            The pattern like :
            1
            2 3
            4 5 6
            7 8 9 10
            */
            Console.WriteLine("Task 7");
            Console.WriteLine("-----");
            int numb = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{numb} ");
                    numb++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");






















        }
    }
}
