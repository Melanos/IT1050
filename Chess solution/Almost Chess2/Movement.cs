using System;

namespace Almost_Chess2
{
    public class Movement : Pawn   //Movement class inherits from class Pawn.
     {
        private int moveX;
        private int moveY; 
        private int finalX; 
        private int finalY;


        public Movement()
        {
            moveX = 0;
            moveY = 0;
            finalX = 0;
            finalY = 0;
            fail = false;
        }
        public bool fail { get; set; }

        public void MovePawn()
        {
            pullInformation();

            if (!fail)
            refresh();
        }

        private void pullInformation() // pull information from client
        {
            Console.WriteLine("Enter Target X Coordinate Between 0 and 7 : ");
            fail = validateInput(int.TryParse(Console.ReadLine(), out moveX));

            if (!fail)
            {
                Console.WriteLine("Enter Target Y Coordinate Between 0 and 7 : ");
                fail = validateInput(int.TryParse(Console.ReadLine(), out moveY));

            }

            if (!fail)
            {
                Console.WriteLine("Enter Destination X Coordinate Between 0 and 7 : ");
                fail = validateInput(int.TryParse(Console.ReadLine(), out finalX));

            }
            if (!fail)
            {
                Console.WriteLine("Enter Destination Y Coordinate Between 0 and 7 : ");
                fail = validateInput(int.TryParse(Console.ReadLine(), out finalY));

            }
        }

        private void refresh()// re arange and refresh screen once moved 
        {
            pawns[finalX, finalY] = pawns[moveX, moveY];
            pawns[moveX, moveY] = S;
        }

        private bool validateInput(bool parsed)
        {
            bool error = false;

            if (!parsed)
                error = true;
            else if (moveX < 0 || moveY < 0 || finalX < 0 || finalY < 0)
                error = true;
            else if (moveX > Board.BOARDSIZE - 1 || moveY > Board.BOARDSIZE - 1 || finalX > Board.BOARDSIZE - 1 || finalY > Board.BOARDSIZE - 1)
                error = true;

            if (error)
                Console.WriteLine("Number is below 0 or larger than 7. Bye.");

            return error;
        }

    }
}
