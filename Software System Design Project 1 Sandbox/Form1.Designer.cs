namespace Software_System_Design_Project_1_Sandbox
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.populateChartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numTestRollsLabel = new System.Windows.Forms.Label();
            this.numTestRollsTextbox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.chartResetButton = new System.Windows.Forms.Button();
            this.finalResultsTextBox = new System.Windows.Forms.RichTextBox();
            this.testResultsLabel = new System.Windows.Forms.Label();
            this.printResultsButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // populateChartButton
            // 
            this.populateChartButton.Location = new System.Drawing.Point(25, 606);
            this.populateChartButton.Name = "populateChartButton";
            this.populateChartButton.Size = new System.Drawing.Size(233, 98);
            this.populateChartButton.TabIndex = 1;
            this.populateChartButton.Text = "Populate Charts";
            this.populateChartButton.UseVisualStyleBackColor = true;
            this.populateChartButton.Click += new System.EventHandler(this.populateChartButton_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // numTestRollsLabel
            // 
            this.numTestRollsLabel.AutoSize = true;
            this.numTestRollsLabel.Location = new System.Drawing.Point(12, 490);
            this.numTestRollsLabel.Name = "numTestRollsLabel";
            this.numTestRollsLabel.Size = new System.Drawing.Size(114, 25);
            this.numTestRollsLabel.TabIndex = 7;
            this.numTestRollsLabel.Text = "# Test Rolls";
            // 
            // numTestRollsTextbox
            // 
            this.numTestRollsTextbox.Location = new System.Drawing.Point(152, 490);
            this.numTestRollsTextbox.Name = "numTestRollsTextbox";
            this.numTestRollsTextbox.Size = new System.Drawing.Size(106, 29);
            this.numTestRollsTextbox.TabIndex = 6;
            this.numTestRollsTextbox.Text = "6000";
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(20, 543);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(115, 25);
            this.seedLabel.TabIndex = 10;
            this.seedLabel.Text = "Seed Value";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(152, 539);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(106, 29);
            this.seedTextBox.TabIndex = 9;
            this.seedTextBox.Text = "6000";
            // 
            // chartResetButton
            // 
            this.chartResetButton.Location = new System.Drawing.Point(25, 726);
            this.chartResetButton.Name = "chartResetButton";
            this.chartResetButton.Size = new System.Drawing.Size(233, 93);
            this.chartResetButton.TabIndex = 11;
            this.chartResetButton.Text = "Reset Charts";
            this.chartResetButton.UseVisualStyleBackColor = true;
            this.chartResetButton.Click += new System.EventHandler(this.chartResetButton_Click);
            // 
            // finalResultsTextBox
            // 
            this.finalResultsTextBox.Location = new System.Drawing.Point(281, 490);
            this.finalResultsTextBox.Name = "finalResultsTextBox";
            this.finalResultsTextBox.Size = new System.Drawing.Size(488, 454);
            this.finalResultsTextBox.TabIndex = 12;
            this.finalResultsTextBox.Text = "";
            // 
            // testResultsLabel
            // 
            this.testResultsLabel.AutoSize = true;
            this.testResultsLabel.Location = new System.Drawing.Point(460, 452);
            this.testResultsLabel.Name = "testResultsLabel";
            this.testResultsLabel.Size = new System.Drawing.Size(120, 25);
            this.testResultsLabel.TabIndex = 13;
            this.testResultsLabel.Text = "Test Results";
            // 
            // printResultsButton
            // 
            this.printResultsButton.Location = new System.Drawing.Point(25, 848);
            this.printResultsButton.Name = "printResultsButton";
            this.printResultsButton.Size = new System.Drawing.Size(233, 96);
            this.printResultsButton.TabIndex = 14;
            this.printResultsButton.Text = "Print Results";
            this.printResultsButton.UseVisualStyleBackColor = true;
            this.printResultsButton.Click += new System.EventHandler(this.printResults);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 57);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Die #1 Rolls";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(744, 374);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(827, 57);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Die #2 Rolls";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(751, 374);
            this.chart2.TabIndex = 29;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea3.AxisX.IntervalOffset = 1D;
            chartArea3.AxisX2.Maximum = 12D;
            chartArea3.AxisX2.Minimum = 2D;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(827, 490);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Combined Die Rolls";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(751, 454);
            this.chart3.TabIndex = 30;
            this.chart3.Text = "chart3";
            // 
            // die1Label
            // 
            this.die1Label.AutoSize = true;
            this.die1Label.Location = new System.Drawing.Point(350, 29);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(68, 25);
            this.die1Label.TabIndex = 31;
            this.die1Label.Text = "Die #1";
            // 
            // die2Label
            // 
            this.die2Label.AutoSize = true;
            this.die2Label.Location = new System.Drawing.Point(1170, 29);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(68, 25);
            this.die2Label.TabIndex = 32;
            this.die2Label.Text = "Die #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1110, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Combined Die Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 956);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.printResultsButton);
            this.Controls.Add(this.testResultsLabel);
            this.Controls.Add(this.finalResultsTextBox);
            this.Controls.Add(this.chartResetButton);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.numTestRollsLabel);
            this.Controls.Add(this.numTestRollsTextbox);
            this.Controls.Add(this.populateChartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1628, 1020);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1628, 1020);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Super Lucky Dice Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button populateChartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label numTestRollsLabel;
        private System.Windows.Forms.TextBox numTestRollsTextbox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Button chartResetButton;
        private System.Windows.Forms.RichTextBox finalResultsTextBox;
        private System.Windows.Forms.Label testResultsLabel;
        private System.Windows.Forms.Button printResultsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Label label1;
    }
}

