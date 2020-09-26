using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SudokuInterface
{
    public partial class SudokuCell : UserControl
    {
        public int? Value;
        public SudokuCell(int? value = 0)
        {
            this.Value = value;
            InitializeComponent();
            txtCellInput.Text = this.Value.ToString();
        }
        int? previous = null;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(((TextBox)sender).Text + "\n\n" + txtCellInput.Text);
            if (txtCellInput.Text.Length > 0)
            {
                int newLetterIndex = txtCellInput.Text.Substring(0, 1) == previous.ToString() ? txtCellInput.Text.Length > 1 ? 1 : 0 : 0;
                txtCellInput.Text = txtCellInput.Text.Substring(newLetterIndex, 1);
                if (ValidateNumber(txtCellInput.Text) ){
                    txtCellInput.Text = txtCellInput.Text;
                    previous = int.Parse(txtCellInput.Text);
                } else
                {
                    txtCellInput.Text = previous.ToString(); 
                }
            } else
            {
                previous = null;
            }

        }
        bool ValidateNumber(string val)
        {
            try
            {
                 int.Parse(val.ToString()); 
                return true;
            } catch(Exception e)
            {
                InvalidInput();
                return false;
            }
        }
        public void InvalidInput()
        {
            Flash(Color.Red);

        }
        public void Flash(Color col, int time = 500)
        {
            CancellationTokenSource ts = new CancellationTokenSource();

            Color prevColour = txtCellInput.ForeColor;
            txtCellInput.ForeColor = col;
            txtCellInput.ReadOnly = true;

            Task t = Task.Run(() => {
                Task.Delay(700).Wait();
            });

            try
            {
                bool result = t.Wait(time, ts.Token);

            }
            catch (OperationCanceledException e)
            {
                ts.Dispose();
            }
            finally
            {
                txtCellInput.ReadOnly = false;
                txtCellInput.Text = previous.ToString();
                txtCellInput.ForeColor = prevColour;
                txtCellInput.Focus();

            }


        }
        private void txtCellInput_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
