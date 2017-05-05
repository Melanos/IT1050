
using System;

namespace Almost_Chess2
{
    public class Board
    {
        public string[,] chessBoard;
        public const int BOARDSIZE = 8; 

        private Pawn Pawn;
        private Movement Move;

        public Board()
        {
            Pawn = new Pawn();
            Move = new Movement();
            chessBoard = new string[BOARDSIZE, BOARDSIZE]; //Size of the board 8 by 8
            ChessBoardHorizontal = "+---"; // separater between vertical
            ChessBoardVertical = "| ";  // separater
        }

        public string ChessBoardHorizontal { get; set; }
        public string ChessBoardVertical { get; set; }


        public void ChessBoardPic() // Horizontal and Vertical lines for chess board_____
        {
            while (!Move.fail)
           {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6    7");
                for (int i = 0; i < BOARDSIZE; i++)
                {
                    Console.Write("  "); // 3 spaces 
                    for (int j = 0; j < BOARDSIZE; j++)
                    {
                        Console.Write(ChessBoardHorizontal); // horizontal lines
                    }

                    Console.Write("+\n");

                    for (int j = 0; j < BOARDSIZE; j++) //MoveY
                    {
                    if (j == 0)
                        Console.Write(i + " ");
                        Console.Write(ChessBoardVertical + Pawn.pawns[i, j] + " ");
                    }

                    Console.Write("|\n");
                    
            }
            Console.Write("  "); // Variable is declared but never used
            for (int j = 0; j < BOARDSIZE; j++)
            {
                Console.Write(ChessBoardHorizontal);
            }

            Console.Write("+\n\n");
                Move.MovePawn();
        }
        }
    }
}
