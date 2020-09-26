namespace SudokuInterface
{
    partial class SudokuCell
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCellInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCellInput
            // 
            this.txtCellInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtCellInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCellInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCellInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCellInput.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellInput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCellInput.Location = new System.Drawing.Point(8, -19);
            this.txtCellInput.Margin = new System.Windows.Forms.Padding(0);
            this.txtCellInput.MaxLength = 2;
            this.txtCellInput.Name = "txtCellInput";
            this.txtCellInput.Size = new System.Drawing.Size(60, 85);
            this.txtCellInput.TabIndex = 1;
            this.txtCellInput.Text = "34";
            this.txtCellInput.WordWrap = false;
            this.txtCellInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SudokuCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtCellInput);
            this.MaximumSize = new System.Drawing.Size(60, 60);
            this.MinimumSize = new System.Drawing.Size(60, 60);
            this.Name = "SudokuCell";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCellInput;
    }
}
