namespace Tyuiu.MolchanovIV.Sprint6.Task6.V13
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
            info_textBoxAbout_MIV = new TextBox();
            pictureBoxPhoto_MIV = new PictureBox();
            buttonAboutOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_MIV).BeginInit();
            SuspendLayout();
            // 
            // info_textBoxAbout_MIV
            // 
            info_textBoxAbout_MIV.BackColor = SystemColors.Control;
            info_textBoxAbout_MIV.BorderStyle = BorderStyle.None;
            info_textBoxAbout_MIV.Location = new Point(191, 12);
            info_textBoxAbout_MIV.Multiline = true;
            info_textBoxAbout_MIV.Name = "info_textBoxAbout_MIV";
            info_textBoxAbout_MIV.Size = new Size(281, 175);
            info_textBoxAbout_MIV.TabIndex = 0;
            info_textBoxAbout_MIV.Text = resources.GetString("info_textBoxAbout_MIV.Text");
            // 
            // pictureBoxPhoto_MIV
            // 
            pictureBoxPhoto_MIV.Image = (Image)resources.GetObject("pictureBoxPhoto_MIV.Image");
            pictureBoxPhoto_MIV.Location = new Point(12, 12);
            pictureBoxPhoto_MIV.Name = "pictureBoxPhoto_MIV";
            pictureBoxPhoto_MIV.Size = new Size(154, 175);
            pictureBoxPhoto_MIV.TabIndex = 1;
            pictureBoxPhoto_MIV.TabStop = false;
            // 
            // buttonAboutOk
            // 
            buttonAboutOk.Location = new Point(504, 226);
            buttonAboutOk.Name = "buttonAboutOk";
            buttonAboutOk.Size = new Size(68, 23);
            buttonAboutOk.TabIndex = 2;
            buttonAboutOk.Text = "Ok";
            buttonAboutOk.UseVisualStyleBackColor = true;
            buttonAboutOk.Click += buttonAboutOk_Click;
            // 
            // FormAbout_MIV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(buttonAboutOk);
            Controls.Add(pictureBoxPhoto_MIV);
            Controls.Add(info_textBoxAbout_MIV);
            MaximumSize = new Size(600, 300);
            MinimumSize = new Size(600, 300);
            Name = "FormAbout_MIV";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_MIV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox info_textBoxAbout_MIV;
        private PictureBox pictureBoxPhoto_MIV;
        private Button buttonAboutOk;
    }
}