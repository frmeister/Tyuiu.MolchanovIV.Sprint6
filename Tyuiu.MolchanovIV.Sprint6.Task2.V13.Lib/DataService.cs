using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int arrLen = (stopValue - startValue);

            double[] res = new double[arrLen];

            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 * i / 3 == 0)
                {
                    res[i] = 0;  continue; 
                }
                res[i] = Math.Round(Math.Sin(i) + 2 * i / 3 - Math.Cos(i) * 4 * i, 2);
            }

            return res;
        }
    }
}
