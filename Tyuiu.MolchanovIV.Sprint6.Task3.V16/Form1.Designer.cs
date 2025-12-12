namespace Tyuiu.MolchanovIV.Sprint6.Task3.V16
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
            info_textBoxGeneral2_MIV = new TextBox();
            info_textBoxGeneral1_MIV = new TextBox();
            groupBoxOutput_MIV = new GroupBox();
            buttonQuestion_MIV = new Button();
            buttonPerform_MIV = new Button();
            dataGridViewOutput_MIV = new DataGridView();
            groupBoxGeneral_MIV.SuspendLayout();
            groupBoxOutput_MIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral2_MIV);
            groupBoxGeneral_MIV.Controls.Add(info_textBoxGeneral1_MIV);
            groupBoxGeneral_MIV.Location = new Point(12, 12);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(584, 426);
            groupBoxGeneral_MIV.TabIndex = 0;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // info_textBoxGeneral2_MIV
            // 
            info_textBoxGeneral2_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral2_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral2_MIV.Enabled = false;
            info_textBoxGeneral2_MIV.Location = new Point(6, 65);
            info_textBoxGeneral2_MIV.Multiline = true;
            info_textBoxGeneral2_MIV.Name = "info_textBoxGeneral2_MIV";
            info_textBoxGeneral2_MIV.Size = new Size(108, 86);
            info_textBoxGeneral2_MIV.TabIndex = 1;
            info_textBoxGeneral2_MIV.Text = "14   1  -3   1  10\r\n 7  -3   5  -4   0\r\n -10 -19 -18  -9  19\r\n -2  -2 -16   2 -17\r\n -16   9   5 -10  16";
            // 
            // info_textBoxGeneral1_MIV
            // 
            info_textBoxGeneral1_MIV.BackColor = SystemColors.Control;
            info_textBoxGeneral1_MIV.BorderStyle = BorderStyle.None;
            info_textBoxGeneral1_MIV.Location = new Point(6, 22);
            info_textBoxGeneral1_MIV.Multiline = true;
            info_textBoxGeneral1_MIV.Name = "info_textBoxGeneral1_MIV";
            info_textBoxGeneral1_MIV.Size = new Size(245, 37);
            info_textBoxGeneral1_MIV.TabIndex = 0;
            info_textBoxGeneral1_MIV.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.";
            // 
            // groupBoxOutput_MIV
            // 
            groupBoxOutput_MIV.Controls.Add(buttonQuestion_MIV);
            groupBoxOutput_MIV.Controls.Add(buttonPerform_MIV);
            groupBoxOutput_MIV.Controls.Add(dataGridViewOutput_MIV);
            groupBoxOutput_MIV.Location = new Point(602, 12);
            groupBoxOutput_MIV.Name = "groupBoxOutput_MIV";
            groupBoxOutput_MIV.Size = new Size(421, 426);
            groupBoxOutput_MIV.TabIndex = 1;
            groupBoxOutput_MIV.TabStop = false;
            groupBoxOutput_MIV.Text = "Вывод данных:";
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.Location = new Point(131, 379);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(57, 41);
            buttonQuestion_MIV.TabIndex = 2;
            buttonQuestion_MIV.Text = "?";
            buttonQuestion_MIV.UseVisualStyleBackColor = true;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // buttonPerform_MIV
            // 
            buttonPerform_MIV.Location = new Point(206, 379);
            buttonPerform_MIV.Name = "buttonPerform_MIV";
            buttonPerform_MIV.Size = new Size(105, 41);
            buttonPerform_MIV.TabIndex = 1;
            buttonPerform_MIV.Text = "Выполнить";
            buttonPerform_MIV.UseVisualStyleBackColor = true;
            buttonPerform_MIV.Click += buttonPerform_MIV_Click;
            // 
            // dataGridViewOutput_MIV
            // 
            dataGridViewOutput_MIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_MIV.Location = new Point(6, 22);
            dataGridViewOutput_MIV.Name = "dataGridViewOutput_MIV";
            dataGridViewOutput_MIV.Size = new Size(409, 351);
            dataGridViewOutput_MIV.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(groupBoxOutput_MIV);
            Controls.Add(groupBoxGeneral_MIV);
            Name = "Form1";
            Text = "Спринт 6 | Таск 3 | Вариант 16 | Молчанов И.В.";
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            groupBoxOutput_MIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_MIV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGeneral_MIV;
        private TextBox info_textBoxGeneral2_MIV;
        private TextBox info_textBoxGeneral1_MIV;
        private GroupBox groupBoxOutput_MIV;
        private DataGridView dataGridViewOutput_MIV;
        private Button buttonPerform_MIV;
        private Button buttonQuestion_MIV;
    }
}
