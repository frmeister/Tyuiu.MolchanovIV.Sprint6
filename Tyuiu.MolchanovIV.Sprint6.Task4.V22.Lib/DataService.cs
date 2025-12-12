using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            int curValue = startValue;

            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = Math.Round(Math.Sin(curValue) + (Math.Cos(curValue) / 2 - 1.5 * curValue), 2);
                curValue++;
            }

            return result;
        }
    }
}
