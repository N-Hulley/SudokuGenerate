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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstLogList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstLogImportance = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedLogInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.btnValidate);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerate);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer1.Panel2MinSize = 80;
            this.splitContainer1.Size = new System.Drawing.Size(800, 596);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(15, 119);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstLogList);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstLogImportance);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.txtSelectedLogInfo);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(182, 334);
            this.splitContainer2.SplitterDistance = 155;
            this.splitContainer2.TabIndex = 4;
            // 
            // lstLogList
            // 
            this.lstLogList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogList.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstLogList.FormattingEnabled = true;
            this.lstLogList.Location = new System.Drawing.Point(0, 0);
            this.lstLogList.Name = "lstLogList";
            this.lstLogList.Size = new System.Drawing.Size(182, 155);
            this.lstLogList.TabIndex = 10;
            this.lstLogList.SelectedIndexChanged += new System.EventHandler(this.lstLogList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 0);
            this.panel1.TabIndex = 4;
            // 
            // lstLogImportance
            // 
            this.lstLogImportance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLogImportance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLogImportance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstLogImportance.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstLogImportance.FormattingEnabled = true;
            this.lstLogImportance.Items.AddRange(new object[] {
            "Not Important",
            "Slightly Important",
            "Somewhat Important",
            "Important",
            "Very Important",
            "Critical"});
            this.lstLogImportance.Location = new System.Drawing.Point(5, 89);
            this.lstLogImportance.Name = "lstLogImportance";
            this.lstLogImportance.Size = new System.Drawing.Size(172, 80);
            this.lstLogImportance.TabIndex = 9;
            this.lstLogImportance.SelectedIndexChanged += new System.EventHandler(this.lstLogImportance_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(5, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log Importance level";
            // 
            // txtSelectedLogInfo
            // 
            this.txtSelectedLogInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSelectedLogInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedLogInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSelectedLogInfo.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSelectedLogInfo.Location = new System.Drawing.Point(5, 18);
            this.txtSelectedLogInfo.Multiline = true;
            this.txtSelectedLogInfo.Name = "txtSelectedLogInfo";
            this.txtSelectedLogInfo.ReadOnly = true;
            this.txtSelectedLogInfo.Size = new System.Drawing.Size(172, 58);
            this.txtSelectedLogInfo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected log Info";
            // 
            // btnValidate
            // 
            this.btnValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValidate.Location = new System.Drawing.Point(15, 67);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(15);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Padding = new System.Windows.Forms.Padding(15);
            this.btnValidate.Size = new System.Drawing.Size(182, 52);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlSudokuPlaceHoldr;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstLogList;
        private System.Windows.Forms.ListBox lstLogImportance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedLogInfo;
        private System.Windows.Forms.Label label2;
    }
}

