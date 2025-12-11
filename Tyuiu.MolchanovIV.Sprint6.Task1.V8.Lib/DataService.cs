using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1, cur = 0;

            double[] res = new double[length];

            for (int i = startValue; i <= stopValue; i++)
            {
                res[cur] = Math.Round((Math.Cos(i) / (i - 0.4)) + (Math.Sin(i) * 8 * i) + 2, 2);
                
                cur++;
            }

            return res;
        }
    }
}
