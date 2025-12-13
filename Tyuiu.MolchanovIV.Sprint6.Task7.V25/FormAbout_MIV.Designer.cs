namespace Tyuiu.MolchanovIV.Sprint6.Task7.V25
{
    partial class FormAbout_MIV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MIV));
            pictureBoxAbout_MIV = new PictureBox();
            textBox1 = new TextBox();
            buttonAboutOk_MIV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MIV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_MIV
            // 
            pictureBoxAbout_MIV.Image = (Image)resources.GetObject("pictureBoxAbout_MIV.Image");
            pictureBoxAbout_MIV.Location = new Point(12, 12);
            pictureBoxAbout_MIV.Name = "pictureBoxAbout_MIV";
            pictureBoxAbout_MIV.Size = new Size(172, 193);
            pictureBoxAbout_MIV.TabIndex = 0;
            pictureBoxAbout_MIV.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(209, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 193);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonAboutOk_MIV
            // 
            buttonAboutOk_MIV.Location = new Point(510, 226);
            buttonAboutOk_MIV.Name = "buttonAboutOk_MIV";
            buttonAboutOk_MIV.Size = new Size(62, 23);
            buttonAboutOk_MIV.TabIndex = 2;
            buttonAboutOk_MIV.Text = "ok";
            buttonAboutOk_MIV.UseVisualStyleBackColor = true;
            buttonAboutOk_MIV.Click += buttonAboutOk_MIV_Click;
            // 
            // FormAbout_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(buttonAboutOk_MIV);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxAbout_MIV);
            MaximumSize = new Size(600, 300);
            MinimumSize = new Size(600, 300);
            Name = "FormAbout_MIV";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_MIV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_MIV;
        private TextBox textBox1;
        private Button buttonAboutOk_MIV;
    }
}