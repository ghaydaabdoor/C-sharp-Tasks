using System;

namespace _30_6_2924
{
    internal class Program
    {
        // Task 1
        public static void sumFunction()
        {
            Console.WriteLine("Input 10 numbers: ");
            int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number - {i + 1} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine($"sum is : {sum}");
            Console.WriteLine($"average is : {(double)sum / 10}");
        }

        // Task 3
        public static void GetYears(int[] yearsArr)
        {
            foreach (int year in yearsArr)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }
        }

        // Task 4
        public static void AgeInDays(int ageY)
        {
            int ageD = ageY * 365;
            Console.Write($"age in days is : {ageD}");
        }

        // Task 5
        public class PersonalInfo
        {
            public int age;
            public string gender;
            public string name;
            public string email;
            public int ID;
            public string phone;

            public PersonalInfo()
            {
                age = 18;
                gender = "Female";
                name = "Ghaydaa";
                email = "example@example.com";
                ID = 999999999;
                phone = "0787878787";

                Console.WriteLine("Default:");
                Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}, Email: {email}, ID: {ID}, Phone: {phone}");
            }

            public PersonalInfo(int age, string gender, string name, string email, int ID, string phone)
            {
                if (age < 18 || age > 60)
                {
                    Console.WriteLine("Age must be between 18 and 60");
                    this.age = 18;
                }
                else
                {
                    this.age = age;
                }

                this.gender = gender;
                this.name = name;
                this.email = email;
                this.ID = ID;

                if (phone.StartsWith("077") || phone.StartsWith("078") || phone.StartsWith("079"))
                {
                    this.phone = phone;
                }
                else
                {
                    Console.WriteLine("Phone number must start with 077, 078, or 079.");
                    this.phone = "0770000000";
                }

                Console.WriteLine($"Name: {name}, Age: {this.age}, Gender: {gender}, Email: {email}, ID: {ID}, Phone: {this.phone}");
            }
        }

        static void Main(string[] args)
        {
            /* Task 1
            Write a function in C# that accept 10 numbers and return sum and average.
            Test Data:
            Input the 10 numbers:
            Number - 1 :2 
            Number - 10 :2
            Expected Output :
            The sum of 10 no is : 55
            The Average is : 5.500000 */
            Console.WriteLine("Exercise 1");
            sumFunction();
            Console.WriteLine("-----------------------------");

            /* 2-	Write a program in C to display the cube of the number up to given an integer.
            Test Data:
            Input number of terms : 5
            Expected Output :
            Number is : 1 and cube of the 1 is :1
            Number is : 2 and cube of the 2 is :8
            Number is : 3 and cube of the 3 is :27
            Number is : 4 and cube of the 4 is :64
            Number is : 5 and cube of the 5 is :125 */

            Console.WriteLine("Exercise 2");
            Console.Write("Input number of terms : ");
            int termsNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= termsNum; i++)
            {
                int cubicNumber = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of {i} is : {cubicNumber}");
            }
            Console.WriteLine("-----------------------------");

            /* Write a program in C# return only numbers in the years array greater than 1950.
            const years = [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020]
            function getYears(years) {}
            */
            Console.WriteLine("Exercise 3");
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            GetYears(years);
            Console.WriteLine("-----------------------------");

            /* Create a function that takes the age in years and returns the age in days.
             */
            Console.WriteLine("Exercise 4");
            Console.Write("Age in years : ");
            int EnteredAge = Convert.ToInt32(Console.ReadLine());
            AgeInDays(EnteredAge);
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            /* 5-	Create class that contain the following field:
            a.	Age  between 18-60
            b.	Gender
            c.	Name
            d.	E-Mail	
            e.	ID
            f.	Phoneshould be started in 077 or 078 or 079
            Don’t forget the default value. */

            Console.WriteLine("Exercise 5");
            PersonalInfo example = new PersonalInfo();
            PersonalInfo Ali = new PersonalInfo(25, "Male", "Ali", "Ali99@yahoo.com", 123, "0781234567");
        }
    }
}
