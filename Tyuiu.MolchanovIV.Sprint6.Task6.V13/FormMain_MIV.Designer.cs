namespace Tyuiu.MolchanovIV.Sprint6.Task6.V13
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
            buttonOpen_MIV = new Button();
            panelGeneral = new Panel();
            groupBoxGeneral = new GroupBox();
            info_textBoxGenral_MIV = new TextBox();
            panelInput = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxOutput_MIV = new TextBox();
            panelOutput = new Panel();
            groupBoxInput = new GroupBox();
            textBoxInput_MIV = new TextBox();
            openFileDialog_MIV = new OpenFileDialog();
            toolTip_MIV = new ToolTip(components);
            panelHeader.SuspendLayout();
            panelGeneral.SuspendLayout();
            groupBoxGeneral.SuspendLayout();
            panelInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Control;
            panelHeader.Controls.Add(buttonAbout_MIV);
            panelHeader.Controls.Add(buttonPerform_MIV);
            panelHeader.Controls.Add(buttonOpen_MIV);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(784, 76);
            panelHeader.TabIndex = 0;
            // 
            // buttonAbout_MIV
            // 
            buttonAbout_MIV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_MIV.Image = (Image)resources.GetObject("buttonAbout_MIV.Image");
            buttonAbout_MIV.Location = new Point(712, 10);
            buttonAbout_MIV.Name = "buttonAbout_MIV";
            buttonAbout_MIV.Size = new Size(60, 60);
            buttonAbout_MIV.TabIndex = 2;
            toolTip_MIV.SetToolTip(buttonAbout_MIV, "Показывает информацию о создателе");
            buttonAbout_MIV.UseVisualStyleBackColor = true;
            buttonAbout_MIV.Click += buttonAbout_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.Enabled = false;
            buttonPerform_MIV.Image = (Image)resources.GetObject("buttonPerform_MIV.Image");
            buttonPerform_MIV.Location = new Point(78, 10);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(60, 60);
            buttonPerform_MIV.TabIndex = 1;
            toolTip_MIV.SetToolTip(buttonPerform_MIV, "Выполняеи программу в соответствии с условием\r\nИ выводит итог в поле вывода\r\n");
            buttonPerform_MIV.UseVisualStyleBackColor = true;
            buttonPerform_MIV.Click += buttonPerform_MIV_Click;
            // 
            // buttonOpen_MIV
            // 
            buttonOpen_MIV.Image = (Image)resources.GetObject("buttonOpen_MIV.Image");
            buttonOpen_MIV.Location = new Point(12, 10);
            buttonOpen_MIV.Name = "buttonOpen_MIV";
            buttonOpen_MIV.Size = new Size(60, 60);
            buttonOpen_MIV.TabIndex = 0;
            toolTip_MIV.SetToolTip(buttonOpen_MIV, "Открыть файл\r\nВыберете файл который хотите открыть\r\n");
            buttonOpen_MIV.UseVisualStyleBackColor = true;
            buttonOpen_MIV.Click += buttonOpen_MIV_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.BackColor = SystemColors.Control;
            panelGeneral.Controls.Add(groupBoxGeneral);
            panelGeneral.Dock = DockStyle.Top;
            panelGeneral.Location = new Point(0, 76);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(784, 94);
            panelGeneral.TabIndex = 0;
            // 
            // groupBoxGeneral
            // 
            groupBoxGeneral.Controls.Add(info_textBoxGenral_MIV);
            groupBoxGeneral.Dock = DockStyle.Top;
            groupBoxGeneral.Location = new Point(0, 0);
            groupBoxGeneral.Name = "groupBoxGeneral";
            groupBoxGeneral.Size = new Size(784, 82);
            groupBoxGeneral.TabIndex = 0;
            groupBoxGeneral.TabStop = false;
            groupBoxGeneral.Text = "Условие";
            // 
            // info_textBoxGenral_MIV
            // 
            info_textBoxGenral_MIV.BackColor = SystemColors.Control;
            info_textBoxGenral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGenral_MIV.Dock = DockStyle.Top;
            info_textBoxGenral_MIV.Location = new Point(3, 19);
            info_textBoxGenral_MIV.Multiline = true;
            info_textBoxGenral_MIV.Name = "info_textBoxGenral_MIV";
            info_textBoxGenral_MIV.Size = new Size(778, 57);
            info_textBoxGenral_MIV.TabIndex = 0;
            info_textBoxGenral_MIV.Text = resources.GetString("info_textBoxGenral_MIV.Text");
            // 
            // panelInput
            // 
            panelInput.BackColor = SystemColors.Control;
            panelInput.Controls.Add(groupBoxOutput);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(399, 170);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(385, 241);
            panelInput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput_MIV);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(385, 241);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxOutput_MIV
            // 
            textBoxOutput_MIV.Dock = DockStyle.Fill;
            textBoxOutput_MIV.Location = new Point(3, 19);
            textBoxOutput_MIV.Multiline = true;
            textBoxOutput_MIV.Name = "textBoxOutput_MIV";
            textBoxOutput_MIV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_MIV.Size = new Size(379, 219);
            textBoxOutput_MIV.TabIndex = 0;
            // 
            // panelOutput
            // 
            panelOutput.BackColor = SystemColors.Control;
            panelOutput.Controls.Add(groupBoxInput);
            panelOutput.Dock = DockStyle.Left;
            panelOutput.Location = new Point(0, 170);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(399, 241);
            panelOutput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput_MIV);
            groupBoxInput.Dock = DockStyle.Left;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(381, 241);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // textBoxInput_MIV
            // 
            textBoxInput_MIV.Dock = DockStyle.Left;
            textBoxInput_MIV.Location = new Point(3, 19);
            textBoxInput_MIV.Multiline = true;
            textBoxInput_MIV.Name = "textBoxInput_MIV";
            textBoxInput_MIV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_MIV.Size = new Size(378, 219);
            textBoxInput_MIV.TabIndex = 0;
            // 
            // openFileDialog_MIV
            // 
            openFileDialog_MIV.FileName = "openFileDialog_MIV";
            // 
            // toolTip_MIV
            // 
            toolTip_MIV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MIV.ToolTipTitle = "Подсказка";
            // 
            // FormMain_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelInput);
            Controls.Add(panelOutput);
            Controls.Add(panelGeneral);
            Controls.Add(panelHeader);
            MinimumSize = new Size(800, 450);
            Name = "FormMain_MIV";
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Молчанов И.В.";
            panelHeader.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            groupBoxGeneral.ResumeLayout(false);
            groupBoxGeneral.PerformLayout();
            panelInput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtonAbout_MIV_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelHeader;
        private Panel panelGeneral;
        private Panel panelOutput;
        private Panel panelInput;
        private GroupBox groupBoxGeneral;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOutput_MIV;
        private TextBox textBoxInput_MIV;
        private TextBox info_textBoxGenral_MIV;
        private Button buttonOpen_MIV;
        private OpenFileDialog openFileDialog_MIV;
        private ToolTip toolTip_MIV;
        private Button buttonPerform_MIV;
        private Button buttonAbout_MIV;
    }
}
