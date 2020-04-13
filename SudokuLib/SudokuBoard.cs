using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuLib
{
    class SudokuBoard
    {
        //Variables
        private IndivSquare[,] intArrBoard = new IndivSquare[9,9];

        //Methods
        private void Initialize()
        {
            //Make all the numbers on the board 0 ready for input and have no possible numbers
            for (int col = 0; col < 9; col++)
            {
                for (int row = 0; row < 9; row++)
                {
                    this.IntArrBoard[col, row] = new IndivSquare();
                    this.IntArrBoard[col, row].Number = 0;

                    //Make all the possible numbers false
                    for (int possNumber = 0; possNumber < 9; possNumber++)
                    {
                        this.IntArrBoard[col, row].PossibleNumbers[possNumber] = false;
                    }
                }
            }
        }

        //Constructors
        public SudokuBoard()
        {
            this.Initialize();
        }

        //Declaring the properties
        public IndivSquare[,] IntArrBoard
        {
            get
            {
                return intArrBoard;
            }
            set
            {
                intArrBoard = value;
            }
        }
    }
}
