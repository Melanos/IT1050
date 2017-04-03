using System;

namespace MovieTheater
{
    class Ticket
    {


        int child;
        int adult;
        int senior;
        int NumberOfTickets = 0;

        // If you want a numeric real literal to be treated as decimal, use the suffix m or M, for example:  decimal myMoney = 300.5m; Without the suffix m, the number is treated as a double and generates a compiler error.

        const decimal MorningchildPrice = 3.99M;
        const decimal MorningadultPrice = 5.99M;
        const decimal MorningseniorPrice = 4.50M;
        const decimal EveningchildPrice = 6.99M;
        const decimal EveningadultPrice = 10.99M;
        const decimal EveningseniorPrice = 8.50M;


        decimal TicketCost = 0.00M;
        decimal DiscountTotal = 0.00M;
        decimal FinalPrice = 0.00M;

        string time;

        public void GetFinalPrice(decimal extraitemsCost)
        {
            FinalPrice = TicketCost + extraitemsCost;
            Console.WriteLine("Final Price: " + FinalPrice.ToString("c"));
        }

        public void GetTicketOrder()
        {
            Console.Write("How many Child tickets? ");
            child = int.Parse(Console.ReadLine());
            Console.Write("How many Adult tickets? ");
            adult = int.Parse(Console.ReadLine());
            Console.Write("How many Senior tickets? ");
            senior = int.Parse(Console.ReadLine());
            Console.Write("Morning or Evening show? ");
            time = Console.ReadLine();

            NumberOfTickets += child + adult + senior;

            if (time.ToLower().Contains("Morning"))
            {
                TicketCost += (child * MorningchildPrice);
                TicketCost += (adult * MorningchildPrice);
                TicketCost += (adult * MorningchildPrice);
            }
            else
            {
                TicketCost += (child * EveningchildPrice);
                TicketCost += (adult * EveningadultPrice);
                TicketCost += (senior * EveningseniorPrice);
            }
        }
        public void PopcornPromotion(Price Price)
        {
            if (NumberOfTickets >= 3 && time.ToLower().Contains("Evening"))
            {
                Price.AddPopcorn();
            }
        }

        public void GetTicketDiscount(int popcorn, int lSoda)
        {
            if (popcorn >= lSoda && NumberOfTickets >= lSoda)
            {
                DiscountTotal = lSoda * 2;
                TicketCost -= DiscountTotal;
            }
            else if (lSoda >= popcorn && NumberOfTickets >= popcorn)
            {
                DiscountTotal = popcorn * 2;
                TicketCost -= DiscountTotal;
            }
            else
            {
                DiscountTotal = NumberOfTickets * 2;
                TicketCost -= DiscountTotal;
            }
        }

        public void AmountOfTickets()
        {
            Console.WriteLine("Tickets you've ordered:      ");
            Console.WriteLine("Amount of children tickets:  " + child);
            Console.WriteLine("Amount of adult tickets:     " + adult);
            Console.WriteLine("Amount of senior tickets:    " + senior);
            Console.WriteLine("total amount of tickets:     " + NumberOfTickets);
        }

        public void GetGrandTotal(decimal extraitemsCost)
        {
            extraitemsCost = TicketCost + extraitemsCost;
            Console.WriteLine("Your amount due: " + FinalPrice.ToString("c"));
        }
    }
}
