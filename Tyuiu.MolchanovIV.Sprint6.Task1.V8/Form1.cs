using Tyuiu.MolchanovIV.Sprint6.Task1.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task1.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DataService ds = new DataService();

        private void buttonPerform_MIV_Clicked(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputMin_MIV.Text);
                int stopStep = Convert.ToInt32(textBoxInputMax_MIV.Text);

                string curLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArr;
                valueArr = new double[len];

                valueArr = ds.GetMassFunction(startStep, stopStep);
                textBoxOutput_MIV.Text = "";
                textBoxOutput_MIV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutput_MIV.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxOutput_MIV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    curLine = String.Format("|{0,5:d}   |  {0,5:f2}  |", startStep, valueArr[i]);
                    textBoxOutput_MIV.AppendText(curLine + Environment.NewLine);
                    startStep++;
                }

                textBoxOutput_MIV.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_MIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
