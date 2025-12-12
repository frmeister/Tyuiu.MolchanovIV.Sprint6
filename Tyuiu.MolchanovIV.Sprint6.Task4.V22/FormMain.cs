using Tyuiu.MolchanovIV.Sprint6.Task4.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task4.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonPerform_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputMin_MIV.Text);
                int stopStep = Convert.ToInt32(textBoxInputMax_MIV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arr = new double[len];
                arr = ds.GetMassFunction(startStep, stopStep);

                this.chart_MIV.Titles.Add("График функции");

                this.chart_MIV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_MIV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_MIV.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chart_MIV.Series[0].Points.AddXY(startStep, arr[i]);

                    string curLine = Convert.ToString(arr[i]);

                    textBoxOutput_MIV.AppendText(curLine + Environment.NewLine);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonQuestion_MIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void buttonSave_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = $@"{Path.GetTempPath()}";
                string filename = "OutPutFileTask4V22.txt";

                string outputPath = Path.Combine(filepath, filename);

                File.WriteAllText(outputPath, textBoxOutput_MIV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + outputPath + " сохранен успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (DialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = outputPath;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
