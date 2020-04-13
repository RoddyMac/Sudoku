using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuLib
{
	class Detection
	{
		//Variables
		private bool rowComplete = new bool();
		private bool colComplete = new bool();
		private bool ninthComplete = new bool();
		private SudokuBoard sudoku = new SudokuBoard();
		
		//Methods
		public void RowDetect()
		{

			int[] tempRow = new int[9];

			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					tempRow[tempRow.Length] = sudoku.IntArrBoard[row, col].Number;
				}
			}
		}
		public void ColDetect()
		{

		}
		public void NinthDetect()
		{

		}
		public void ScanBoard()
		{

		}

		//Constructors
		public Detection(SudokuBoard sudoku)
		{
			this.sudoku = sudoku;
		}

		//Properties
		public bool RowComplete 
		{
			get
			{
				return rowComplete;
			}
			set
			{
				rowComplete = value;
			} 
		
		}
		public bool ColComplete
		{
			get
			{
				return colComplete;
			}
			set
			{
				colComplete = value;
			} 
		}
		public bool NinthComplete
		{
			get
			{
				return ninthComplete;
			}
			set
			{
				ninthComplete = value;
			}
		}
	}
}
