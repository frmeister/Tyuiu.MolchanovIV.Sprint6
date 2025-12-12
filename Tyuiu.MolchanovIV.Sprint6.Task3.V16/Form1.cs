using Tyuiu.MolchanovIV.Sprint6.Task3.V16.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task3.V16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeDataGridView();

            FillDataGridView();
        }

        DataService ds = new DataService();
        int[,] inputArray = { { 14, 1, -3, 1, 10 }, { 7, -3, 5, -4, 0 }, { -10, -19, -18, -9, 19 }, { -2, -2, -16, 2, -17 }, { -16, 9, 5, -10, 16 } };

        private void InitializeDataGridView()
        {
            dataGridViewOutput_MIV.RowCount = 5;
            dataGridViewOutput_MIV.ColumnCount = 5;
            dataGridViewOutput_MIV.RowHeadersVisible = false;
            dataGridViewOutput_MIV.ColumnHeadersVisible = false;

            for (int i = 0; i < 5; i++)
            {
                if (dataGridViewOutput_MIV.Columns.Count > i)
                    dataGridViewOutput_MIV.Columns[i].Width = 50;
            }
        }

        private void FillDataGridView()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewOutput_MIV.Rows[i].Cells[j].Value = inputArray[i, j];
                }
            }
        }

        private void buttonPerform_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] resultArray = new int[5, 5];

                resultArray = ds.Calculate(inputArray);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewOutput_MIV.Rows[i].Cells[j].Value = resultArray[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_MIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
