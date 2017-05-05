namespace Almost_Chess2
{
    public class Pawn
    {
        public const char PAWN_PIC = 'X';
        public const char S = ' ';  
        public static char[,] pawns;

        public Pawn()
        {
            pawns = new char[Board.BOARDSIZE, Board.BOARDSIZE];
            StartPawn();
        }

        /// <summary>
        /// 
        /// </summary>
        private void StartPawn()
        {
            for (int i = 0; i < Board.BOARDSIZE; i++)
            {
                for (int j = 0; j < Board.BOARDSIZE; j++) // MAKE SURE THAT INT MATCHES Mistake (int j = 0, j < Board.BOARDSIZE; i++) exception:System.IndexOutOfRangeException 
                {
                    if (i == 0 || i == 1 || i == Board.BOARDSIZE - 2 || i == Board.BOARDSIZE - 1) //array for 1-0 and 6-7
                        pawns[i, j] = PAWN_PIC;
                    else
                        pawns[i, j] = SPACE;
               }
            }
        }
    }
}
