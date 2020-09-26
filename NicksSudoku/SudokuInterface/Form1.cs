using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuManager;
namespace SudokuInterface
{
    public partial class Form1 : Form
    {
        SudokuDisplay Display;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Display != null) Display.Dispose();
            Display = null;
            Sudoku board = Sudoku.GenerateRandom();
            Display = new SudokuDisplay(board);
            Display.Dock = DockStyle.Fill;
            pnlSudokuPlaceHoldr.Controls.Add(Display);
        }
    }
}
