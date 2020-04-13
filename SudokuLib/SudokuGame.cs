using System;

namespace SudokuGame
{
    class SudokuGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Suduko!");

            SudokuBoard sudoku = new SudokuBoard();

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(" ");
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.Write("|  ");
                    }
                    Console.Write(sudoku.IntArrBoard[row, col].Number);
                    Console.Write(" ");
                }
                Console.Write("\n");

                if ((row % 3)-2 == 0 && row != 8)
                {
                    Console.Write("___________________________________\n");
                }

            }
        }
    }
}
