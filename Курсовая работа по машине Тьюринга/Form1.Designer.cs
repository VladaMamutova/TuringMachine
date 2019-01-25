namespace Курсовая_работа_по_машине_Тьюринга
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TTargetWord = new System.Windows.Forms.Label();
            this.TSourceWord = new System.Windows.Forms.Label();
            this.SourceWord = new System.Windows.Forms.TextBox();
            this.Solve = new System.Windows.Forms.Button();
            this.TimeComplexity = new System.Windows.Forms.Button();
            this.AlgorithmSteps = new System.Windows.Forms.DataGridView();
            this.Tape1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AlgorithmSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TTargetWord
            // 
            this.TTargetWord.AutoSize = true;
            this.TTargetWord.Location = new System.Drawing.Point(22, 18);
            this.TTargetWord.Name = "TTargetWord";
            this.TTargetWord.Size = new System.Drawing.Size(194, 18);
            this.TTargetWord.TabIndex = 1;
            this.TTargetWord.Text = "L = { w w | w є { a, b, c } * }";
            // 
            // TSourceWord
            // 
            this.TSourceWord.AutoSize = true;
            this.TSourceWord.Location = new System.Drawing.Point(12, 357);
            this.TSourceWord.Name = "TSourceWord";
            this.TSourceWord.Size = new System.Drawing.Size(52, 18);
            this.TSourceWord.TabIndex = 2;
            this.TSourceWord.Text = "Слово";
            // 
            // SourceWord
            // 
            this.SourceWord.Location = new System.Drawing.Point(70, 354);
            this.SourceWord.Name = "SourceWord";
            this.SourceWord.Size = new System.Drawing.Size(229, 26);
            this.SourceWord.TabIndex = 3;
            this.SourceWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SourceWord_KeyPress);
            // 
            // Solve
            // 
            this.Solve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Solve.Location = new System.Drawing.Point(305, 354);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(206, 26);
            this.Solve.TabIndex = 4;
            this.Solve.Text = "Запустить МТ";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // TimeComplexity
            // 
            this.TimeComplexity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeComplexity.Location = new System.Drawing.Point(234, 11);
            this.TimeComplexity.Name = "TimeComplexity";
            this.TimeComplexity.Size = new System.Drawing.Size(277, 32);
            this.TimeComplexity.TabIndex = 6;
            this.TimeComplexity.Text = "Расчет временной сложности МТ";
            this.TimeComplexity.UseVisualStyleBackColor = true;
            this.TimeComplexity.Click += new System.EventHandler(this.TimeComplexity_Click);
            // 
            // AlgorithmSteps
            // 
            this.AlgorithmSteps.AllowUserToAddRows = false;
            this.AlgorithmSteps.AllowUserToDeleteRows = false;
            this.AlgorithmSteps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlgorithmSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AlgorithmSteps.ColumnHeadersHeight = 27;
            this.AlgorithmSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AlgorithmSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tape1,
            this.Tape2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlgorithmSteps.DefaultCellStyle = dataGridViewCellStyle3;
            this.AlgorithmSteps.Location = new System.Drawing.Point(530, 12);
            this.AlgorithmSteps.Name = "AlgorithmSteps";
            this.AlgorithmSteps.RowHeadersVisible = false;
            this.AlgorithmSteps.RowHeadersWidth = 50;
            this.AlgorithmSteps.Size = new System.Drawing.Size(310, 368);
            this.AlgorithmSteps.TabIndex = 7;
            // 
            // Tape1
            // 
            this.Tape1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tape1.HeaderText = "Лента 1";
            this.Tape1.MinimumWidth = 145;
            this.Tape1.Name = "Tape1";
            this.Tape1.ReadOnly = true;
            this.Tape1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tape1.Width = 145;
            // 
            // Tape2
            // 
            this.Tape2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tape2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tape2.HeaderText = "Лента 2";
            this.Tape2.MinimumWidth = 145;
            this.Tape2.Name = "Tape2";
            this.Tape2.ReadOnly = true;
            this.Tape2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tape2.Width = 145;
            // 
            // FuncTable
            // 
            this.FuncTable.AllowUserToAddRows = false;
            this.FuncTable.AllowUserToDeleteRows = false;
            this.FuncTable.AllowUserToResizeColumns = false;
            this.FuncTable.AllowUserToResizeRows = false;
            this.FuncTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FuncTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FuncTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FuncTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FuncTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.FuncTable.Location = new System.Drawing.Point(13, 51);
            this.FuncTable.Margin = new System.Windows.Forms.Padding(4);
            this.FuncTable.Name = "FuncTable";
            this.FuncTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FuncTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FuncTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.FuncTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FuncTable.Size = new System.Drawing.Size(498, 293);
            this.FuncTable.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 389);
            this.Controls.Add(this.FuncTable);
            this.Controls.Add(this.AlgorithmSteps);
            this.Controls.Add(this.TimeComplexity);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.SourceWord);
            this.Controls.Add(this.TSourceWord);
            this.Controls.Add(this.TTargetWord);
            this.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа по машине Тьюринга";
            ((System.ComponentModel.ISupportInitialize)(this.AlgorithmSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TTargetWord;
        private System.Windows.Forms.Label TSourceWord;
        private System.Windows.Forms.TextBox SourceWord;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button TimeComplexity;
        private System.Windows.Forms.DataGridView AlgorithmSteps;
        private System.Windows.Forms.DataGridView FuncTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tape2;
    }
}

