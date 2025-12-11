using Tyuiu.MolchanovIV.Sprint6.Task2.V13.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task2.V13
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arr = new double[len];
                arr = ds.GetMassFunction(startStep, stopStep);

                this.chart_MIV.Titles.Add("График функции sin(x)");

                this.chart_MIV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_MIV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_MIV.Rows.Add(Convert.ToString(startStep), Convert.ToString(arr[i]));

                    this.chart_MIV.Series[0].Points.AddXY(startStep, arr[i]);

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
            MessageBox.Show("Таск 0 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
