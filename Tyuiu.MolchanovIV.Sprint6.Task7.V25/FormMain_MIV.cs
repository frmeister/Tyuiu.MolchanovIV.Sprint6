using System.IO;
using System.Xml;
using Tyuiu.MolchanovIV.Sprint6.Task7.V25.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task7.V25
{
    public partial class FormMain_MIV : Form
    {

        DataService ds = new DataService();

        static string openFilePath;

        static int rows = 0, columns = 0;

        public FormMain_MIV()
        {
            InitializeComponent();
        }

        public static int[,] inputArrayInit(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            return arrValues;
        }

        private void buttonAbout_MIV_Click(object sender, EventArgs e)
        {
            FormAbout_MIV formAbout = new FormAbout_MIV();
            formAbout.ShowDialog();
        }

        private void buttonOpen_MIV_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            openFilePath = openFileDialogMain.FileName;

            int[,] arrValues = new int[rows, columns];

            arrValues = inputArrayInit(openFilePath);

            dataGridViewInput_MIV.ColumnCount = columns;
            dataGridViewInput_MIV.RowCount = rows;
            dataGridViewOutput_MIV.ColumnCount = columns;
            dataGridViewOutput_MIV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_MIV.Columns[i].Width = 25;
                dataGridViewOutput_MIV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_MIV.Rows[i].Cells[j].Value = arrValues[i, j];
                }
            }

            buttonPerform_MIV.Enabled = true;

        }

        private void buttonPerform_MIV_Click(object sender, EventArgs e)
        {
            int[,] arrValues = new int[rows, columns];

            arrValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_MIV.Rows[i].Cells[j].Value = arrValues[i, j];
                }
            }

            buttonSave_MIV.Enabled = true;
        }

        private void buttonSave_MIV_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_MIV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMain_MIV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_MIV.ShowDialog();

            string path = saveFileDialogMain_MIV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if(fileExists) File.Delete(path);

            int rows = dataGridViewOutput_MIV.RowCount;
            int columns = dataGridViewOutput_MIV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_MIV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_MIV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }
        }
    }
}
