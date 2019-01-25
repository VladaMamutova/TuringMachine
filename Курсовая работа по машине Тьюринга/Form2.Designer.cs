namespace Курсовая_работа_по_машине_Тьюринга
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WordLength = new System.Windows.Forms.NumericUpDown();
            this.TWordLength = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea2.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea2);
            this.Graph.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Name = "GraphLine";
            this.Graph.Legends.Add(legend2);
            this.Graph.Location = new System.Drawing.Point(25, 51);
            this.Graph.Margin = new System.Windows.Forms.Padding(4);
            this.Graph.Name = "Graph";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "GraphLine";
            series2.LegendText = "График\\nвременной\\nсложности\\nалгоритма";
            series2.Name = "GraphSeries";
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(691, 454);
            this.Graph.TabIndex = 4;
            this.Graph.Text = "График";
            // 
            // WordLength
            // 
            this.WordLength.Location = new System.Drawing.Point(238, 17);
            this.WordLength.Margin = new System.Windows.Forms.Padding(4);
            this.WordLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WordLength.Name = "WordLength";
            this.WordLength.Size = new System.Drawing.Size(62, 26);
            this.WordLength.TabIndex = 0;
            this.WordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WordLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TWordLength
            // 
            this.TWordLength.AutoSize = true;
            this.TWordLength.Location = new System.Drawing.Point(22, 19);
            this.TWordLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TWordLength.Name = "TWordLength";
            this.TWordLength.Size = new System.Drawing.Size(208, 18);
            this.TWordLength.TabIndex = 2;
            this.TWordLength.Text = "Количество символов слова";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(350, 11);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(180, 32);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(536, 11);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(180, 32);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-2, 521);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(744, 27);
            this.progressBar.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 546);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TWordLength);
            this.Controls.Add(this.WordLength);
            this.Controls.Add(this.Graph);
            this.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчёт временной сложности алгоритма";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.NumericUpDown WordLength;
        private System.Windows.Forms.Label TWordLength;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ProgressBar progressBar;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}