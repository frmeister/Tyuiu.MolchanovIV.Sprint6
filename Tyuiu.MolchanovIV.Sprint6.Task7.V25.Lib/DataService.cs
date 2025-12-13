using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            int rows = 0, columns = 0; 

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

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((j == 6) && (arrValues[i, j] % 5 == 0)) arrValues[i, j] = 2;
                }
            }

            return arrValues;
        }
    }
}
