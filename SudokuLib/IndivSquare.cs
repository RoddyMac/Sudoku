using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuLib
{
    class IndivSquare
    {
        //Properties declared
        public bool[] PossibleNumbers { get; set; } = new bool[9];
        public int Number { get; set; } = new int();

        //Constructor
        public IndivSquare()
        {

        }
    }
}
