namespace Tyuiu.MolchanovIV.Sprint6.Task7.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MIV));
            panelHeader = new Panel();
            buttonAbout_MIV = new Button();
            buttonPerform_MIV = new Button();
            buttonSave_MIV = new Button();
            buttonOpen_MIV = new Button();
            panelGeneral = new Panel();
            groupBoxGeneral_MIV = new GroupBox();
            info_textBoxGeneral_MIV = new TextBox();
            splitContainerMain = new SplitContainer();
            groupBoxInput_MIV = new GroupBox();
            dataGridViewInput_MIV = new DataGridView();
            groupBox1 = new GroupBox();
            dataGridViewOutput_MIV = new DataGridView();
            openFileDialogMain = new OpenFileDialog();
            toolTipGeneral = new ToolTip(components);
            saveFileDialogMain_MIV = new SaveFileDialog();
            panelHeader.SuspendLayout();
            panelGeneral.SuspendLayout();
            groupBoxGeneral_MIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            groupBoxInput_MIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MIV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Control;
            panelHeader.Controls.Add(buttonAbout_MIV);
            panelHeader.Controls.Add(buttonPerform_MIV);
            panelHeader.Controls.Add(buttonSave_MIV);
            panelHeader.Controls.Add(buttonOpen_MIV);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(784, 71);
            panelHeader.TabIndex = 0;
            // 
            // buttonAbout_MIV
            // 
            buttonAbout_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_MIV.Image = (Image)resources.GetObject("buttonAbout_MIV.Image");
            buttonAbout_MIV.Location = new Point(712, 8);
            buttonAbout_MIV.Name = "buttonAbout_MIV";
            buttonAbout_MIV.Size = new Size(60, 60);
            buttonAbout_MIV.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonAbout_MIV, "Информация о себе");
            buttonAbout_MIV.UseVisualStyleBackColor = true;
            buttonAbout_MIV.Click += buttonAbout_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.Enabled = false;
            buttonPerform_MIV.Image = (Image)resources.GetObject("buttonPerform_MIV.Image");
            buttonPerform_MIV.Location = new Point(78, 8);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(60, 60);
            buttonPerform_MIV.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonPerform_MIV, "Созраняет файл в формате .csv");
            buttonPerform_MIV.UseVisualStyleBackColor = true;
            buttonPerform_MIV.Click += buttonPerform_MIV_Click;
            // 
            // buttonSave_MIV
            // 
            buttonSave_MIV.Enabled = false;
            buttonSave_MIV.Image = (Image)resources.GetObject("buttonSave_MIV.Image");
            buttonSave_MIV.Location = new Point(144, 8);
            buttonSave_MIV.Name = "buttonSave_MIV";
            buttonSave_MIV.Size = new Size(60, 60);
            buttonSave_MIV.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonSave_MIV, "Выполняет функцию и выводит\r\nрезультат в окно Вывода данных");
            buttonSave_MIV.UseVisualStyleBackColor = true;
            buttonSave_MIV.Click += buttonSave_MIV_Click;
            // 
            // buttonOpen_MIV
            // 
            buttonOpen_MIV.Image = (Image)resources.GetObject("buttonOpen_MIV.Image");
            buttonOpen_MIV.Location = new Point(12, 8);
            buttonOpen_MIV.Name = "buttonOpen_MIV";
            buttonOpen_MIV.Size = new Size(60, 60);
            buttonOpen_MIV.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonOpen_MIV, "Открывает указанный файл\r\nи выводит таблицу в окно Ввода");
            buttonOpen_MIV.UseVisualStyleBackColor = true;
            buttonOpen_MIV.Click += buttonOpen_MIV_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.BackColor = SystemColors.Control;
            panelGeneral.Controls.Add(groupBoxGeneral_MIV);
            panelGeneral.Dock = DockStyle.Top;
            panelGeneral.Location = new Point(0, 71);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(784, 74);
            panelGeneral.TabIndex = 1;
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral_MIV);
            groupBoxGeneral_MIV.Dock = DockStyle.Top;
            groupBoxGeneral_MIV.Location = new Point(0, 0);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(784, 62);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // info_textBoxGeneral_MIV
            // 
            info_textBoxGeneral_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral_MIV.Dock = DockStyle.Top;
            info_textBoxGeneral_MIV.Location = new Point(3, 19);
            info_textBoxGeneral_MIV.Multiline = true;
            info_textBoxGeneral_MIV.Name = "info_textBoxGeneral_MIV";
            info_textBoxGeneral_MIV.Size = new Size(778, 46);
            info_textBoxGeneral_MIV.TabIndex = 0;
            info_textBoxGeneral_MIV.Text = resources.GetString("info_textBoxGeneral_MIV.Text");
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 145);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.BackColor = Color.FromArgb(192, 255, 192);
            splitContainerMain.Panel1.Controls.Add(groupBoxInput_MIV);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.BackColor = Color.FromArgb(192, 192, 255);
            splitContainerMain.Panel2.Controls.Add(groupBox1);
            splitContainerMain.Size = new Size(784, 216);
            splitContainerMain.SplitterDistance = 383;
            splitContainerMain.TabIndex = 2;
            // 
            // groupBoxInput_MIV
            // 
            groupBoxInput_MIV.BackColor = SystemColors.Control;
            groupBoxInput_MIV.Controls.Add(dataGridViewInput_MIV);
            groupBoxInput_MIV.Dock = DockStyle.Fill;
            groupBoxInput_MIV.Location = new Point(0, 0);
            groupBoxInput_MIV.Name = "groupBoxInput_MIV";
            groupBoxInput_MIV.Size = new Size(383, 216);
            groupBoxInput_MIV.TabIndex = 0;
            groupBoxInput_MIV.TabStop = false;
            groupBoxInput_MIV.Text = "Ввод:";
            // 
            // dataGridViewInput_MIV
            // 
            dataGridViewInput_MIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_MIV.Dock = DockStyle.Fill;
            dataGridViewInput_MIV.Location = new Point(3, 19);
            dataGridViewInput_MIV.Name = "dataGridViewInput_MIV";
            dataGridViewInput_MIV.Size = new Size(377, 194);
            dataGridViewInput_MIV.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(dataGridViewOutput_MIV);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_MIV
            // 
            dataGridViewOutput_MIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MIV.Dock = DockStyle.Fill;
            dataGridViewOutput_MIV.Location = new Point(3, 19);
            dataGridViewOutput_MIV.Name = "dataGridViewOutput_MIV";
            dataGridViewOutput_MIV.Size = new Size(391, 194);
            dataGridViewOutput_MIV.TabIndex = 0;
            // 
            // openFileDialogMain
            // 
            openFileDialogMain.FileName = "openFileDialog1";
            // 
            // toolTipGeneral
            // 
            toolTipGeneral.ToolTipIcon = ToolTipIcon.Info;
            toolTipGeneral.ToolTipTitle = "Подсказка";
            // 
            // FormMain_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(splitContainerMain);
            Controls.Add(panelGeneral);
            Controls.Add(panelHeader);
            MinimumSize = new Size(800, 400);
            Name = "FormMain_MIV";
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Молчанов И.В.";
            panelHeader.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            groupBoxInput_MIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_MIV).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelGeneral;
        private SplitContainer splitContainerMain;
        private GroupBox groupBoxGeneral_MIV;
        private Button buttonAbout_MIV;
        private Button buttonPerform_MIV;
        private Button buttonOpen_MIV;
        private TextBox info_textBoxGeneral_MIV;
        private Button buttonSave_MIV;
        private ToolTip toolTipGeneral;
        private OpenFileDialog openFileDialogMain;
        private GroupBox groupBoxInput_MIV;
        private DataGridView dataGridViewInput_MIV;
        private GroupBox groupBox1;
        private DataGridView dataGridViewOutput_MIV;
        private SaveFileDialog saveFileDialogMain_MIV;
    }
}
