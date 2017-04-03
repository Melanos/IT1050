using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// If you want a numeric real literal to be treated as decimal, use the suffix m or M, for example:  decimal myMoney = 300.5m; Without the suffix m, the number is treated as a double and generates a compiler error.
/// </summary>
namespace MovieTheater
{
    class Price
    {
        string extraitems;
        int sSoda; //small
        int lSoda; //large
        int HotDog;
        int Popcorn;
        int Candy;
        string Time;

        const decimal pricesSoda = 3.50M;
        const decimal pricelSoda = 5.99M;
        const decimal priceHotDog = 3.99M;
        const decimal pricePopcorn = 4.50M;
        const decimal priceCandy = 1.99M;

        public decimal extraitemsCost = 0.00M;


        /// <summary>
        /// If statements
        /// </summary>

        public void FreeCandy()
        {
            if (Candy >= 3)
            {
                int FreeCandy = Candy / 3;
                Candy *= FreeCandy;
            }
        }

        public void extraorder()
        {
            Console.Write("Any extras? ");
            extraitems = Console.ReadLine();
        
        if (extraitems.ToLower().StartsWith("y"))
            {
                Console.Write("Candies? ");
                Candy = int.Parse(Console.ReadLine());
                extraitemsCost += (Candy* priceCandy);
                Console.Write("Popcorn? ");
                Popcorn = int.Parse(Console.ReadLine());
                extraitemsCost += (Popcorn* pricePopcorn);
                Console.Write("HotDogs? ");
                HotDog = int.Parse(Console.ReadLine());
                extraitemsCost += (HotDog* priceHotDog);
                Console.Write("Small soda? ");
                sSoda = int.Parse(Console.ReadLine());
                extraitemsCost += (sSoda * pricesSoda);
                Console.Write("Large soda? ");
                lSoda = int.Parse(Console.ReadLine());
                extraitemsCost += (lSoda* pricelSoda);
             }
}


        public void Discount(Ticket Ticket)
{
    Ticket.GetTicketDiscount(Popcorn, lSoda);
}

        public void AddPopcorn()
{
    Popcorn += 1;
}

        public void extras()
{
    Console.WriteLine("Candy = " + Candy);
    Console.WriteLine("Popcorn = " + Popcorn);
    Console.WriteLine("HotDogs = " + HotDog);
    Console.WriteLine("Small Soda= " + lSoda);
    Console.WriteLine("Large Soda= " + lSoda);
}

        public void PrintGrandTotal(Ticket Ticket)
        {
            Ticket.GetFinalPrice(extraitemsCost);
        }

    }
}
