using NUnit.Framework;
using SudokuLib;
using SudokuDisplay;

namespace SudokuTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SudokuGame sudoku = new SudokuGame();
            IndivSquare[,] table = new IndivSquare[9,9];
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    table[row, col] = new IndivSquare();     
                }
            }

            table[2, 0].Number = 6;
            table[3, 0].Number = 1;
            table[7, 0].Number = 9;
            table[1, 1].Number = 9;
            table[2, 1].Number = 5;
            table[5, 1].Number = 2;
            table[6, 1].Number = 1;
            table[7, 1].Number = 7;
            table[8, 1].Number = 4;

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void RowCompletionDetection()
        {
            SudokuBoard sudoku = new SudokuBoard();
            Detection RowDetectTest = new Detection(sudoku);
            RowDetectTest.RowDetect();
            if (RowDetectTest.RowComplete == true)
            {
                Assert.Pass();
            }
            if (RowDetectTest.RowComplete == false)
            {
                Assert.Fail();
            }
        }
    }
}