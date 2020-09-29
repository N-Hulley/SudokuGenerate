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
using Utils;

namespace SudokuInterface
{
    public partial class Form1 : Form
    {
        SudokuDisplay Display;
        public Form1()
        {
            InitializeComponent();
            btnValidate.Enabled = false;
            Log.LogsChanged += LogsUpdated;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Log.Add("Generate Button Clicked", Importance.NotImportant);
            btnGenerate.Enabled = false;
            if (Display != null) Display.Dispose();
            Display = null;
            Sudoku board = Sudoku.GenerateRandomValidSudoku();
            Display = new SudokuDisplay(board);
            Display.Dock = DockStyle.Fill;
            pnlSudokuPlaceHoldr.Controls.Add(Display);
            btnGenerate.Enabled = true;
            btnValidate.Enabled = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Log.Add("Validate Button Clicked", Importance.NotImportant);

            Display.Board.ValidateSudoku(Display.Board);
        }
        void LogsUpdated(object sender,  EventArgs e)
        {
            LogsChangedEventArgs args = ((LogsChangedEventArgs)e);
            //if (newEntry == null) return;

            if (args.LogLevelChanged)
            {
                lstLogList.Items.Clear();
                foreach (LogEntry log in args.DisplayedLogs)
                {
                    lstLogList.Items.Add(log.OriginalMessage);
                }

            } else
            {
                int selected = lstLogList.SelectedIndex;
                lstLogList.Items.Add(args.NewEntry.OriginalMessage);
                lstLogList.SelectedIndex = selected;
                lstLogList_SelectedIndexChanged();
            }
        }

        //private void lstLogImportance_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //}

        private void lstLogImportance_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Log.ChangeDisplayLevel((Importance)lstLogImportance.SelectedIndex);

        }

        private void lstLogList_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            if (lstLogList.SelectedIndex == -1)
            {
                txtSelectedLogInfo.Text = "";
                return;
            }
            LogEntry log = Log.DisplayedLogs[lstLogList.SelectedIndex];
            txtSelectedLogInfo.Text = "Time: " + log.TimeStamp + Environment.NewLine + "Importance: " + log.importance.ToString() + Environment.NewLine + "Message: " + log.OriginalMessage;
        }
    }
}
