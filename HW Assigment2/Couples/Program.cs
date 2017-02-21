namespace Couples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Spouse = new Person();
            p1.AskUserForNameAndAge();
            p1.Related();


            Person p2 = new Person();
            p2.Spouse = new Person();
            p2.AskUserForNameAndAge();
            p2.Related();


            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();



            System.Console.WriteLine("Average Age: " + Person.SingleAverageAge());
            System.Console.WriteLine("Press a key to continue.");
            System.Console.ReadKey();

        }
    }
}
