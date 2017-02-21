using System;

namespace Couples
{
    class Person
    {
        // Public member variables:
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;


        public static int Count;
        public static int SumOfAllAges;


        public string GetFullName()
        {
            string fullName = "";
            fullName = (this.FirstName + " " + this.LastName);
            return fullName;
        }

        public static double SingleAverageAge()
        {
            return Person.SumOfAllAges / Person.Count;
        }

        public void AskUserForNameAndAge()
        {
            Console.Write("First Name:  ");
            this.FirstName = Console.ReadLine();

            Console.WriteLine("LastName:  ");
            this.LastName = Console.ReadLine();

            Console.WriteLine("Age:  ");
            this.Age = int.Parse(Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;

        }


        public void PrintNameAndAge()
        {
            Console.WriteLine("Full Name: " + this.GetFullName() + " " + "Age: " + this.Age);
        }

        public void Related()
        {
            Console.WriteLine("What is her name if you are married?   ");
            Spouse.FirstName = Console.ReadLine();
            Spouse.LastName = this.LastName;

            Console.WriteLine("How old is spouse?");
            Spouse.Age = int.Parse(Console.ReadLine());

        }

    }
}
