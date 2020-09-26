using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuManager;
namespace SudokuInterface
{
    public partial class SudokuDisplay : UserControl
    {
        public Sudoku Board;
        public List<List<SudokuCell>> Cells = new List<List<SudokuCell>>();
        public SudokuDisplay(Sudoku board)
        {
            this.Board = board;
            InitializeComponent();
        }

        private void SudokuDisplay_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Sudoku.Rows; i++)
            {
                Cells.Add(new List<SudokuCell>());
                for (int j = 0; j < Sudoku.Cols; j++)
                {
                    int XOffset = 5 +((int)i / 3) * 5;
                    int YOffset = 5 +((int)j / 3) * 5;

                    SudokuCell Cell = new SudokuCell(Board.Grid[i, j]);
                    Cell.Location = new Point(Cell.Width * i + XOffset, Cell.Height * j + YOffset);
                    
                    Cells[i].Add(Cell);
                    this.Controls.Add(Cell);

                }
            }
        }
    }
}
