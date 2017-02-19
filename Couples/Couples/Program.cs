namespace Couples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AskUserForNameAndAge();
            p1.PrintNameAndAge();

            Person p2 = new Person();
            p2.AskUserForNameAndAge();
            p2.PrintNameAndAge();


            System.Console.WriteLine("Average Age: " + Person.SingleAverageAge());
            System.Console.ReadKey();

        }
    }
}
