using System;
using SudokuLib;

namespace SudokuConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuGame sudoku = new SudokuGame();
            sudoku.RunGame();           
        }
    }
}
