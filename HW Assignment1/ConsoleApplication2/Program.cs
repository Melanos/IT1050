namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            bool isCitizen;
            int heightFeet;
            double heightInches;
            double totalHeightsCM;

            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();

            System.Console.Write("What is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("What is your height in inches?");
            heightInches = double.Parse(System.Console.ReadLine());

            System.Console.Write("What is your age?");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen?");
            isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = true;
            if (isCitizen == true)
                if (age >= 18)
            {
                canVote = true;
            }
            else
            {
                canVote = false;
            }
            double totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            System.Console.WriteLine("Full Name:" + firstName + " " + middleInitial + " " + lastName + ".");
            System.Console.WriteLine("Height in cm:" + totalHeightCM + ".");
            System.Console.WriteLine("Vote:" + canVote + ".");
            System.Console.ReadKey();



        }
    }
}
