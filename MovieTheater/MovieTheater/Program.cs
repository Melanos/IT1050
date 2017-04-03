using System;

namespace MovieTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket TicketOrder = new Ticket();
            Price extraitems = new Price();

            // Order Tickets //
            TicketOrder.GetTicketOrder();
            extraitems.extraorder();

            //Discount Candy/lSoda + Popcorn//

            extraitems.Discount(TicketOrder);
            TicketOrder.PopcornPromotion(extraitems);

            extraitems.FreeCandy();



            // Print //

            TicketOrder.AmountOfTickets();
            extraitems.extras();
            extraitems.PrintGrandTotal(TicketOrder);

            Console.WriteLine ("Thanks for Shopping");
            Console.WriteLine("Press any button to close the menu.");
            Console.ReadKey();

            




        }
    }
}
