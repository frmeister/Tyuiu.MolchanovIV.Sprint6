using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int arrRows = matrix.GetUpperBound(0) + 1;
            int arrColumns = matrix.Length/arrRows;

            int[,] res = new int[arrRows, arrColumns];

            res = matrix;

            for (int i = 0; i < arrRows; i++)
            {
                for (int j = 0; j < arrColumns; j++)
                {
                    if ((i == 2) && (res[i, j] % 2 == 0))
                    {
                        res[i, j] = 0;
                    }
                }
            }

            return res;
        }
    }
}
