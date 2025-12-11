namespace Tyuiu.MolchanovIV.Sprint6.Task1.V8
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
            groupBoxGeneral_MIV = new GroupBox();
            groupBoxInput_MIV = new GroupBox();
            groupBoxOutput_MIV = new GroupBox();
            buttonQuestion_MIV = new Button();
            buttonPerform_MIV = new Button();
            info_textBoxGeneral_MIV = new TextBox();
            info_textBoxOutput = new TextBox();
            textBoxOutput_MIV = new TextBox();
            info_textBoxInputMin_MIV = new TextBox();
            info_textBoxInputMax_MIV = new TextBox();
            textBoxInputMin_MIV = new TextBox();
            textBoxInputMax_MIV = new TextBox();
            groupBoxGeneral_MIV.SuspendLayout();
            groupBoxInput_MIV.SuspendLayout();
            groupBoxOutput_MIV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral_MIV);
            groupBoxGeneral_MIV.Location = new Point(12, 12);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(746, 335);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // groupBoxInput_MIV
            // 
            groupBoxInput_MIV.Controls.Add(textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(textBoxInputMin_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMax_MIV);
            groupBoxInput_MIV.Controls.Add(info_textBoxInputMin_MIV);
            groupBoxInput_MIV.Location = new Point(12, 353);
            groupBoxInput_MIV.Name = "groupBoxInput_MIV";
            groupBoxInput_MIV.Size = new Size(448, 119);
            groupBoxInput_MIV.TabIndex = 0;
            groupBoxInput_MIV.TabStop = false;
            groupBoxInput_MIV.Text = "Ввод данных";
            // 
            // groupBoxOutput_MIV
            // 
            groupBoxOutput_MIV.Controls.Add(textBoxOutput_MIV);
            groupBoxOutput_MIV.Controls.Add(info_textBoxOutput);
            groupBoxOutput_MIV.Location = new Point(764, 12);
            groupBoxOutput_MIV.Name = "groupBoxOutput_MIV";
            groupBoxOutput_MIV.Size = new Size(248, 460);
            groupBoxOutput_MIV.TabIndex = 0;
            groupBoxOutput_MIV.TabStop = false;
            groupBoxOutput_MIV.Text = "Вывод данных";
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.BackColor = SystemColors.Highlight;
            buttonQuestion_MIV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuestion_MIV.Location = new Point(466, 392);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(122, 67);
            buttonQuestion_MIV.TabIndex = 0;
            buttonQuestion_MIV.Text = "Справка";
            buttonQuestion_MIV.UseVisualStyleBackColor = false;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.BackColor = Color.FromArgb(0, 192, 0);
            buttonPerform_MIV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPerform_MIV.Location = new Point(594, 392);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(164, 67);
            buttonPerform_MIV.TabIndex = 1;
            buttonPerform_MIV.Text = "Выполнить";
            buttonPerform_MIV.UseVisualStyleBackColor = false;
            buttonPerform_MIV.Click += buttonPerform_MIV_Clicked;
            // 
            // info_textBoxGeneral_MIV
            // 
            info_textBoxGeneral_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral_MIV.Location = new Point(6, 22);
            info_textBoxGeneral_MIV.Multiline = true;
            info_textBoxGeneral_MIV.Name = "info_textBoxGeneral_MIV";
            info_textBoxGeneral_MIV.Size = new Size(310, 48);
            info_textBoxGeneral_MIV.TabIndex = 2;
            info_textBoxGeneral_MIV.Text = "Протабулировать функцию на заданном диапазоне. Вывести результат в виде таблицы";
            // 
            // info_textBoxOutput
            // 
            info_textBoxOutput.BackColor = SystemColors.Control;
            info_textBoxOutput.BorderStyle = BorderStyle.None;
            info_textBoxOutput.Location = new Point(6, 22);
            info_textBoxOutput.Name = "info_textBoxOutput";
            info_textBoxOutput.Size = new Size(100, 16);
            info_textBoxOutput.TabIndex = 0;
            info_textBoxOutput.Text = "Результат:";
            // 
            // textBoxOutput_MIV
            // 
            textBoxOutput_MIV.Location = new Point(6, 44);
            textBoxOutput_MIV.Multiline = true;
            textBoxOutput_MIV.Name = "textBoxOutput_MIV";
            textBoxOutput_MIV.Size = new Size(236, 410);
            textBoxOutput_MIV.TabIndex = 1;
            textBoxOutput_MIV.Enabled = false;
            // 
            // info_textBoxInputMin_MIV
            // 
            info_textBoxInputMin_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMin_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMin_MIV.Location = new Point(6, 39);
            info_textBoxInputMin_MIV.Name = "info_textBoxInputMin_MIV";
            info_textBoxInputMin_MIV.Size = new Size(115, 16);
            info_textBoxInputMin_MIV.TabIndex = 0;
            info_textBoxInputMin_MIV.Text = "Старт шага:";
            // 
            // info_textBoxInputMax_MIV
            // 
            info_textBoxInputMax_MIV.BackColor = SystemColors.Control;
            info_textBoxInputMax_MIV.BorderStyle = BorderStyle.None;
            info_textBoxInputMax_MIV.Location = new Point(176, 39);
            info_textBoxInputMax_MIV.Name = "info_textBoxInputMax_MIV";
            info_textBoxInputMax_MIV.Size = new Size(100, 16);
            info_textBoxInputMax_MIV.TabIndex = 1;
            info_textBoxInputMax_MIV.Text = "Конец шага:";
            // 
            // textBoxInputMin_MIV
            // 
            textBoxInputMin_MIV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInputMin_MIV.Location = new Point(6, 62);
            textBoxInputMin_MIV.Name = "textBoxInputMin_MIV";
            textBoxInputMin_MIV.Size = new Size(100, 23);
            textBoxInputMin_MIV.TabIndex = 2;
            // 
            // textBoxInputMax_MIV
            // 
            textBoxInputMax_MIV.BorderStyle = BorderStyle.FixedSingle;
            textBoxInputMax_MIV.Location = new Point(176, 61);
            textBoxInputMax_MIV.Name = "textBoxInputMax_MIV";
            textBoxInputMax_MIV.Size = new Size(100, 23);
            textBoxInputMax_MIV.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 484);
            Controls.Add(buttonQuestion_MIV);
            Controls.Add(buttonPerform_MIV);
            Controls.Add(groupBoxOutput_MIV);
            Controls.Add(groupBoxInput_MIV);
            Controls.Add(groupBoxGeneral_MIV);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Молчанов И.В.";
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            groupBoxInput_MIV.ResumeLayout(false);
            groupBoxInput_MIV.PerformLayout();
            groupBoxOutput_MIV.ResumeLayout(false);
            groupBoxOutput_MIV.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtonQuestion_MIV_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxGeneral_MIV;
        private GroupBox groupBoxInput_MIV;
        private GroupBox groupBoxOutput_MIV;
        private Button buttonQuestion_MIV;
        private Button buttonPerform_MIV;
        private TextBox info_textBoxGeneral_MIV;
        private TextBox textBoxOutput_MIV;
        private TextBox info_textBoxOutput;
        private TextBox textBoxInputMax_MIV;
        private TextBox textBoxInputMin_MIV;
        private TextBox info_textBoxInputMax_MIV;
        private TextBox info_textBoxInputMin_MIV;
    }
}
