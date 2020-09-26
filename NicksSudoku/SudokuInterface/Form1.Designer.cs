namespace SudokuInterface
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlSudokuPlaceHoldr = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerate.Location = new System.Drawing.Point(15, 15);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(15);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Padding = new System.Windows.Forms.Padding(15);
            this.btnGenerate.Size = new System.Drawing.Size(182, 52);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlSudokuPlaceHoldr
            // 
            this.pnlSudokuPlaceHoldr.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlSudokuPlaceHoldr.Location = new System.Drawing.Point(10, 10);
            this.pnlSudokuPlaceHoldr.MaximumSize = new System.Drawing.Size(560, 560);
            this.pnlSudokuPlaceHoldr.MinimumSize = new System.Drawing.Size(560, 560);
            this.pnlSudokuPlaceHoldr.Name = "pnlSudokuPlaceHoldr";
            this.pnlSudokuPlaceHoldr.Size = new System.Drawing.Size(560, 560);
            this.pnlSudokuPlaceHoldr.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlSudokuPlaceHoldr);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1MinSize = 560;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerate);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer1.Panel2MinSize = 80;
            this.splitContainer1.Size = new System.Drawing.Size(800, 596);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlSudokuPlaceHoldr;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

