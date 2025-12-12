namespace Tyuiu.MolchanovIV.Sprint6.Task4.V22
{
    partial class FormMain
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
            panelMain = new Panel();
            buttonQuestion_MIV = new Button();
            buttonSave_MIV = new Button();
            buttonPerform_MIV = new Button();
            groupBoxInput_MIV = new GroupBox();
            textBoxInputMax_MIV = new TextBox();
            textBoxInputMin_MIV = new TextBox();
            info_textBoxInputMax_MIV = new TextBox();
            info_textBoxInputMin_MIV = new TextBox();
            groupBoxGeneral_MIV = new GroupBox();
            info_textBoxGeneral_MIV = new TextBox();
            panelOutput = new Panel();
            groupBoxOutput_MIV = new GroupBox();
            textBoxOutput_MIV = new TextBox();
            panelChart = new Panel();
            chart_MIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter = new Splitter();
            panelMain.SuspendLayout();
            groupBoxInput_MIV.SuspendLayout();
            groupBoxGeneral_MIV.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxOutput_MIV.SuspendLayout();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MIV).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Control;
            panelMain.Controls.Add(buttonQuestion_MIV);
            panelMain.Controls.Add(buttonSave_MIV);
            panelMain.Controls.Add(buttonPerform_MIV);
            panelMain.Controls.Add(groupBoxInput_MIV);
            panelMain.Controls.Add(groupBoxGeneral_MIV);
            panelMain.Dock = DockStyle.Top;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(790, 100);
            panelMain.TabIndex = 0;
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_MIV.BackColor = Color.FromArgb(255, 255, 128);
            buttonQuestion_MIV.Location = new Point(680, 12);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(98, 79);
            buttonQuestion_MIV.TabIndex = 4;
            buttonQuestion_MIV.Text = "Справка";
            buttonQuestion_MIV.UseVisualStyleBackColor = false;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // buttonSave_MIV
            // 
            buttonSave_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_MIV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_MIV.Location = new Point(571, 9);
            buttonSave_MIV.Name = "buttonSave_MIV";
            buttonSave_MIV.Size = new Size(103, 79);
            buttonSave_MIV.TabIndex = 3;
            buttonSave_MIV.Text = "Сохранить";
            buttonSave_MIV.UseVisualStyleBackColor = false;
            buttonSave_MIV.Click += buttonSave_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPerform_MIV.BackColor = Color.Blue;
            buttonPerform_MIV.ForeColor = SystemColors.ControlText;
            buttonPerform_MIV.Location = new Point(453, 9);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(112, 79);
            buttonPerform_MIV.TabIndex = 2;
            buttonPerform_MIV.Text = "Выполнить";
            buttonPerform_MIV.UseVisualStyleBackColor = false;
            buttonPerform_MIV.Click += buttonPerform_MIV_Click;
            // 
            // groupBoxInput_MIV
            // 
            groupBoxInput_MIV.Controls.Add(textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(textBoxInputMin_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMin_MIV);
            groupBoxInput_MIV.Location = new Point(244, 3);
            groupBoxInput_MIV.Name = "groupBoxInput_MIV";
            groupBoxInput_MIV.Size = new Size(197, 91);
            groupBoxInput_MIV.TabIndex = 1;
            groupBoxInput_MIV.TabStop = false;
            groupBoxInput_MIV.Text = "Ввод данных";
            // 
            // textBoxInputMax_MIV
            // 
            textBoxInputMax_MIV.Location = new Point(100, 44);
            textBoxInputMax_MIV.Name = "textBoxInputMax_MIV";
            textBoxInputMax_MIV.Size = new Size(91, 23);
            textBoxInputMax_MIV.TabIndex = 2;
            // 
            // textBoxInputMin_MIV
            // 
            textBoxInputMin_MIV.Location = new Point(6, 44);
            textBoxInputMin_MIV.Name = "textBoxInputMin_MIV";
            textBoxInputMin_MIV.Size = new Size(88, 23);
            textBoxInputMin_MIV.TabIndex = 1;
            // 
            // info_textBoxInputMax_MIV
            // 
            info_textBoxInputMax_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMax_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMax_MIV.Location = new Point(100, 22);
            info_textBoxInputMax_MIV.Name = "info_textBoxInputMax_MIV";
            info_textBoxInputMax_MIV.Size = new Size(91, 16);
            info_textBoxInputMax_MIV.TabIndex = 0;
            info_textBoxInputMax_MIV.Text = "Конец шага:";
            // 
            // info_textBoxInputMin_MIV
            // 
            info_textBoxInputMin_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMin_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMin_MIV.Location = new Point(6, 22);
            info_textBoxInputMin_MIV.Name = "info_textBoxInputMin_MIV";
            info_textBoxInputMin_MIV.Size = new Size(88, 16);
            info_textBoxInputMin_MIV.TabIndex = 0;
            info_textBoxInputMin_MIV.Text = "Старт шага:";
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral_MIV);
            groupBoxGeneral_MIV.Location = new Point(3, 3);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(235, 91);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // info_textBoxGeneral_MIV
            // 
            info_textBoxGeneral_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral_MIV.Location = new Point(9, 22);
            info_textBoxGeneral_MIV.Multiline = true;
            info_textBoxGeneral_MIV.Name = "info_textBoxGeneral_MIV";
            info_textBoxGeneral_MIV.Size = new Size(220, 63);
            info_textBoxGeneral_MIV.TabIndex = 0;
            info_textBoxGeneral_MIV.Text = "Написать программу, которая выводит таблицу значений функции:\r\n(произвести табулирование) f(x) на заданном диапазоне  [-5; 5]\r\n";
            // 
            // panelOutput
            // 
            panelOutput.BackColor = SystemColors.Control;
            panelOutput.Controls.Add(groupBoxOutput_MIV);
            panelOutput.Dock = DockStyle.Left;
            panelOutput.Location = new Point(0, 100);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(200, 311);
            panelOutput.TabIndex = 0;
            // 
            // groupBoxOutput_MIV
            // 
            groupBoxOutput_MIV.Controls.Add(textBoxOutput_MIV);
            groupBoxOutput_MIV.Dock = DockStyle.Fill;
            groupBoxOutput_MIV.Location = new Point(0, 0);
            groupBoxOutput_MIV.Name = "groupBoxOutput_MIV";
            groupBoxOutput_MIV.Size = new Size(200, 311);
            groupBoxOutput_MIV.TabIndex = 1;
            groupBoxOutput_MIV.TabStop = false;
            groupBoxOutput_MIV.Text = "Вывод";
            // 
            // textBoxOutput_MIV
            // 
            textBoxOutput_MIV.Dock = DockStyle.Fill;
            textBoxOutput_MIV.Location = new Point(3, 19);
            textBoxOutput_MIV.Multiline = true;
            textBoxOutput_MIV.Name = "textBoxOutput_MIV";
            textBoxOutput_MIV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MIV.Size = new Size(194, 289);
            textBoxOutput_MIV.TabIndex = 1;
            // 
            // panelChart
            // 
            panelChart.BackColor = SystemColors.Control;
            panelChart.Controls.Add(chart_MIV);
            panelChart.Controls.Add(splitter);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(200, 100);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(590, 311);
            panelChart.TabIndex = 0;
            // 
            // chart_MIV
            // 
            chartArea1.Name = "ChartArea1";
            chart_MIV.ChartAreas.Add(chartArea1);
            chart_MIV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_MIV.Legends.Add(legend1);
            chart_MIV.Location = new Point(3, 0);
            chart_MIV.Name = "chart_MIV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_MIV.Series.Add(series1);
            chart_MIV.Size = new Size(587, 311);
            chart_MIV.TabIndex = 1;
            // 
            // splitter
            // 
            splitter.Location = new Point(0, 0);
            splitter.Name = "splitter";
            splitter.Size = new Size(3, 311);
            splitter.TabIndex = 0;
            splitter.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 411);
            Controls.Add(panelChart);
            Controls.Add(panelOutput);
            Controls.Add(panelMain);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 22 | Молчанов И.В.";
            panelMain.ResumeLayout(false);
            groupBoxInput_MIV.ResumeLayout(false);
            groupBoxInput_MIV.PerformLayout();
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxOutput_MIV.ResumeLayout(false);
            groupBoxOutput_MIV.PerformLayout();
            panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MIV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelOutput;
        private Panel panelChart;
        private Splitter splitter;
        private GroupBox groupBoxGeneral_MIV;
        private GroupBox groupBoxOutput_MIV;
        private Button buttonQuestion_MIV;
        private Button buttonSave_MIV;
        private Button buttonPerform_MIV;
        private GroupBox groupBoxInput_MIV;
        private TextBox info_textBoxGeneral_MIV;
        private TextBox textBoxInputMax_MIV;
        private TextBox textBoxInputMin_MIV;
        private TextBox info_textBoxInputMax_MIV;
        private TextBox info_textBoxInputMin_MIV;
        private TextBox textBoxOutput_MIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MIV;
    }
}
