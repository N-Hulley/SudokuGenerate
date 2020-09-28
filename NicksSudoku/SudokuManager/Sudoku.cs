using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace SudokuManager
{
    class NumberTracker {
        private int[] Values;
        public NumberTracker(int[] values)
        {
            this.Values = values;
            IsValid = this.Validate();
        }
        public NumberTracker()
        {
            Values = new int[9];
            IsValid = true;
        }
        public bool IsValid { get; set; }
        public bool addValue(int? value, int index)
        {
            if (value == null) return false;
            for (int i = 0; i < index; i++)
            {
                if (this.Values[i] == value)
                {
                    Log.Add("Invalid, number " + this.Values[i].ToString() + " appears twice in set", Importance.SlightlyImportant);
                    this.IsValid = false;
                    return false;
                }
            }
            this.Values.SetValue(value, index);
            return true;
        }
        public bool Validate()
        {
            List<int> requiredValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < requiredValues.Count; i++)
            {
                if (!ListContains(requiredValues, Values[i])) return false;
            }
            return true;
        }
        static bool ListContains(List<int> list, int value)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == value)
                {
                    list.RemoveAt(j);
                    return true;
                }
            }
            return false;
        }
    }

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

        public bool ValidateSudoku(Sudoku board)
        {
            Log.Add("Validating Sudoku");

            for (int i = 0; i < Sudoku.Cols; i++)
            {
                if (!ValidateRow(Grid, i)) return false;
                if (!ValidateCol(Grid, i)) return false;
            }
            Log.Add("Sudoku board is valid");

            return true;
        }
        public static bool ValidateGroup(int?[,] grid, int row, int col, bool allowNull = false)
        {
            Log.Add("Validating Group " + row + ":" + col, Importance.NotImportant);

            int groupStartX, groupStartY = 0;
            groupStartX = (row / 3) * 3;
            groupStartY = (col / 3) * 3;
            NumberTracker tracker = new NumberTracker();
            for (int i = groupStartX; i < groupStartX + 3; i++)
            {
                for (int j = groupStartY; j < groupStartY + 3; j++)
                {
                    if (allowNull)
                    {
                        if (grid[i, j] == null) continue;
                    }
                    int index = (i * 3) + j;
                    
                    tracker.addValue(grid[i, j], index);
                    if (!tracker.IsValid) return false;
                }
            }
            return true;
        }
        public static bool ValidateRow(int?[,] grid, int row, bool allowNull = false)
        {
            Log.Add("Validating Row " + row , Importance.NotImportant);

            NumberTracker tracker = new NumberTracker();

            for (int i = 0; i < Sudoku.Cols; i++)
            {
                if (allowNull)
                {
                    if (grid[i, row] == null) continue;
                }
                tracker.addValue(grid[i, row], i);
                if (!tracker.IsValid) return false;
            }
            return true;
        }
        public static bool ValidateCol(int?[,] grid, int col, bool allowNull = false)
        {
            Log.Add("Validating Col " + col, Importance.NotImportant);

            NumberTracker tracker = new NumberTracker();

            for (int i = 0; i < Sudoku.Cols; i++)
            {
                if (allowNull)
                {
                    if (grid[col, i] == null) continue;
                }
                tracker.addValue(grid[col, i], i);
                if (!tracker.IsValid) return false;
            }
            return true;
        }

        public static Sudoku GenerateRandom()
        {
            Log.Add("Generate Random Sudoku", Importance.SomewhatImportant);
            Sudoku board = new Sudoku(GenerateGrid());
            //board = new Sudoku(
            //    new int?[9, 9]
            //    {
            //        {2,4,6,8,5,7,9,1,3 },
            //        {1,8,9,6,4,3,2,7,5 },
            //        {5,7,3,2,9,1,4,8,6 },
            //        {4,1,8,3,2,9,5,6,7 },
            //        {6,3,7,4,8,5,1,2,9 },
            //        {9,5,2,1,7,6,3,4,8 },
            //        {7,6,4,5,3,2,8,9,1 },
            //        {3,2,1,9,6,8,7,5,4 },
            //        {8,9,5,7,1,4,6,3,2 },
            //    });



            //Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            Random rand = new Random(1);// unixTimestamp);
            int RowShift = 0, ColShift = 0;

            for (int x = 0; x < 9; x++)
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                if (RowShift >6)
                {
                    RowShift = 0;
                    ColShift += 3;
                }

                for (int i = RowShift; i < RowShift + 3; i++)
                {
                    for (int j = ColShift; j < ColShift + 3; j++)
                    {
                        bool numberPlaced = false;
                        bool noSolution = false;
                        List<int> testedValues = new List<int>(numbers);
                        while (!numberPlaced)
                        {
                            if (testedValues.Count == 0) { noSolution = true; break; }

                            int selectedIndex = rand.Next(0, testedValues.Count );
                            int value = testedValues[selectedIndex];
                            testedValues.RemoveAt(selectedIndex);

                            board.Grid[i, j] = value;
                            if (ValidateRow(board.Grid, i, true))
                            {
                                if (ValidateCol(board.Grid, j, true))
                                {
                                    numbers.Remove(value);
                                    numberPlaced = true;
                                    break;
                                }
                            }
                        }

                    }
                }
                RowShift += 3;

            }

            return board;
        }
    }
}
