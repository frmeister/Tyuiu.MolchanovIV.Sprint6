namespace Tyuiu.MolchanovIV.Sprint6.Task5.V18
{
    partial class FormMain_MIV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MIV));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMain_MIV = new Panel();
            buttonQuestion_MIV = new Button();
            buttonOpen_MIV = new Button();
            buttonPerform_MIV = new Button();
            groupBoxGeneral_MIV = new GroupBox();
            info_textBoxGeneral_MIV = new TextBox();
            panelOutput_MIV = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput_MIV = new DataGridView();
            panelGeneral_MIV = new Panel();
            chart_MIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelMain_MIV.SuspendLayout();
            groupBoxGeneral_MIV.SuspendLayout();
            panelOutput_MIV.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).BeginInit();
            panelGeneral_MIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_MIV).BeginInit();
            SuspendLayout();
            // 
            // panelMain_MIV
            // 
            panelMain_MIV.BackColor = SystemColors.Control;
            panelMain_MIV.Controls.Add(buttonQuestion_MIV);
            panelMain_MIV.Controls.Add(buttonOpen_MIV);
            panelMain_MIV.Controls.Add(buttonPerform_MIV);
            panelMain_MIV.Controls.Add(groupBoxGeneral_MIV);
            panelMain_MIV.Dock = DockStyle.Top;
            panelMain_MIV.Location = new Point(0, 0);
            panelMain_MIV.Name = "panelMain_MIV";
            panelMain_MIV.Size = new Size(784, 100);
            panelMain_MIV.TabIndex = 0;
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_MIV.BackColor = Color.FromArgb(255, 255, 128);
            buttonQuestion_MIV.Location = new Point(671, 12);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(101, 82);
            buttonQuestion_MIV.TabIndex = 1;
            buttonQuestion_MIV.Text = "Справка";
            buttonQuestion_MIV.UseVisualStyleBackColor = false;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // buttonOpen_MIV
            // 
            buttonOpen_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_MIV.BackColor = Color.FromArgb(128, 255, 255);
            buttonOpen_MIV.Location = new Point(564, 12);
            buttonOpen_MIV.Name = "buttonOpen_MIV";
            buttonOpen_MIV.Size = new Size(101, 82);
            buttonOpen_MIV.TabIndex = 1;
            buttonOpen_MIV.Text = "Открыть";
            buttonOpen_MIV.UseVisualStyleBackColor = false;
            buttonOpen_MIV.Click += buttonOpen_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPerform_MIV.BackColor = Color.Blue;
            buttonPerform_MIV.Location = new Point(442, 12);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(116, 82);
            buttonPerform_MIV.TabIndex = 1;
            buttonPerform_MIV.Text = "Выполнить";
            buttonPerform_MIV.UseVisualStyleBackColor = false;
            buttonPerform_MIV.Click += buttonPerform_MIV_Click;
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral_MIV);
            groupBoxGeneral_MIV.Dock = DockStyle.Left;
            groupBoxGeneral_MIV.Location = new Point(0, 0);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(436, 100);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // info_textBoxGeneral_MIV
            // 
            info_textBoxGeneral_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral_MIV.Location = new Point(3, 22);
            info_textBoxGeneral_MIV.Multiline = true;
            info_textBoxGeneral_MIV.Name = "info_textBoxGeneral_MIV";
            info_textBoxGeneral_MIV.Size = new Size(427, 72);
            info_textBoxGeneral_MIV.TabIndex = 0;
            info_textBoxGeneral_MIV.Text = resources.GetString("info_textBoxGeneral_MIV.Text");
            // 
            // panelOutput_MIV
            // 
            panelOutput_MIV.BackColor = SystemColors.Control;
            panelOutput_MIV.Controls.Add(groupBoxOutput);
            panelOutput_MIV.Dock = DockStyle.Left;
            panelOutput_MIV.Location = new Point(0, 100);
            panelOutput_MIV.Name = "panelOutput_MIV";
            panelOutput_MIV.Size = new Size(200, 311);
            panelOutput_MIV.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput_MIV);
            groupBoxOutput.Dock = DockStyle.Left;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(200, 311);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_MIV
            // 
            dataGridViewOutput_MIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MIV.Dock = DockStyle.Left;
            dataGridViewOutput_MIV.Location = new Point(3, 19);
            dataGridViewOutput_MIV.Name = "dataGridViewOutput_MIV";
            dataGridViewOutput_MIV.Size = new Size(191, 289);
            dataGridViewOutput_MIV.TabIndex = 1;
            // 
            // panelGeneral_MIV
            // 
            panelGeneral_MIV.BackColor = SystemColors.Control;
            panelGeneral_MIV.Controls.Add(chart_MIV);
            panelGeneral_MIV.Controls.Add(splitter1);
            panelGeneral_MIV.Dock = DockStyle.Fill;
            panelGeneral_MIV.Location = new Point(200, 100);
            panelGeneral_MIV.Name = "panelGeneral_MIV";
            panelGeneral_MIV.Size = new Size(584, 311);
            panelGeneral_MIV.TabIndex = 0;
            // 
            // chart_MIV
            // 
            chartArea1.Name = "ChartArea1";
            chart_MIV.ChartAreas.Add(chartArea1);
            chart_MIV.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart_MIV.Legends.Add(legend1);
            chart_MIV.Location = new Point(3, 0);
            chart_MIV.Name = "chart_MIV";
            chart_MIV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_MIV.Series.Add(series1);
            chart_MIV.Size = new Size(581, 311);
            chart_MIV.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelGeneral_MIV);
            Controls.Add(panelOutput_MIV);
            Controls.Add(panelMain_MIV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain_MIV";
            Text = "Спринт 6 | Таск 5 | Вариант 18 | Молчанов И.В.";
            panelMain_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            panelOutput_MIV.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).EndInit();
            panelGeneral_MIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_MIV).EndInit();
            ResumeLayout(false);
        }

        private void ButtonQuestion_MIV_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelMain_MIV;
        private Panel panelOutput_MIV;
        private Panel panelGeneral_MIV;
        private Splitter splitter1;
        private GroupBox groupBoxGeneral_MIV;
        private GroupBox groupBoxOutput;
        private Button buttonQuestion_MIV;
        private Button buttonOpen_MIV;
        private Button buttonPerform_MIV;
        private TextBox info_textBoxGeneral_MIV;
        private DataGridView dataGridViewOutput_MIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MIV;
    }
}
