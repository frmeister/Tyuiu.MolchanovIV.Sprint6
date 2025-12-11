namespace Tyuiu.MolchanovIV.Sprint6.Task2.V13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxGeneral_MIV = new GroupBox();
            info_textBoxGeneral_MIV = new TextBox();
            groupBoxInput_MIV = new GroupBox();
            textBoxInputMax_MIV = new TextBox();
            textBoxInputMin_MIV = new TextBox();
            info_textBoxInputMax_MIV = new TextBox();
            info_textBoxInputMin_MIV = new TextBox();
            groupBoxOutput = new GroupBox();
            chart_MIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_MIV = new DataGridView();
            buttonQuestion_MIV = new Button();
            buttonPerform_MIV = new Button();
            ColumnX_MIV = new DataGridViewTextBoxColumn();
            ColumnFunc_MIV = new DataGridViewTextBoxColumn();
            groupBoxGeneral_MIV.SuspendLayout();
            groupBoxInput_MIV.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MIV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MIV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral_MIV);
            groupBoxGeneral_MIV.Location = new Point(12, 12);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(766, 408);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // info_textBoxGeneral_MIV
            // 
            info_textBoxGeneral_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral_MIV.Location = new Point(6, 22);
            info_textBoxGeneral_MIV.Multiline = true;
            info_textBoxGeneral_MIV.Name = "info_textBoxGeneral_MIV";
            info_textBoxGeneral_MIV.Size = new Size(314, 43);
            info_textBoxGeneral_MIV.TabIndex = 0;
            info_textBoxGeneral_MIV.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и построить график";
            // 
            // groupBoxInput_MIV
            // 
            groupBoxInput_MIV.Controls.Add(textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(textBoxInputMin_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMin_MIV);
            groupBoxInput_MIV.Location = new Point(12, 426);
            groupBoxInput_MIV.Name = "groupBoxInput_MIV";
            groupBoxInput_MIV.Size = new Size(507, 101);
            groupBoxInput_MIV.TabIndex = 0;
            groupBoxInput_MIV.TabStop = false;
            groupBoxInput_MIV.Text = "Ввод данных";
            // 
            // textBoxInputMax_MIV
            // 
            textBoxInputMax_MIV.Location = new Point(220, 63);
            textBoxInputMax_MIV.Name = "textBoxInputMax_MIV";
            textBoxInputMax_MIV.Size = new Size(200, 23);
            textBoxInputMax_MIV.TabIndex = 3;
            // 
            // textBoxInputMin_MIV
            // 
            textBoxInputMin_MIV.Location = new Point(6, 63);
            textBoxInputMin_MIV.Name = "textBoxInputMin_MIV";
            textBoxInputMin_MIV.Size = new Size(200, 23);
            textBoxInputMin_MIV.TabIndex = 2;
            // 
            // info_textBoxInputMax_MIV
            // 
            info_textBoxInputMax_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMax_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMax_MIV.Location = new Point(220, 32);
            info_textBoxInputMax_MIV.Name = "info_textBoxInputMax_MIV";
            info_textBoxInputMax_MIV.Size = new Size(100, 16);
            info_textBoxInputMax_MIV.TabIndex = 1;
            info_textBoxInputMax_MIV.Text = "Конец шага:";
            // 
            // info_textBoxInputMin_MIV
            // 
            info_textBoxInputMin_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMin_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMin_MIV.Location = new Point(6, 32);
            info_textBoxInputMin_MIV.Name = "info_textBoxInputMin_MIV";
            info_textBoxInputMin_MIV.Size = new Size(100, 16);
            info_textBoxInputMin_MIV.TabIndex = 0;
            info_textBoxInputMin_MIV.Text = "Старт шага:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chart_MIV);
            groupBoxOutput.Controls.Add(dataGridView_MIV);
            groupBoxOutput.Location = new Point(784, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(539, 515);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // chart_MIV
            // 
            chartArea1.Name = "ChartArea1";
            chart_MIV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_MIV.Legends.Add(legend1);
            chart_MIV.Location = new Point(191, 22);
            chart_MIV.Name = "chart_MIV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_MIV.Series.Add(series1);
            chart_MIV.Size = new Size(423, 487);
            chart_MIV.TabIndex = 1;
            chart_MIV.Text = "chart1";
            // 
            // dataGridView_MIV
            // 
            dataGridView_MIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MIV.Columns.AddRange(new DataGridViewColumn[] { ColumnX_MIV, ColumnFunc_MIV });
            dataGridView_MIV.Location = new Point(6, 22);
            dataGridView_MIV.Name = "dataGridView_MIV";
            dataGridView_MIV.Size = new Size(179, 487);
            dataGridView_MIV.TabIndex = 0;
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.BackColor = SystemColors.Highlight;
            buttonQuestion_MIV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuestion_MIV.Location = new Point(525, 442);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(94, 85);
            buttonQuestion_MIV.TabIndex = 0;
            buttonQuestion_MIV.Text = "Справка";
            buttonQuestion_MIV.UseVisualStyleBackColor = false;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.BackColor = Color.FromArgb(0, 64, 0);
            buttonPerform_MIV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPerform_MIV.Location = new Point(625, 442);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(153, 85);
            buttonPerform_MIV.TabIndex = 2;
            buttonPerform_MIV.Text = "Выполнить";
            buttonPerform_MIV.UseVisualStyleBackColor = false;
            buttonPerform_MIV.Click += buttonPerform_MIV_Clicked;
            // 
            // ColumnX_MIV
            // 
            ColumnX_MIV.HeaderText = "X";
            ColumnX_MIV.Name = "ColumnX_MIV";
            ColumnX_MIV.ReadOnly = true;
            ColumnX_MIV.Width = 50;
            // 
            // ColumnFunc_MIV
            // 
            ColumnFunc_MIV.HeaderText = "f(X)";
            ColumnFunc_MIV.Name = "ColumnFunc_MIV";
            ColumnFunc_MIV.ReadOnly = true;
            ColumnFunc_MIV.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 539);
            Controls.Add(buttonPerform_MIV);
            Controls.Add(buttonQuestion_MIV);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput_MIV);
            Controls.Add(groupBoxGeneral_MIV);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Молчанов И.В.";
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            groupBoxInput_MIV.ResumeLayout(false);
            groupBoxInput_MIV.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MIV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MIV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGeneral_MIV;
        private GroupBox groupBoxInput_MIV;
        private Button buttonQuestion_MIV;
        private GroupBox groupBoxOutput;
        private Button buttonPerform_MIV;
        private TextBox info_textBoxGeneral_MIV;
        private TextBox info_textBoxInputMax_MIV;
        private TextBox info_textBoxInputMin_MIV;
        private TextBox textBoxInputMax_MIV;
        private TextBox textBoxInputMin_MIV;
        private DataGridView dataGridView_MIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MIV;
        private DataGridViewTextBoxColumn ColumnX_MIV;
        private DataGridViewTextBoxColumn ColumnFunc_MIV;
    }
}
