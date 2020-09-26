using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuManager
{
    public class Sudoku
    {

        public int?[,] Grid;
        public const int Rows = 9;
        public const int Cols = 9;

        public Sudoku(int?[,] grid)
        {
            Grid = grid;
        }




        /// <summary>
        /// Generate a 2d array filled with a given int
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static int?[,] GenerateGrid(int rows = Rows, int cols = Cols, int? value = null)
        {
            int?[,] grid = new int?[9, 9];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = value;
                }
            }
            return grid;
        }

        public static Sudoku GenerateRandom()
        {
            Sudoku sudoku = new Sudoku(GenerateGrid());

            return sudoku;
        }
    }
}
