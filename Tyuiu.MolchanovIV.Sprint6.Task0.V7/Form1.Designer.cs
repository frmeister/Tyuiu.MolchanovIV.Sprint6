namespace Tyuiu.MolchanovIV.Sprint6.Task0.V7
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
            groupBoxGeneral_MIV = new GroupBox();
            pictureBoxGeneral_MIV = new PictureBox();
            infoGeneral_MIV = new TextBox();
            groupBoxInput_MIV = new GroupBox();
            infoInputText_MIV = new TextBox();
            inputText_MIV = new TextBox();
            groupBoxOutput_MIV = new GroupBox();
            outputText_MIV = new TextBox();
            infoOutputText_MIV = new TextBox();
            buttonDone_MIV = new Button();
            buttonQuestion_MIV = new Button();
            groupBoxGeneral_MIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneral_MIV).BeginInit();
            groupBoxInput_MIV.SuspendLayout();
            groupBoxOutput_MIV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGeneral_MIV
            // 
            groupBoxGeneral_MIV.Controls.Add(pictureBoxGeneral_MIV);
            groupBoxGeneral_MIV.Controls.Add(infoGeneral_MIV);
            groupBoxGeneral_MIV.Location = new Point(12, 23);
            groupBoxGeneral_MIV.Name = "groupBoxGeneral_MIV";
            groupBoxGeneral_MIV.Size = new Size(776, 258);
            groupBoxGeneral_MIV.TabIndex = 2;
            groupBoxGeneral_MIV.TabStop = false;
            groupBoxGeneral_MIV.Text = "Условие";
            // 
            // pictureBoxGeneral_MIV
            // 
            pictureBoxGeneral_MIV.Image = (Image)resources.GetObject("pictureBoxGeneral_MIV.Image");
            pictureBoxGeneral_MIV.Location = new Point(637, 22);
            pictureBoxGeneral_MIV.Name = "pictureBoxGeneral_MIV";
            pictureBoxGeneral_MIV.Size = new Size(133, 70);
            pictureBoxGeneral_MIV.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxGeneral_MIV.TabIndex = 3;
            pictureBoxGeneral_MIV.TabStop = false;
            pictureBoxGeneral_MIV.Click += pictureBoxGeneral_MIV_Click;
            // 
            // infoGeneral_MIV
            // 
            infoGeneral_MIV.BackColor = SystemColors.Control;
            infoGeneral_MIV.BorderStyle = BorderStyle.None;
            infoGeneral_MIV.Location = new Point(6, 22);
            infoGeneral_MIV.Name = "infoGeneral_MIV";
            infoGeneral_MIV.Size = new Size(215, 16);
            infoGeneral_MIV.TabIndex = 0;
            infoGeneral_MIV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_MIV
            // 
            groupBoxInput_MIV.Controls.Add(infoInputText_MIV);
            groupBoxInput_MIV.Controls.Add(inputText_MIV);
            groupBoxInput_MIV.Location = new Point(12, 287);
            groupBoxInput_MIV.Name = "groupBoxInput_MIV";
            groupBoxInput_MIV.Size = new Size(528, 107);
            groupBoxInput_MIV.TabIndex = 0;
            groupBoxInput_MIV.TabStop = false;
            groupBoxInput_MIV.Text = "Ввод данных";
            // 
            // infoInputText_MIV
            // 
            infoInputText_MIV.BackColor = SystemColors.Control;
            infoInputText_MIV.BorderStyle = BorderStyle.None;
            infoInputText_MIV.Location = new Point(6, 33);
            infoInputText_MIV.Name = "infoInputText_MIV";
            infoInputText_MIV.Size = new Size(84, 16);
            infoInputText_MIV.TabIndex = 5;
            infoInputText_MIV.Text = "Переменная Х:";
            infoInputText_MIV.TextAlign = HorizontalAlignment.Center;
            // 
            // inputText_MIV
            // 
            inputText_MIV.BorderStyle = BorderStyle.FixedSingle;
            inputText_MIV.Location = new Point(6, 55);
            inputText_MIV.Name = "inputText_MIV";
            inputText_MIV.Size = new Size(84, 23);
            inputText_MIV.TabIndex = 4;
            inputText_MIV.TextChanged += inputText_MIV_TextChanged;
            // 
            // groupBoxOutput_MIV
            // 
            groupBoxOutput_MIV.Controls.Add(outputText_MIV);
            groupBoxOutput_MIV.Controls.Add(infoOutputText_MIV);
            groupBoxOutput_MIV.Location = new Point(546, 287);
            groupBoxOutput_MIV.Name = "groupBoxOutput_MIV";
            groupBoxOutput_MIV.Size = new Size(242, 107);
            groupBoxOutput_MIV.TabIndex = 1;
            groupBoxOutput_MIV.TabStop = false;
            groupBoxOutput_MIV.Text = "Вывод данных";
            // 
            // outputText_MIV
            // 
            outputText_MIV.BorderStyle = BorderStyle.FixedSingle;
            outputText_MIV.Location = new Point(6, 62);
            outputText_MIV.Name = "outputText_MIV";
            outputText_MIV.Size = new Size(100, 23);
            outputText_MIV.TabIndex = 7;
            outputText_MIV.TextChanged += outputText_MIV_TextChanged;
            outputText_MIV.Enabled = false;
            // 
            // infoOutputText_MIV
            // 
            infoOutputText_MIV.BackColor = SystemColors.Control;
            infoOutputText_MIV.BorderStyle = BorderStyle.None;
            infoOutputText_MIV.Location = new Point(6, 33);
            infoOutputText_MIV.Name = "infoOutputText_MIV";
            infoOutputText_MIV.Size = new Size(78, 16);
            infoOutputText_MIV.TabIndex = 6;
            infoOutputText_MIV.Text = "Результат";
            infoOutputText_MIV.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDone_MIV
            // 
            buttonDone_MIV.Location = new Point(634, 400);
            buttonDone_MIV.Name = "buttonDone_MIV";
            buttonDone_MIV.Size = new Size(148, 38);
            buttonDone_MIV.TabIndex = 8;
            buttonDone_MIV.Text = "Выполнить";
            buttonDone_MIV.UseVisualStyleBackColor = true;
            buttonDone_MIV.Click += ButtonDone_MIV_Click;
            // 
            // buttonQuestion_MIV
            // 
            buttonQuestion_MIV.Location = new Point(562, 400);
            buttonQuestion_MIV.Name = "buttonQuestion_MIV";
            buttonQuestion_MIV.Size = new Size(42, 36);
            buttonQuestion_MIV.TabIndex = 9;
            buttonQuestion_MIV.Text = "?";
            buttonQuestion_MIV.UseVisualStyleBackColor = true;
            buttonQuestion_MIV.Click += buttonQuestion_MIV_Click;
            // 
            // FormMain_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_MIV);
            Controls.Add(buttonQuestion_MIV);
            Controls.Add(groupBoxOutput_MIV);
            Controls.Add(groupBoxInput_MIV);
            Controls.Add(groupBoxGeneral_MIV);
            Name = "FormMain_MIV";
            Text = "Спринт 6 | Таск 0 | Вариант 7| Молчанов И.В.";
            Load += Form1_Load;
            groupBoxGeneral_MIV.ResumeLayout(false);
            groupBoxGeneral_MIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneral_MIV).EndInit();
            groupBoxInput_MIV.ResumeLayout(false);
            groupBoxInput_MIV.PerformLayout();
            groupBoxOutput_MIV.ResumeLayout(false);
            groupBoxOutput_MIV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxGeneral_MIV;
        private GroupBox groupBoxInput_MIV;
        private TextBox infoGeneral_MIV;
        private GroupBox groupBoxOutput_MIV;
        private PictureBox pictureBoxGeneral_MIV;
        private TextBox infoInputText_MIV;
        private TextBox inputText_MIV;
        private TextBox outputText_MIV;
        private TextBox infoOutputText_MIV;
        private Button buttonDone_MIV;
        private Button buttonQuestion_MIV;
    }
}
