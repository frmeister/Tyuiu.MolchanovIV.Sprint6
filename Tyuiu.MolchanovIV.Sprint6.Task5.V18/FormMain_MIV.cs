using System.Runtime.InteropServices.Marshalling;
using Tyuiu.MolchanovIV.Sprint6.Task5.V18.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task5.V18
{
    public partial class FormMain_MIV : Form
    {
        public FormMain_MIV()
        {
            InitializeComponent();

            InitializeDataGridView();
        }

        DataService ds = new DataService();
        string path = $@"C:\DataSprint7\InPutDataFileTask5V18.txt";
        int strLen = 0;

        private void InitializeDataGridView()
        {
            double[] arrOut = ds.LoadFromDataFile(path);
            int len = ds.LoadFromDataFile(path).Length;

            dataGridViewOutput_MIV.RowCount = len;
            dataGridViewOutput_MIV.ColumnCount = 2;
            dataGridViewOutput_MIV.RowHeadersVisible = false;
            dataGridViewOutput_MIV.ColumnHeadersVisible = false;

           
           dataGridViewOutput_MIV.Columns[0].Width = 20;
           dataGridViewOutput_MIV.Columns[0].Width = 50;
        }

        private void buttonPerform_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                double[] arrOut = ds.LoadFromDataFile(path);
                int len = ds.LoadFromDataFile(path).Length;

                for (int i = 0; i < len; i++)
                {
                    if (arrOut[i] == 0) break;

                    dataGridViewOutput_MIV.Rows[i].Cells[1].Value = arrOut[i];
                    dataGridViewOutput_MIV.Rows[i].Cells[0].Value = i + 1;
                }

                this.chart_MIV.Titles.Add("Вещественные числа");

                for (int i = 0; i < len; i++)
                {
                    this.chart_MIV.Series[0].Points.AddXY(i, arrOut[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_MIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
